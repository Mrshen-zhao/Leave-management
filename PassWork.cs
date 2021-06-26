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
    public partial class PassWork : Form
    {
        public PassWork()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        //窗体加载事件
        private void PassWork_Load(object sender, EventArgs e)
        {
            //数据绑定
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
            string sql = string.Format("select * from ApplicationInfo where ConfirmMark <> '待审核'");            
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "ApplicationInfo");
            this.dgvSelect.DataSource = ds.Tables["ApplicationInfo"];

        }
        //查找事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (ds.Tables["ApplicationInfo"]!=null)
            {
                ds.Tables["ApplicationInfo"].Clear();
            }
            string classNo = this.tbclass.Text;
            string name = this.tbName.Text;
            SqlConnection conn = new SqlConnection(strCon);
            string sql = string.Format("select * from ApplicationInfo where ConfirmMark <> '待审核' and ClassNo like '%{0}%' and Name like '%{1}%'",classNo,name);
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds, "ApplicationInfo");
            this.dgvSelect.DataSource = ds.Tables["ApplicationInfo"];
        }
        //删除请假信息
        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.dgvSelect.SelectedRows[0].Cells["ApplicationNum"].Value.ToString());
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            
            
                DialogResult result= MessageBox.Show("确定要删除吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    string sql = string.Format("delete from ApplicationInfo where ApplicationNum={0}", num);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int count = comm.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindInfo();
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                                     
            }
            
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
