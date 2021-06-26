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
    /// <summary>
    /// 填写请假申请页面
    /// </summary>
    public partial class StuApplication : Form
    {
        public StuApplication()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        public string  StuId;
        public string name;
        //提交申请事件
        private void btnSent_Click(object sender, EventArgs e)
        {

            string stuId = this.tbStuID.Text;//学号           
            string name = this.tbName.Text;    //姓名
            string classNo = this.tbClass.Text;//班级
            string reason = this.tbResion.Text;//请假原因
            DateTime appDate = Convert.ToDateTime(this.dtpAppdate.Text.ToString());//申请日期
            DateTime startDate = Convert.ToDateTime(this.dtpStart.Text.ToString());//开始时间
            DateTime endDate = Convert.ToDateTime(this.dtpEnd.Text.ToString());//结束时间           


            if (reason.Equals(string.Empty))
            {
                MessageBox.Show("请输入请假原因！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            else
            {
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string sql = string.Format(@"insert into ApplicationInfo(StudentId,ClassNo,Name,ApplicationDate,StartDate,OverDate,LeaveReason,ConfirmName,ConfirmMark)
                  values('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '','待审核')",stuId,classNo,name, appDate, startDate, endDate, reason);
                SqlCommand comm = new SqlCommand(sql, conn);
                int num = comm.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("提交失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }           
        }
        //关闭事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentManager M = new StudentManager();
            M.Show();
             
        }
        
        //窗体加载事件
        private void StuApplication_Load(object sender, EventArgs e)
        {            
            BindStudentInfo(name);
        }
        //绑定数据的方法
        public void BindStudentInfo(string name)
        {
            
            string stuId = this.tbStuID.Text;//学号           
            string classNo = this.tbClass.Text;//班级                      
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format("select * from UserInfo where Name='{0}'",name);
            SqlCommand comm = new SqlCommand(sql,conn);
            SqlDataReader re = comm.ExecuteReader();
            while (re.Read())
            {
                this.tbStuID.Text=re["StudentId"].ToString();
                this.tbClass.Text=re["ClassNo"].ToString();
                this.tbName.Text=re["Name"].ToString();
            }
            re.Close();
            conn.Close();
        }

    }
}
