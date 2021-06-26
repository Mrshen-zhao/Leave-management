namespace 学生请假管理系统
{
    partial class AppManager
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("T63");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("T64");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("T65");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("T66");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("T67");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("班级", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("批准");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("不批准");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("待审核");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("审核标志", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppManager));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvInfo = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "申请信息管理";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 92);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvInfo);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 519);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点6";
            treeNode1.Tag = "3";
            treeNode1.Text = "T63";
            treeNode2.Name = "节点7";
            treeNode2.Tag = "4";
            treeNode2.Text = "T64";
            treeNode3.Name = "节点9";
            treeNode3.Tag = "5";
            treeNode3.Text = "T65";
            treeNode4.Name = "节点2";
            treeNode4.Text = "T66";
            treeNode5.Name = "节点3";
            treeNode5.Text = "T67";
            treeNode6.BackColor = System.Drawing.Color.Black;
            treeNode6.ForeColor = System.Drawing.Color.Snow;
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "tvClass";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Tag = "all1";
            treeNode6.Text = "班级";
            treeNode7.Name = "节点13";
            treeNode7.Tag = "1";
            treeNode7.Text = "批准";
            treeNode8.Name = "节点14";
            treeNode8.Tag = "2";
            treeNode8.Text = "不批准";
            treeNode9.Name = "节点0";
            treeNode9.Tag = "3";
            treeNode9.Text = "待审核";
            treeNode10.BackColor = System.Drawing.Color.Black;
            treeNode10.ForeColor = System.Drawing.Color.Snow;
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "tvCommark";
            treeNode10.SelectedImageIndex = 2;
            treeNode10.Tag = "all3";
            treeNode10.Text = "审核标志";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(117, 519);
            this.treeView1.StateImageList = this.imageList1;
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "QQ截图20180308145608.png");
            this.imageList1.Images.SetKeyName(1, "QQ截图20180308145724.png");
            this.imageList1.Images.SetKeyName(2, "QQ截图20180308150151.png");
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowTemplate.Height = 23;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(926, 519);
            this.dgvInfo.TabIndex = 0;
            // 
            // ApplicationNum
            // 
            this.ApplicationNum.DataPropertyName = "ApplicationNum";
            this.ApplicationNum.HeaderText = "申请编号";
            this.ApplicationNum.Name = "ApplicationNum";
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.FillWeight = 76.70615F;
            this.StudentId.HeaderText = "学生编号";
            this.StudentId.Name = "StudentId";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 76.70615F;
            this.Name.HeaderText = "姓名";
            this.Name.Name = "Name";
            // 
            // ClassNo
            // 
            this.ClassNo.DataPropertyName = "ClassNo";
            this.ClassNo.FillWeight = 76.70615F;
            this.ClassNo.HeaderText = "班级";
            this.ClassNo.Name = "ClassNo";
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.DataPropertyName = "ApplicationDate";
            this.ApplicationDate.FillWeight = 76.70615F;
            this.ApplicationDate.HeaderText = "申请日期";
            this.ApplicationDate.Name = "ApplicationDate";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.FillWeight = 76.70615F;
            this.StartDate.HeaderText = "开始时间";
            this.StartDate.Name = "StartDate";
            // 
            // OverDate
            // 
            this.OverDate.DataPropertyName = "OverDate";
            this.OverDate.FillWeight = 76.70615F;
            this.OverDate.HeaderText = "结束时间";
            this.OverDate.Name = "OverDate";
            // 
            // LeaveReason
            // 
            this.LeaveReason.DataPropertyName = "LeaveReason";
            this.LeaveReason.FillWeight = 76.70615F;
            this.LeaveReason.HeaderText = "请假原因";
            this.LeaveReason.Name = "LeaveReason";
            // 
            // ConfirmName
            // 
            this.ConfirmName.DataPropertyName = "ConfirmName";
            this.ConfirmName.FillWeight = 76.70615F;
            this.ConfirmName.HeaderText = "审核人";
            this.ConfirmName.Name = "ConfirmName";
            // 
            // ConfirmMark
            // 
            this.ConfirmMark.DataPropertyName = "ConfirmMark";
            this.ConfirmMark.FillWeight = 76.70615F;
            this.ConfirmMark.HeaderText = "审核标志";
            this.ConfirmMark.Name = "ConfirmMark";
            // 
            // AppManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1039, 560);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AppManager_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.ImageList imageList1;
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