using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication;

namespace HslCommunicationDemo
{
	public partial class FormIndex : HslFormContent
	{
		public FormIndex( )
		{
			InitializeComponent( );
		}

		private void LinkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			FormLoad.OpenWebside( linkLabel1.Text );
		}

		private void FormCharge_Load( object sender, EventArgs e )
		{
			SetUpdayeInfo( );

			if(Program.Language == 2)
			{
				Text = "Start Page";
			}

		}

		private void SetUpdayeInfo( )
		{
			textBox1.Text = @"V12.9.1
1. MelsecMcNet: 修复了使用标签地址的时候，读取bool数组的时候，实际数据解析不正确的bug，支持了bool数组的写入操作。
2. IReadWriteNet: 一个设备通用的接口IReadWriteNet新增属性ByteTransform，方便直接操作数据变化对象，修改字符串是否颠倒等功能。实际也可以使用类DeviceCommunication
3. HslReflection: 优化基于特性的功能代码，增加了字符串数组属性的读写操作，适配了西门子S7协议，在官网的地址增加了特别的说明。
4. OmronConnectedCipNet: 修复欧姆龙基于连接的CIP协议在写入不存在的标签的时候，仍然提示写入成功的bug，修复cip虚拟服务器在读写不存在的标签的时候直接报错的bug。
5. SiemensS7Server: 西门子的虚拟服务器存储及加载数据文件支持了自定义的DB块，Demo界面优化，当加载数据的时候，自动填入当前的DB块数据信息。
6. MelsecMcNet: 三菱的MC协议支持随机字写入功能，随机字读取支持分批次读取合并，虚拟服务器支持对应的随机写入功能码。
7. Demo: MqttServer的测试界面里，当收到各种主题数据分类统计的时候，顺序显示连续收到两次统一主题的时间差，方便查看间隔。
8. Demo: 串口调试的界面，增加了一个控制流设置，可以根据实际的情况来设置值。
9. Demo: 企业用户的证书注册功能，支持了自定义分类信息，方便证书多的时候，管理，注意：证书不能移动，想要移动只能重新注册证书。
10. Demo: OpenProtocol开放协议的客户端测试界面优化，订阅数据的界面，使用表格区分每个订阅推送的MID消息，可以随时切换查看不同MID的数据。
11. Demo: 优化定时读写部分的逻辑，当勾选定时读或是定时写之后，再修改定时时间，然后点击按钮启动定时，修改的时间也生效。
12. Demo: 修复西门子S7Plus协议得测试demo里，当连接成功进行读写测试时，示例代码没有正确生成的bug。修复读写示例代码里地址带引号生成代码拷贝出来无法编译的bug。
13. Demo: TCP调试的界面，当配置了多个报文管理的时候，然后配置了自动返回报文之后，支持按顺序给客户端返回报文的操作。
14. 新官网：http://www.hsltechnology.cn:7900/，还有全新的使用文档的地址(V12版本升级说明)：http://www.hsltechnology.cn:7900/Doc/HslCommunication
15. 本软件已经申请软件著作权，软著登记号：2020SR0340826，任何盗用软件，破解软件，未经正式合同授权而商业使用均视为侵权。";
		}


		private void ShowActiveCode( )
		{
			textBox1.Text = @"/// <summary>
														  /// 应用程序的主入口点。
														  /// </summary>
[STAThread]
static void Main( )
{
	// 中文授权示例
	if(!HslCommunication.Authorization.SetAuthorizationCode( " + "\"你的激活码\"" + @" ))
	{
		DemoUtils.ShowMessage( " + "\"授权失败！当前程序只能使用24小时！\"" + @" );
		return; // 激活失败就退出系统
	}

	// English For example
	if(!HslCommunication.Authorization.SetAuthorizationCode( " + "\"Your Active Code\"" + @" ))
	{
		DemoUtils.ShowMessage( " + "\"Active Failed! it can only use 24 hours\"" + @" );
		return;  // quit if active failed
	}
	Application.EnableVisualStyles( );
	Application.SetCompatibleTextRenderingDefault( false );
	Application.Run( new Form1( ) );
}";
		}

		private void label15_Click( object sender, EventArgs e )
		{
			ShowActiveCode( );
		}

		private void label14_Click( object sender, EventArgs e )
		{
			SetUpdayeInfo( );
		}

		private void linkLabel2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			FormLoad.OpenWebside( linkLabel2.Text );
		}
	}
}
