namespace MySchool
{
    partial class StuAddUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dtpOutDate = new System.Windows.Forms.DateTimePicker();
            this.MaincboGrade = new System.Windows.Forms.ComboBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWomen = new System.Windows.Forms.RadioButton();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.gbRegisterUser = new System.Windows.Forms.GroupBox();
            this.tbIsPwd = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbStuNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBaseInfo = new System.Windows.Forms.GroupBox();
            this.tbPhope = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRegisterUser.SuspendLayout();
            this.gbBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 529);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtpOutDate
            // 
            this.dtpOutDate.Location = new System.Drawing.Point(91, 209);
            this.dtpOutDate.Name = "dtpOutDate";
            this.dtpOutDate.Size = new System.Drawing.Size(243, 21);
            this.dtpOutDate.TabIndex = 20;
            // 
            // MaincboGrade
            // 
            this.MaincboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaincboGrade.FormattingEnabled = true;
            this.MaincboGrade.Location = new System.Drawing.Point(91, 102);
            this.MaincboGrade.Name = "MaincboGrade";
            this.MaincboGrade.Size = new System.Drawing.Size(243, 20);
            this.MaincboGrade.TabIndex = 16;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(209, 71);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(41, 16);
            this.rbMan.TabIndex = 15;
            this.rbMan.Text = " 男";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWomen
            // 
            this.rbWomen.AutoSize = true;
            this.rbWomen.Checked = true;
            this.rbWomen.Location = new System.Drawing.Point(107, 71);
            this.rbWomen.Name = "rbWomen";
            this.rbWomen.Size = new System.Drawing.Size(41, 16);
            this.rbWomen.TabIndex = 14;
            this.rbWomen.TabStop = true;
            this.rbWomen.Text = " 女";
            this.rbWomen.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(91, 245);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(243, 21);
            this.tbEmail.TabIndex = 13;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(91, 173);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(243, 21);
            this.tbAddress.TabIndex = 11;
            // 
            // gbRegisterUser
            // 
            this.gbRegisterUser.Controls.Add(this.tbIsPwd);
            this.gbRegisterUser.Controls.Add(this.tbPwd);
            this.gbRegisterUser.Controls.Add(this.tbStuNo);
            this.gbRegisterUser.Controls.Add(this.label3);
            this.gbRegisterUser.Controls.Add(this.label2);
            this.gbRegisterUser.Controls.Add(this.label1);
            this.gbRegisterUser.Location = new System.Drawing.Point(20, 12);
            this.gbRegisterUser.Name = "gbRegisterUser";
            this.gbRegisterUser.Size = new System.Drawing.Size(381, 149);
            this.gbRegisterUser.TabIndex = 20;
            this.gbRegisterUser.TabStop = false;
            this.gbRegisterUser.Text = "用户注册信息";
            // 
            // tbIsPwd
            // 
            this.tbIsPwd.Location = new System.Drawing.Point(91, 110);
            this.tbIsPwd.Name = "tbIsPwd";
            this.tbIsPwd.PasswordChar = '*';
            this.tbIsPwd.Size = new System.Drawing.Size(243, 21);
            this.tbIsPwd.TabIndex = 5;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(91, 65);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(243, 21);
            this.tbPwd.TabIndex = 4;
            // 
            // tbStuNo
            // 
            this.tbStuNo.Location = new System.Drawing.Point(91, 20);
            this.tbStuNo.Name = "tbStuNo";
            this.tbStuNo.Size = new System.Drawing.Size(243, 21);
            this.tbStuNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // gbBaseInfo
            // 
            this.gbBaseInfo.Controls.Add(this.dtpOutDate);
            this.gbBaseInfo.Controls.Add(this.MaincboGrade);
            this.gbBaseInfo.Controls.Add(this.rbMan);
            this.gbBaseInfo.Controls.Add(this.rbWomen);
            this.gbBaseInfo.Controls.Add(this.tbEmail);
            this.gbBaseInfo.Controls.Add(this.tbAddress);
            this.gbBaseInfo.Controls.Add(this.tbPhope);
            this.gbBaseInfo.Controls.Add(this.tbName);
            this.gbBaseInfo.Controls.Add(this.label10);
            this.gbBaseInfo.Controls.Add(this.label9);
            this.gbBaseInfo.Controls.Add(this.label8);
            this.gbBaseInfo.Controls.Add(this.label7);
            this.gbBaseInfo.Controls.Add(this.label6);
            this.gbBaseInfo.Controls.Add(this.label5);
            this.gbBaseInfo.Controls.Add(this.label4);
            this.gbBaseInfo.Location = new System.Drawing.Point(20, 181);
            this.gbBaseInfo.Name = "gbBaseInfo";
            this.gbBaseInfo.Size = new System.Drawing.Size(381, 297);
            this.gbBaseInfo.TabIndex = 21;
            this.gbBaseInfo.TabStop = false;
            this.gbBaseInfo.Text = "用户基本信息";
            // 
            // tbPhope
            // 
            this.tbPhope.Location = new System.Drawing.Point(91, 137);
            this.tbPhope.Name = "tbPhope";
            this.tbPhope.Size = new System.Drawing.Size(243, 21);
            this.tbPhope.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(243, 21);
            this.tbName.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "出生日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "年级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // StuAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbRegisterUser);
            this.Controls.Add(this.gbBaseInfo);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StuAddUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.StuAddUpdate_Load);
            this.gbRegisterUser.ResumeLayout(false);
            this.gbRegisterUser.PerformLayout();
            this.gbBaseInfo.ResumeLayout(false);
            this.gbBaseInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpOutDate;
        private System.Windows.Forms.ComboBox MaincboGrade;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbWomen;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox gbRegisterUser;
        private System.Windows.Forms.TextBox tbIsPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbStuNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBaseInfo;
        private System.Windows.Forms.TextBox tbPhope;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;


    }
}