﻿namespace HslCommunicationDemo
{
    partial class FormMqttClient
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
			this.checkBox_sslSecure = new System.Windows.Forms.CheckBox();
			this.button_certificate = new System.Windows.Forms.Button();
			this.textBox_certificate = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.button_will_topic = new System.Windows.Forms.Button();
			this.checkBox_rsa = new System.Windows.Forms.CheckBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.checkBox_publish_isHex = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox_debug_info_show = new System.Windows.Forms.CheckBox();
			this.checkBox_long_message_hide = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button_publish = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.button9 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.radioButton_binary = new System.Windows.Forms.RadioButton();
			this.radioButton_json = new System.Windows.Forms.RadioButton();
			this.radioButton_text = new System.Windows.Forms.RadioButton();
			this.radioButton_xml = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.userControlHead1 = new HslCommunicationDemo.DemoControl.UserControlHead();
			this.panel4 = new System.Windows.Forms.Panel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.checkBox_sslSecure);
			this.panel1.Controls.Add(this.button_certificate);
			this.panel1.Controls.Add(this.textBox_certificate);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.button_will_topic);
			this.panel1.Controls.Add(this.checkBox_rsa);
			this.panel1.Controls.Add(this.textBox6);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBox11);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBox10);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox9);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(4, 35);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(996, 87);
			this.panel1.TabIndex = 7;
			// 
			// checkBox_sslSecure
			// 
			this.checkBox_sslSecure.AutoSize = true;
			this.checkBox_sslSecure.Location = new System.Drawing.Point(723, 63);
			this.checkBox_sslSecure.Name = "checkBox_sslSecure";
			this.checkBox_sslSecure.Size = new System.Drawing.Size(181, 21);
			this.checkBox_sslSecure.TabIndex = 36;
			this.checkBox_sslSecure.Text = "SSL Secure ?(server check)";
			this.checkBox_sslSecure.UseVisualStyleBackColor = true;
			// 
			// button_certificate
			// 
			this.button_certificate.Location = new System.Drawing.Point(655, 57);
			this.button_certificate.Name = "button_certificate";
			this.button_certificate.Size = new System.Drawing.Size(63, 28);
			this.button_certificate.TabIndex = 35;
			this.button_certificate.Text = "选择";
			this.button_certificate.UseVisualStyleBackColor = true;
			this.button_certificate.Click += new System.EventHandler(this.button_certificate_Click);
			// 
			// textBox_certificate
			// 
			this.textBox_certificate.Location = new System.Drawing.Point(87, 61);
			this.textBox_certificate.Name = "textBox_certificate";
			this.textBox_certificate.Size = new System.Drawing.Size(565, 23);
			this.textBox_certificate.TabIndex = 34;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(20, 63);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(68, 17);
			this.label14.TabIndex = 33;
			this.label14.Text = "使用证书：";
			// 
			// button_will_topic
			// 
			this.button_will_topic.Location = new System.Drawing.Point(922, 33);
			this.button_will_topic.Name = "button_will_topic";
			this.button_will_topic.Size = new System.Drawing.Size(63, 28);
			this.button_will_topic.TabIndex = 32;
			this.button_will_topic.Text = "遗嘱";
			this.button_will_topic.UseVisualStyleBackColor = true;
			this.button_will_topic.Click += new System.EventHandler(this.button_will_topic_Click);
			// 
			// checkBox_rsa
			// 
			this.checkBox_rsa.AutoSize = true;
			this.checkBox_rsa.Location = new System.Drawing.Point(591, 9);
			this.checkBox_rsa.Name = "checkBox_rsa";
			this.checkBox_rsa.Size = new System.Drawing.Size(192, 21);
			this.checkBox_rsa.TabIndex = 31;
			this.checkBox_rsa.Text = "RSA加密 (需要HSL服务器支持)";
			this.checkBox_rsa.UseVisualStyleBackColor = true;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(529, 7);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(50, 23);
			this.textBox6.TabIndex = 19;
			this.textBox6.Text = "100";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(456, 10);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 17);
			this.label11.TabIndex = 18;
			this.label11.Text = "KeepLive：";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(87, 34);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(290, 23);
			this.textBox3.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "客户端标识：";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(395, 7);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(54, 23);
			this.textBox11.TabIndex = 15;
			this.textBox11.Text = "5000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(329, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 14;
			this.label5.Text = "接收超时：";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(720, 34);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(196, 23);
			this.textBox10.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(658, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "密码：";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(447, 34);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(205, 23);
			this.textBox9.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(383, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "用户名：";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(895, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(91, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "断开连接";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(798, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "连接";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(263, 7);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(55, 23);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "1883";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(209, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "端口号：";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(62, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "127.0.0.1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 10);
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
			this.panel2.Controls.Add(this.checkBox_publish_isHex);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.checkBox_debug_info_show);
			this.panel2.Controls.Add(this.checkBox_long_message_hide);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.button_publish);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.button9);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.radioButton2);
			this.panel2.Controls.Add(this.radioButton1);
			this.panel2.Controls.Add(this.button8);
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.textBox8);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Location = new System.Drawing.Point(196, 123);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(804, 517);
			this.panel2.TabIndex = 13;
			// 
			// checkBox_publish_isHex
			// 
			this.checkBox_publish_isHex.AutoSize = true;
			this.checkBox_publish_isHex.Location = new System.Drawing.Point(7, 68);
			this.checkBox_publish_isHex.Name = "checkBox_publish_isHex";
			this.checkBox_publish_isHex.Size = new System.Drawing.Size(55, 21);
			this.checkBox_publish_isHex.TabIndex = 35;
			this.checkBox_publish_isHex.Text = "Hex?";
			this.checkBox_publish_isHex.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(622, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 28);
			this.button3.TabIndex = 34;
			this.button3.Text = "子窗体订阅";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// checkBox_debug_info_show
			// 
			this.checkBox_debug_info_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox_debug_info_show.AutoSize = true;
			this.checkBox_debug_info_show.Location = new System.Drawing.Point(256, 492);
			this.checkBox_debug_info_show.Name = "checkBox_debug_info_show";
			this.checkBox_debug_info_show.Size = new System.Drawing.Size(128, 21);
			this.checkBox_debug_info_show.TabIndex = 33;
			this.checkBox_debug_info_show.Text = "Debug Info Show";
			this.checkBox_debug_info_show.UseVisualStyleBackColor = true;
			// 
			// checkBox_long_message_hide
			// 
			this.checkBox_long_message_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox_long_message_hide.AutoSize = true;
			this.checkBox_long_message_hide.Checked = true;
			this.checkBox_long_message_hide.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_long_message_hide.Location = new System.Drawing.Point(414, 492);
			this.checkBox_long_message_hide.Name = "checkBox_long_message_hide";
			this.checkBox_long_message_hide.Size = new System.Drawing.Size(99, 21);
			this.checkBox_long_message_hide.TabIndex = 32;
			this.checkBox_long_message_hide.Text = "超长消息简略";
			this.checkBox_long_message_hide.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(148, 180);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(161, 25);
			this.comboBox1.TabIndex = 31;
			// 
			// button_publish
			// 
			this.button_publish.Location = new System.Drawing.Point(315, 179);
			this.button_publish.Name = "button_publish";
			this.button_publish.Size = new System.Drawing.Size(94, 28);
			this.button_publish.TabIndex = 29;
			this.button_publish.Text = "发布";
			this.button_publish.UseVisualStyleBackColor = true;
			this.button_publish.Click += new System.EventHandler(this.button10_Click);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(59, 493);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 17);
			this.label10.TabIndex = 28;
			this.label10.Text = "Receive Count:";
			// 
			// button9
			// 
			this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button9.Location = new System.Drawing.Point(726, 5);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(71, 28);
			this.button9.TabIndex = 27;
			this.button9.Text = "压力测试";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Visible = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.radioButton_binary);
			this.panel3.Controls.Add(this.radioButton_json);
			this.panel3.Controls.Add(this.radioButton_text);
			this.panel3.Controls.Add(this.radioButton_xml);
			this.panel3.Location = new System.Drawing.Point(546, 180);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(246, 28);
			this.panel3.TabIndex = 26;
			// 
			// radioButton_binary
			// 
			this.radioButton_binary.AutoSize = true;
			this.radioButton_binary.Location = new System.Drawing.Point(3, 3);
			this.radioButton_binary.Name = "radioButton_binary";
			this.radioButton_binary.Size = new System.Drawing.Size(62, 21);
			this.radioButton_binary.TabIndex = 29;
			this.radioButton_binary.Text = "Binary";
			this.radioButton_binary.UseVisualStyleBackColor = true;
			// 
			// radioButton_json
			// 
			this.radioButton_json.AutoSize = true;
			this.radioButton_json.Location = new System.Drawing.Point(175, 3);
			this.radioButton_json.Name = "radioButton_json";
			this.radioButton_json.Size = new System.Drawing.Size(52, 21);
			this.radioButton_json.TabIndex = 28;
			this.radioButton_json.Text = "Json";
			this.radioButton_json.UseVisualStyleBackColor = true;
			// 
			// radioButton_text
			// 
			this.radioButton_text.AutoSize = true;
			this.radioButton_text.Checked = true;
			this.radioButton_text.Location = new System.Drawing.Point(65, 3);
			this.radioButton_text.Name = "radioButton_text";
			this.radioButton_text.Size = new System.Drawing.Size(50, 21);
			this.radioButton_text.TabIndex = 26;
			this.radioButton_text.TabStop = true;
			this.radioButton_text.Text = "Text";
			this.radioButton_text.UseVisualStyleBackColor = true;
			// 
			// radioButton_xml
			// 
			this.radioButton_xml.AutoSize = true;
			this.radioButton_xml.Location = new System.Drawing.Point(121, 3);
			this.radioButton_xml.Name = "radioButton_xml";
			this.radioButton_xml.Size = new System.Drawing.Size(48, 21);
			this.radioButton_xml.TabIndex = 27;
			this.radioButton_xml.Text = "Xml";
			this.radioButton_xml.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(466, 174);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(74, 21);
			this.radioButton2.TabIndex = 25;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "追加显示";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(466, 192);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(74, 21);
			this.radioButton1.TabIndex = 24;
			this.radioButton1.Text = "覆盖显示";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button8.Location = new System.Drawing.Point(512, 5);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(104, 28);
			this.button8.TabIndex = 23;
			this.button8.Text = "取消订阅";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8_Click);
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.Location = new System.Drawing.Point(408, 5);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(98, 28);
			this.button7.TabIndex = 22;
			this.button7.Text = "订阅";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// textBox8
			// 
			this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox8.Location = new System.Drawing.Point(62, 214);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox8.Size = new System.Drawing.Size(735, 275);
			this.textBox8.TabIndex = 18;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(2, 216);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 17);
			this.label12.TabIndex = 19;
			this.label12.Text = "Receive：";
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(726, 489);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(71, 25);
			this.button4.TabIndex = 17;
			this.button4.Text = "清空";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox4.Location = new System.Drawing.Point(62, 36);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(735, 138);
			this.textBox4.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 11;
			this.label9.Text = "Payload：";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(345, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 17);
			this.label8.TabIndex = 10;
			this.label8.Text = "主题信息";
			// 
			// textBox5
			// 
			this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox5.Location = new System.Drawing.Point(62, 7);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(276, 23);
			this.textBox5.TabIndex = 9;
			this.textBox5.Text = "A";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "Topic：";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(62, 184);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(69, 21);
			this.checkBox1.TabIndex = 30;
			this.checkBox1.Text = "Retain?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// userControlHead1
			// 
			this.userControlHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.userControlHead1.Dock = System.Windows.Forms.DockStyle.Top;
			this.userControlHead1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.userControlHead1.HelpLink = "https://www.cnblogs.com/dathlin/p/11631894.html";
			this.userControlHead1.Location = new System.Drawing.Point(0, 0);
			this.userControlHead1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.userControlHead1.MinimumSize = new System.Drawing.Size(800, 32);
			this.userControlHead1.Name = "userControlHead1";
			this.userControlHead1.ProtocolInfo = "MQTT";
			this.userControlHead1.Size = new System.Drawing.Size(1004, 32);
			this.userControlHead1.TabIndex = 14;
			this.userControlHead1.SaveConnectEvent += new System.EventHandler<System.EventArgs>(this.userControlHead1_SaveConnectEvent_1);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.listBox1);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Location = new System.Drawing.Point(4, 123);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(189, 517);
			this.panel4.TabIndex = 15;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 17;
			this.listBox1.Location = new System.Drawing.Point(3, 23);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(181, 480);
			this.listBox1.TabIndex = 9;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(129, 17);
			this.label13.TabIndex = 8;
			this.label13.Text = "Subscribed：(已订阅)";
			// 
			// FormMqttClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1004, 645);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.userControlHead1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormMqttClient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MQTT客户端";
			this.Load += new System.EventHandler(this.FormClient_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private DemoControl.UserControlHead userControlHead1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton_json;
        private System.Windows.Forms.RadioButton radioButton_xml;
        private System.Windows.Forms.RadioButton radioButton_text;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button_publish;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox_rsa;
		private System.Windows.Forms.Button button_will_topic;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox_long_message_hide;
		private System.Windows.Forms.CheckBox checkBox_debug_info_show;
		private System.Windows.Forms.RadioButton radioButton_binary;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox_publish_isHex;
		private System.Windows.Forms.Button button_certificate;
		private System.Windows.Forms.TextBox textBox_certificate;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox checkBox_sslSecure;
	}
}