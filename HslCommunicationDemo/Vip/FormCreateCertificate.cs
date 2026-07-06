using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.Core.Security;
using HslCommunication.MQTT;
using HslRedisDesktop;

namespace HslCommunicationDemo.Vip
{
	public partial class FormCreateCertificate : HslFormContent
	{
		public FormCreateCertificate( ImageList imageList, MqttSyncClient rpc, string company )
		{
			this.rpc = rpc;
			this.company = company;
			InitializeComponent( );


			certificateListControl= new CertificateListControl( );
			certificateListControl.Parent = panel1;
			certificateListControl.Dock = DockStyle.Fill;
			certificateListControl.Visible = true;

			certificateControl = new HslCertificateControl( );
			certificateControl.Parent = panel1;
			certificateControl.Dock = DockStyle.Fill;
			certificateControl.SetReadOnly( true );
			certificateControl.Visible = false;
			certificateControl.SetRpcClient( rpc );

			treeView1.ImageList = imageList;

			deleteToolStripMenuItem.Click +=DeleteToolStripMenuItem_Click;
			添加分类ToolStripMenuItem.Click += 添加分类ToolStripMenuItem_Click;
			添加证书ToolStripMenuItem.Click += 添加证书ToolStripMenuItem_Click;

			this.FormClosing += FormCreateCertificate_FormClosing;
			this.timer = new System.Windows.Forms.Timer( );
			this.timer.Interval = 10_000;
			this.timer.Tick += Timer_Tick;
			this.timer.Start( );
		}

		private void Timer_Tick( object sender, EventArgs e )
		{
			ThreadPool.QueueUserWorkItem( new WaitCallback(new Action<object>( m =>
			{
				OperateResult<string> read = this.rpc.ReadRpc<string>( "GetCompany", "" );
				if (read.IsSuccess == false)
				{
					Invoke( new Action( ( ) =>
					{
						this.timer.Stop( );
					} ) );
				}
			} ) ), new object() );
		}

		private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer( );

		private void FormCreateCertificate_FormClosing( object sender, FormClosingEventArgs e )
		{
			timer.Enabled = false;
			rpc.ConnectClose( );
		}

		private void 添加证书ToolStripMenuItem_Click( object sender, EventArgs e )
		{
			TreeNode node = treeView1.SelectedNode;
			if (node == null) return;

			string group = "";
			if (node.SelectedImageKey == "folder_Closed_16xLG")
			{
				group = node.Text;
			}

			certificateControl.SetCompanyName( company );
			certificateControl.Visible = true;
			certificateListControl.Visible = false;
			certificateControl.SetEditMode( true );
			certificateControl.ClearInput( );

			certificateControl.SetGroup( group );

			if (node.ImageKey == "CSharpFile_SolutionExplorerNode")
			{
				certificateControl.SetLanguage( 0 );
				return;
			}
			if (node.ImageKey == "java")
			{
				certificateControl.SetLanguage( 1 );
				return;
			}
			if (node.Parent != null && node.Parent.ImageKey == "CSharpFile_SolutionExplorerNode")
			{
				certificateControl.SetLanguage( 0 );
				return;
			}
			if (node.Parent != null && node.Parent.ImageKey == "java")
			{
				certificateControl.SetLanguage( 1 );
				return;
			}
		}

		private void 添加分类ToolStripMenuItem_Click( object sender, EventArgs e )
		{
			TreeNode node = treeView1.SelectedNode;
			if (node == null) return;
			if (node.Parent != null) return;

			FormInputString form = new FormInputString( );
			if (form.ShowDialog( this ) == DialogResult.OK )
			{
				TreeNode groupNode = new TreeNode( form.InputValue );
				groupNode.ImageKey = "folder_Closed_16xLG";
				groupNode.SelectedImageKey = "folder_Closed_16xLG";

				if (node.Nodes.Count == 0)
				{
					node.Nodes.Add( groupNode );
				}
				else
				{
					int index = 0;
					for (int i = 0; i < node.Nodes.Count; i++)
					{
						index = i;
						if (node.Nodes[i].SelectedImageKey != "folder_Closed_16xLG")
						{
							break;
						}
					}
					node.Nodes.Insert( index, groupNode );
				}
			}
		}

