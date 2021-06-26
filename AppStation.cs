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
    public partial class AppStation : Form
    {
        public AppStation()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
       
        //窗体加载事件
        private void AppStation_Load(object sender, EventArgs e)
        {
            BindInfo();
        }
        //信息绑定方法
        public void BindInfo()
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format("select * from ApplicationInfo");
            SqlCommand comm = new SqlCommand(sql,conn);
            SqlDataReader der = comm.ExecuteReader();
            while (der.Read())
            {
                this.lbAppId.Text=der["ApplicationNum"].ToString();
                this.lbStuId.Text = der["StudentId"].ToString();
                this.lbClassNo.Text=der["ClassNo"].ToString();
                this.lbName.Text = der["Name"].ToString();
                this.lbAppDate.Text = der["ApplicationDate"].ToString();
                this.lbStartDate.Text = der["StartDate"].ToString();
                this.lbOverDate.Text = der["OverDate"].ToString();
                this.lbResion.Text = der["LeaveReason"].ToString();
                this.lbIsName.Text = der["ConfirmName"].ToString();
                this.lbComark.Text = der["ConfirmMark"].ToString();
            }
            der.Close();
            conn.Close();
        }
        
        //关闭
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //提醒审核
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您的提醒审核发送成功","信息提醒",MessageBoxButtons.OK);
        }
    }
}
