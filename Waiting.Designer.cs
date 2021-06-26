namespace 学生请假管理系统
{
    partial class Waiting
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
            this.button2 = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(859, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dgvSelect.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSelect.Location = new System.Drawing.Point(0, 202);
            this.dgvSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowTemplate.Height = 23;
            this.dgvSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelect.Size = new System.Drawing.Size(1201, 542);
            this.dgvSelect.TabIndex = 14;
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
            // ConfirmMark
            // 
            this.ConfirmMark.DataPropertyName = "ConfirmMark";
            this.ConfirmMark.FillWeight = 125.6106F;
            this.ConfirmMark.HeaderText = "审核标志";
            this.ConfirmMark.Name = "ConfirmMark";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.审核ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 审核ToolStripMenuItem
            // 
            this.审核ToolStripMenuItem.Name = "审核ToolStripMenuItem";
            this.审核ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.审核ToolStripMenuItem.Text = "审核";
            this.审核ToolStripMenuItem.Click += new System.EventHandler(this.审核ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(640, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbClass
            // 
            this.tbClass.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbClass.Location = new System.Drawing.Point(372, 145);
            this.tbClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(151, 36);
            this.tbClass.TabIndex = 12;
            this.tbClass.TextChanged += new System.EventHandler(this.tbClass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(212, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "班级 ：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("华文新魏", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "待处理请假申请";
            // 
            // Waiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1205, 724);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //this.Name = "Waiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Waiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 审核ToolStripMenuItem;
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

    }
}