		private void DeleteToolStripMenuItem_Click( object sender, EventArgs e )
		{
			TreeNode treeNode = treeView1.SelectedNode;
			if (treeNode == null) return;

			if (treeNode.Tag is CertificateItem item)
			{
				if (treeNode.Parent == null) return;


				if (MessageBox.Show( $"Are you sure to delete [{item.Certificate.To}] certificate?", "Delete Confirm", MessageBoxButtons.YesNo ) == DialogResult.Yes)
				{
					bool isCSharp = treeNode.Parent.ImageKey == "CSharpFile_SolutionExplorerNode";
					if (treeNode.Parent.ImageKey == "folder_Closed_16xLG" && treeNode.Parent.Parent != null && treeNode.Parent.Parent.ImageKey == "CSharpFile_SolutionExplorerNode")
						isCSharp = true;
					string api = isCSharp ? "DeleteDotNetCertificate" : "DeleteJavaCertificate";
					OperateResult delete = rpc.ReadRpc<string>( api, new { userName = item.Certificate.To } );
					if (delete.IsSuccess)
					{
						MessageBox.Show( "Delete Success!" );
						treeView1.Nodes.Remove( treeNode );
					}
					else
					{
						MessageBox.Show( "Delete Failed: " + delete.Message );
					}
				}
			}
		}

		private void FormCreateCertificate_Load( object sender, EventArgs e )
		{
			treeView1.Nodes[0].ImageKey = "CSharpFile_SolutionExplorerNode";
			treeView1.Nodes[0].SelectedImageKey = "CSharpFile_SolutionExplorerNode";
			treeView1.Nodes[1].ImageKey = "java";
			treeView1.Nodes[1].SelectedImageKey = "java";

			if (Program.Language == 2)
			{
				button_refresh_cert.Text = "Refresh";
				button_new.Text = "New";
			}
		}







		private void RefreshCertificate( )
		{
			OperateResult<List<byte[]>> read = rpc.ReadRpc<List<byte[]>>( "GetAllCertificate", "" );
			Invoke( new Action( ( ) =>
			{
				if (read.IsSuccess == false)
				{
					MessageBox.Show( "Read Certificate Failed: " + read.Message );
					return;
				}

				treeView1.Nodes[0].Nodes.Clear( );
				treeView1.Nodes[1].Nodes.Clear( );

				List<CertificateItem> certificateItems = new List<CertificateItem>( );
				for (int i = 0; i < read.Content.Count; i++)
				{
					try
					{
						HslCertificate certificate = new HslCertificate( );
						certificate.LoadFrom( read.Content[i] );
						CertificateItem certificateItem = new CertificateItem( )
						{
							Name = $"{certificate.To} ({certificate.NotAfter.ToString( "yyyy-MM-dd" )})",
							Certificate = certificate,
							CertBinary = read.Content[i],
						};
						certificateItems.Add( certificateItem );
					}
					catch
					{
						continue;
					}
				}
				certificateItems.Sort( ( a, b ) => a.Certificate.To.CompareTo( b.Certificate.To ) );



				for (int i = 0; i < certificateItems.Count; i++)
				{
					try
					{
						HslCertificate certificate = certificateItems[i].Certificate;
						TreeNode node = new TreeNode( certificateItems[i].Name );
						node.ImageKey = "Certificate";
						node.SelectedImageKey = "Certificate";
						node.Tag = certificateItems[i];

						string group = "";
						if (certificateItems[i].Certificate.Descriptions != null &&
						certificateItems[i].Certificate.Descriptions.ContainsKey( "Group" ))
						{
							group = certificateItems[i].Certificate.Descriptions["Group"];
						}
						if (certificate.Descriptions.ContainsKey( "语言" ))
						{
							if (certificate.Descriptions["语言"].Equals( "DotNet", StringComparison.OrdinalIgnoreCase ))
								AddCertToNode( treeView1.Nodes[0], group, node );
							else
								AddCertToNode( treeView1.Nodes[1], group, node );
						}
					}
					catch (Exception ex)
					{
						DemoUtils.ShowMessage( $"[{i}] 证书加载失败: " + ex.Message );
					}
				}

				treeView1.ExpandAll( );
				treeView1.SelectedNode = null;
			} ) );
		}

		private void AddCertToNode( TreeNode root, string group, TreeNode certNode )
		{
			if (string.IsNullOrEmpty( group ))
				root.Nodes.Add( certNode );
			else
			{
				// 先找一下，有没有现成的分类
				for ( int i = 0; i < root.Nodes.Count; i++ )
				{
					TreeNode node = root.Nodes[i];
					if (node.SelectedImageKey == "folder_Closed_16xLG" && node.Text == group)
					{
						node.Nodes.Add ( certNode );
						return;
					}
				}

				// 没有找到，就创建一个，放到最上面去
				TreeNode groupNode = new TreeNode( group );
				groupNode.ImageKey = "folder_Closed_16xLG";
				groupNode.SelectedImageKey = "folder_Closed_16xLG";

				if (root.Nodes.Count == 0)
				{
					root.Nodes.Add( groupNode );
				}
				else
				{
					int index = 0;
					for (int i = 0; i < root.Nodes.Count; i++)
					{
						index = i;
						if (root.Nodes[i].SelectedImageKey != "folder_Closed_16xLG")
						{
							break;
						}
					}
					root.Nodes.Insert( index, groupNode );
				}

				groupNode.Nodes.Add( certNode );
			}
		}

