namespace 学生请假管理系统
{
    partial class PassWork
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.ApplicationNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbclass = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("华文新魏", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(265, -67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 57);
            this.label1.TabIndex = 16;
            this.label1.Text = "待处理请假申请";
            // 
            // ConfirmMark
            // 
            this.ConfirmMark.DataPropertyName = "ConfirmMark";
            this.ConfirmMark.FillWeight = 125.6106F;
            this.ConfirmMark.HeaderText = "审核标志";
            this.ConfirmMark.Name = "ConfirmMark";
            // 
            // dgvSelect
            // 
            this.dgvSelect.AllowUserToAddRows = false;
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelect.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationNum,
            this.StudentId,
            this.Name,
            this.ClassNo,
            this.ApplicationDate,
            this.StartDate,
            this.OverDate,
            this.LeaveReason,
            this.ConfirmName,
            this.ConfirmMark});
            this.dgvSelect.Location = new System.Drawing.Point(0, 92);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowTemplate.Height = 23;
            this.dgvSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelect.Size = new System.Drawing.Size(908, 408);
            this.dgvSelect.TabIndex = 20;
            // 
            // ApplicationNum
            // 
            this.ApplicationNum.DataPropertyName = "ApplicationNum";
            this.ApplicationNum.FillWeight = 72.36063F;
            this.ApplicationNum.HeaderText = "申请编号";
            this.ApplicationNum.Name = "ApplicationNum";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.FillWeight = 66.94492F;
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 73.71927F;
            this.Name.HeaderText = "姓名";
            this.Name.Name = "Name";
            // 
            // ClassNo
            // 
            this.ClassNo.DataPropertyName = "ClassNo";
            this.ClassNo.FillWeight = 80.08377F;
            this.ClassNo.HeaderText = "班级";
            this.ClassNo.Name = "ClassNo";
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.DataPropertyName = "ApplicationDate";
            this.ApplicationDate.FillWeight = 102.9384F;
            this.ApplicationDate.HeaderText = "申请日期";
            this.ApplicationDate.Name = "ApplicationDate";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 127.9906F;
            this.StartDate.HeaderText = "请假开始时间";
            this.StartDate.Name = "StartDate";
            // 
            // OverDate
            // 
            this.OverDate.DataPropertyName = "OverDate";
            this.OverDate.FillWeight = 132.3405F;
            this.OverDate.HeaderText = "请假结束时间";
            this.OverDate.Name = "OverDate";
            // 
            // LeaveReason
            // 
            this.LeaveReason.DataPropertyName = "LeaveReason";
            this.LeaveReason.FillWeight = 96.55923F;
            this.LeaveReason.HeaderText = "原因";
            this.LeaveReason.Name = "LeaveReason";
            // 
            // ConfirmName
            // 
            this.ConfirmName.DataPropertyName = "ConfirmName";
            this.ConfirmName.FillWeight = 121.4522F;
            this.ConfirmName.HeaderText = "审核人";
            this.ConfirmName.Name = "ConfirmName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文新魏", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 57);
            this.label2.TabIndex = 21;
            this.label2.Text = "已处理申请信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "班级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(297, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "姓名：";
            // 
            // tbclass
            // 
            this.tbclass.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbclass.Location = new System.Drawing.Point(156, 539);
            this.tbclass.Name = "tbclass";
            this.tbclass.Size = new System.Drawing.Size(100, 30);
            this.tbclass.TabIndex = 24;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(414, 539);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 30);
            this.tbName.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(555, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(671, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 27;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(787, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 28;
            this.button3.Text = "关闭";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PassWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(909, 607);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
             
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PassWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmMark;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbclass;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}