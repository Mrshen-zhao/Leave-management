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
    public partial class SelectInfo : Form
    {
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        public SelectInfo()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void SelectInfo_Load(object sender, EventArgs e)
        {
            //绑定请假信息
            BindAppInfo();
        }
        //绑定请假信息的方法
        public void BindAppInfo()
        {
            if (ds.Tables["ApplicationInfo"]!=null)
            {
                ds.Tables["ApplicationInfo"].Clear();
            }
            SqlConnection conn = new SqlConnection(strCon);
            string sql = string.Format(@"select ApplicationNum,StudentId,Name,ClassNo,ApplicationDate,StartDate,OverDate,
             LeaveReason,ConfirmName,ConfirmMark from ApplicationInfo");
            string name = this.tbName.Text;
            string classNum = this.tbClass.Text;
            sql += string.Format(" where Name like '%{0}%' and ClassNo like '%{1}%'",name,classNum);
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "ApplicationInfo");
            this.dgvSelect.DataSource = ds.Tables["ApplicationInfo"];
        }
        
        //查询的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            BindAppInfo();
        }
        //关闭
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
