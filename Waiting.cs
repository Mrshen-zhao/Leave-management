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

namespace 学生请假管理系统
{
    public partial class Waiting : Form
    {
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
       
        public Waiting()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void Waiting_Load(object sender, EventArgs e)
        {
            //绑定数据
            BindInfo();
        }
        //绑定数据的方法
        public void BindInfo()
        {
            if (ds.Tables["ApplicationInfo"]!=null)
            {
                ds.Tables["ApplicationInfo"].Clear();
            }
            SqlConnection conn = new SqlConnection(strCon);
            string sql = string.Format("select * from ApplicationInfo where ConfirmMark='待审核'");
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "ApplicationInfo");
            this.dgvSelect.DataSource = ds.Tables["ApplicationInfo"];
        }
        //查询的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (ds.Tables["ApplicationInfo"] != null)
            {
                ds.Tables["ApplicationInfo"].Clear();
            }
            SqlConnection conn = new SqlConnection(strCon);
            string classNo = this.tbClass.Text;//班级取值

            string sql = string.Format("select * from ApplicationInfo where ConfirmMark='待审核'and ClassNo like '%{0}%'", classNo);
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "ApplicationInfo");
            this.dgvSelect.DataSource = ds.Tables["ApplicationInfo"];
        }

        
        //关闭
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //审核
        private void 审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(this.dgvSelect.SelectedRows[0].Cells["ApplicationNum"].Value.ToString());
            ShenHe H = new ShenHe();
            H.Id = ID;
            H.Show();
           
        }

        private void tbClass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
