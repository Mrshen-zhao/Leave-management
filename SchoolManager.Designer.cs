namespace 学生请假管理系统
{
    partial class SchoolManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolManager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInputInfo = new System.Windows.Forms.Button();
            this.btnStation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(324, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "退出系统";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文行楷", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 101);
            this.label1.TabIndex = 25;
            this.label1.Text = "学生请假系统";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.BurlyWood;
            this.btnHistory.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHistory.ForeColor = System.Drawing.Color.Maroon;
            this.btnHistory.Location = new System.Drawing.Point(724, 359);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(247, 125);
            this.btnHistory.TabIndex = 29;
            this.btnHistory.Text = "退出登录";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLogin.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogin.Location = new System.Drawing.Point(492, 359);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(237, 125);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "已处理申请";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnInputInfo
            // 
            this.btnInputInfo.BackColor = System.Drawing.Color.BurlyWood;
            this.btnInputInfo.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInputInfo.ForeColor = System.Drawing.Color.Maroon;
            this.btnInputInfo.Location = new System.Drawing.Point(724, 234);
            this.btnInputInfo.Name = "btnInputInfo";
            this.btnInputInfo.Size = new System.Drawing.Size(247, 131);
            this.btnInputInfo.TabIndex = 27;
            this.btnInputInfo.Text = "请假申请管理";
            this.btnInputInfo.UseVisualStyleBackColor = false;
            this.btnInputInfo.Click += new System.EventHandler(this.btnInputInfo_Click);
            // 
            // btnStation
            // 
            this.btnStation.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStation.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStation.ForeColor = System.Drawing.Color.Maroon;
            this.btnStation.Location = new System.Drawing.Point(492, 234);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(237, 131);
            this.btnStation.TabIndex = 28;
            this.btnStation.Text = "待处理申请";
            this.btnStation.UseVisualStyleBackColor = false;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(561, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 48);
            this.label2.TabIndex = 32;
            this.label2.Text = "班主任登录页面";
            // 
            // SchoolManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.btnInputInfo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SchoolManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SchoolManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInputInfo;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.Label label2;

    }
}