namespace 学生请假管理系统
{
    partial class SelectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.ConfirmMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("华文新魏", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(199, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "请假历史记录查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(336, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(46, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "班级 ：";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbName.Location = new System.Drawing.Point(445, 141);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(127, 30);
            this.tbName.TabIndex = 3;
            // 
            // tbClass
            // 
            this.tbClass.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbClass.Location = new System.Drawing.Point(171, 144);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(130, 30);
            this.tbClass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(614, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSelect
            // 
            this.dgvSelect.AllowUserToAddRows = false;
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelect.BackgroundColor = System.Drawing.Color.Silver;
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
            this.dgvSelect.Location = new System.Drawing.Point(-3, 216);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.ReadOnly = true;
            this.dgvSelect.RowTemplate.Height = 23;
            this.dgvSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelect.Size = new System.Drawing.Size(898, 389);
            this.dgvSelect.TabIndex = 6;
            this.dgvSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelect_CellContentClick);
            // 
            // ApplicationNum
            // 
            this.ApplicationNum.DataPropertyName = "ApplicationNum";
            this.ApplicationNum.FillWeight = 72.36063F;
            this.ApplicationNum.HeaderText = "申请编号";
            this.ApplicationNum.Name = "ApplicationNum";
            this.ApplicationNum.ReadOnly = true;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.FillWeight = 66.94492F;
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 73.71927F;
            this.Name.HeaderText = "姓名";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // ClassNo
            // 
            this.ClassNo.DataPropertyName = "ClassNo";
            this.ClassNo.FillWeight = 80.08377F;
            this.ClassNo.HeaderText = "班级";
            this.ClassNo.Name = "ClassNo";
            this.ClassNo.ReadOnly = true;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.DataPropertyName = "ApplicationDate";
            this.ApplicationDate.FillWeight = 102.9384F;
            this.ApplicationDate.HeaderText = "申请日期";
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 127.9906F;
            this.StartDate.HeaderText = "请假开始时间";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // OverDate
            // 
            this.OverDate.DataPropertyName = "OverDate";
            this.OverDate.FillWeight = 132.3405F;
            this.OverDate.HeaderText = "请假结束时间";
            this.OverDate.Name = "OverDate";
            this.OverDate.ReadOnly = true;
            // 
            // LeaveReason
            // 
            this.LeaveReason.DataPropertyName = "LeaveReason";
            this.LeaveReason.FillWeight = 96.55923F;
            this.LeaveReason.HeaderText = "原因";
            this.LeaveReason.Name = "LeaveReason";
            this.LeaveReason.ReadOnly = true;
            // 
            // ConfirmName
            // 
            this.ConfirmName.DataPropertyName = "ConfirmName";
            this.ConfirmName.FillWeight = 121.4522F;
            this.ConfirmName.HeaderText = "审核人";
            this.ConfirmName.Name = "ConfirmName";
            this.ConfirmName.ReadOnly = true;
            // 
            // ConfirmMark
            // 
            this.ConfirmMark.DataPropertyName = "ConfirmMark";
            this.ConfirmMark.FillWeight = 125.6106F;
            this.ConfirmMark.HeaderText = "审核标志";
            this.ConfirmMark.Name = "ConfirmMark";
            this.ConfirmMark.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(739, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SelectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmMark;
        private System.Windows.Forms.Button button2;
    }
}