﻿namespace HslCommunicationDemo
{
    partial class FormAllenBrandlyPCCC
	{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.userControlHead1 = new HslCommunicationDemo.DemoControl.UserControlHead();
			this.userControlReadWriteDevice1 = new HslCommunicationDemo.DemoControl.UserControlReadWriteDevice();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(3, 35);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(997, 42);
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(610, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Micro-Logix1400";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(537, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "适用：";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(610, 3);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(300, 17);
			this.label22.TabIndex = 7;
			this.label22.Text = "A9:0  B2:0    N2:10   S:1/15   F8:5  S1:0   C2:0  T2:0\r\n";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(537, 3);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(68, 17);
			this.label21.TabIndex = 6;
			this.label21.Text = "地址示例：";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(439, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "断开连接";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(347, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "连接";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(269, 9);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(52, 23);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "44818";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(215, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "端口号：";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(62, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "192.168.0.100";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ip地址：";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.userControlReadWriteDevice1);
			this.panel2.Location = new System.Drawing.Point(3, 80);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(997, 562);
			this.panel2.TabIndex = 1;
			// 
			// userControlHead1
			// 
			this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
			this.userControlHead1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userControlHead1.HelpLink = "https://www.cnblogs.com/dathlin/p/9607929.html";
			this.userControlHead1.Location = new System.Drawing.Point(0, 0);
			this.userControlHead1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.userControlHead1.MinimumSize = new System.Drawing.Size(800, 32);
			this.userControlHead1.Name = "userControlHead1";
			this.userControlHead1.ProtocolInfo = "CIP-PCCC";
			this.userControlHead1.Size = new System.Drawing.Size(1004, 32);
			this.userControlHead1.SupportListVisiable = true;
			this.userControlHead1.TabIndex = 2;
			this.userControlHead1.SaveConnectEvent += new System.EventHandler<System.EventArgs>(this.userControlHead1_SaveConnectEvent_1);
			// 
			// userControlReadWriteDevice1
			// 
			this.userControlReadWriteDevice1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlReadWriteDevice1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userControlReadWriteDevice1.Location = new System.Drawing.Point(0, 0);
			this.userControlReadWriteDevice1.Name = "userControlReadWriteDevice1";
			this.userControlReadWriteDevice1.Size = new System.Drawing.Size(995, 560);
			this.userControlReadWriteDevice1.TabIndex = 0;
			// 
			// FormAllenBrandlyPCCC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.userControlHead1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormAllenBrandlyPCCC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AB PLC PCCC访问Demo";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSiemens_FormClosing);
			this.Load += new System.EventHandler(this.FormSiemens_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private DemoControl.UserControlHead userControlHead1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private DemoControl.UserControlReadWriteDevice userControlReadWriteDevice1;
	}
}