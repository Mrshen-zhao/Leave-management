using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace 学生请假管理系统
{
    public partial class AppManager : Form
    {
        public AppManager()
        {
            InitializeComponent();
        }
        
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        //窗体记载事件
        private void AppManager_Load(object sender, EventArgs e)
        {
            //绑定信息
            BindInfo();
        }
        //绑定信息的方法
        public void BindInfo()
        {            
            SqlConnection conn = new SqlConnection(strCon);
            string sql = string.Format("select * from ApplicationInfo");
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "ApplicationInfo");
            this.dgvInfo.DataSource = ds.Tables["ApplicationInfo"];
        }
        //节点选中事件
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.Level + "---" + treeView1.SelectedNode.Text);
            DataView V = new DataView(ds.Tables["ApplicationInfo"]);
            
            if(this.treeView1.SelectedNode.Level==1)
            {
                if(this.treeView1.SelectedNode.Parent.Text.Equals("班级"))
                {
                    string clasisNo = treeView1.SelectedNode.Text;
                    V.RowFilter = string.Format("ClassNo='{0}'", clasisNo);
                }               
                else if (this.treeView1.SelectedNode.Parent.Text.Equals("审核标志"))
                {
                    string shenhe = treeView1.SelectedNode.Text;
                    V.RowFilter = string.Format("ConfirmMark='{0}'", shenhe);
                }
            }
           
            dgvInfo.DataSource = V;
        }
        
    }
}
         