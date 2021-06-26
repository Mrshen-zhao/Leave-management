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
    public partial class StudentManager : Form
    {
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integratsed Security=True";
        DataSet ds = new DataSet();
        
        public string names;//定义一个变量用来接收用户名进行传值
        
        public StudentManager()
        {
            InitializeComponent();
        }
       
        //填写请假申请
        private void btnInputInfo_Click_1(object sender, EventArgs e)
        {
            StuApplication app = new StuApplication();
            app.name = this.names;
            app.Show();
        }
        //请假申请现状事件
        private void btnStation_Click_1(object sender, EventArgs e)
        {
            AppStation S = new AppStation();
            S.Show();
        }
        
        //修改请假信息事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UpDateInfo up = new UpDateInfo();
            up.name = names;
            up.Show();
        }      
        //历史请假查询
        private void btnHistory_Click(object sender, EventArgs e)
        {
            SelectInfo se = new SelectInfo();
            se.Show();
        }
        //退出登录
        private void btnOut_Click(object sender, EventArgs e)
        {

            Login lo = new Login();
            lo.Show();
            this.Close();
        }
        //退出系统
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //个人基本信息
        private void button2_Click(object sender, EventArgs e)
        {
            MyInfo my = new MyInfo();
            my.name = names;
            my.Show();
        }
        //修改密码
        private void button3_Click(object sender, EventArgs e)
        {
            ZhuCe ce = new ZhuCe();
            ce.name = names;
            ce.Show();
        }

    }
}