		private MqttSyncClient rpc = null;
		private string company = string.Empty;
		private CertificateListControl certificateListControl = null;
		private HslCertificateControl certificateControl = null;

		private void FormCreateCertificate_Shown( object sender, EventArgs e )
		{
			ThreadPool.QueueUserWorkItem( new WaitCallback( ( m ) =>
			{
				RefreshCertificate( );
			} ), null );
		}

		private void button_refresh_cert_Click( object sender, EventArgs e )
		{
			button_refresh_cert.Enabled = false;
			ThreadPool.QueueUserWorkItem( new WaitCallback( ( m ) =>
			{
				RefreshCertificate( );
				Invoke( new Action( ( ) => button_refresh_cert.Enabled = true ) );
			} ), null );
		}

		private void treeView1_AfterSelect( object sender, TreeViewEventArgs e )
		{
			TreeNode node = e.Node;
			if  (node.Tag is CertificateItem item)
			{
				certificateControl.RenderHslCertificate( item );
				certificateControl.Visible = true;
				certificateListControl.Visible = false;
				return;
			}

			if (node.Parent == null && node.Text.Contains( "DotNet"))
			{
				List<CertificateItem> items = new List<CertificateItem>( );
				for ( int i = 0; i < node.Nodes.Count; i++ )
				{
					if (node.Nodes[i].Tag is CertificateItem item2)
						items.Add( item2 );
				}
				certificateListControl.SetCertificates(rpc, items );
				certificateControl.Visible = false;
				certificateListControl.Visible = true;
				return;
			}
			if (node.Parent == null && node.Text.Contains( "Java"))
			{
				List<CertificateItem> items = new List<CertificateItem>( );
				for ( int i = 0; i < node.Nodes.Count; i++ )
				{
					if (node.Nodes[i].Tag is CertificateItem item2)
						items.Add( item2 );
				}
				certificateListControl.SetCertificates( rpc, items );
				certificateControl.Visible = false;
				certificateListControl.Visible = true;
				return;
			}
			if (node.ImageKey == "folder_Closed_16xLG")
			{
				List<CertificateItem> items = new List<CertificateItem>( );
				for (int i = 0; i < node.Nodes.Count; i++)
				{
					if (node.Nodes[i].Tag is CertificateItem item2)
						items.Add( item2 );
				}
				certificateListControl.SetCertificates( rpc, items );
				certificateControl.Visible = false;
				certificateListControl.Visible = true;
				return;
			}
		}

		private void button_new_Click( object sender, EventArgs e )
		{
			certificateControl.SetCompanyName( company );
			certificateControl.Visible = true;
			certificateListControl.Visible = false;
			certificateControl.SetEditMode( true );
			certificateControl.ClearInput( );
		}

		private void treeView1_MouseClick( object sender, MouseEventArgs e )
		{
			TreeNode treeNode = treeView1.GetNodeAt( e.Location );
			if (treeNode == null) return;

			if (treeNode.Tag is CertificateItem item)
			{
				treeView1.SelectedNode = treeNode;
				if (e.Button == MouseButtons.Right)
				{
					contextMenuStrip1.Show( treeView1, e.Location );
				}
			}
			else if (treeNode.Parent == null)
			{
				treeView1.SelectedNode = treeNode;
				if (e.Button == MouseButtons.Right)
				{
					添加分类ToolStripMenuItem.Enabled = true;
					contextMenuStrip2.Show( treeView1, e.Location );
				}
			}
			else
			{
				treeView1.SelectedNode = treeNode;
				if (treeNode.SelectedImageKey == "folder_Closed_16xLG")
				{
					if (e.Button == MouseButtons.Right)
					{
						添加分类ToolStripMenuItem.Enabled = false;
						contextMenuStrip2.Show( treeView1, e.Location );
					}
				}
			}
		}
	}

	public class CertificateItem
	{
		public string Name { get; set; }

		public HslCertificate Certificate { get; set; }

		public byte[] CertBinary { get; set; }

		public override string ToString( ) => Name;
	}
}
