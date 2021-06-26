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
    public partial class UpDateInfo : Form
    {
        /// <summary>
        /// 修改请假申请页面
        /// </summary>
        public UpDateInfo()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        public string name;
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //窗体加载事件
        private void UpDateInfo_Load(object sender, EventArgs e)
        {
            BindInfo(name);
        }
        
        //信息绑定方法
        public void BindInfo(string name)
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format("select * from ApplicationInfo where Name='{0}'", name);
            SqlCommand comm = new SqlCommand(sql,conn);
            SqlDataReader der = comm.ExecuteReader();
            while (der.Read())
            {               
                this.tbStuID.Text = der["StudentId"].ToString();
                this.tbClass.Text=der["ClassNo"].ToString();
                this.tbName.Text = der["Name"].ToString();
                this.dtpAppdate.Text = der["ApplicationDate"].ToString();
                this.dtpStart.Text = der["StartDate"].ToString();
                this.dtpEnd.Text = der["OverDate"].ToString();
                this.tbResion.Text = der["LeaveReason"].ToString();
                
            }
            der.Close();
            conn.Close();
        }
        //修改的点击事件
        private void btnSent_Click(object sender, EventArgs e)
        {
            string Id=this.tbStuID.Text;
            string name=this.tbName.Text;
            string classNo=this.tbClass.Text;
            DateTime ApplicationDate=Convert.ToDateTime(this.dtpAppdate.Text);
            DateTime StartDate=Convert.ToDateTime(this.dtpStart.Text);
            DateTime OverDate=Convert.ToDateTime(this.dtpEnd.Text);
            string reson=this.tbResion.Text;
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format(@"update ApplicationInfo set ApplicationDate='{0}',
             StartDate='{1}',OverDate='{2}',LeaveReason='{3}' where Name='{4}'",ApplicationDate,StartDate,OverDate,reson,name);
            SqlCommand comm = new SqlCommand(sql,conn);
            int num = comm.ExecuteNonQuery();
            if (num>0)
            {
                MessageBox.Show("修改成功","提示",MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败","提示",MessageBoxButtons.OK);
            }
            conn.Close();
        }
        
        

       
       

       
        

        

       
        

    }
}
