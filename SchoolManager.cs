using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生请假管理系统
{
    public partial class SchoolManager : Form
    {
        public SchoolManager()
        {
            InitializeComponent();
        }

        private void SchoolManager_Load(object sender, EventArgs e)
        {

        }
        //退出系统
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //待处理申请
        private void btnStation_Click(object sender, EventArgs e)
        {
            Waiting W = new Waiting();
            W.Show();
        }
        //请假申请管理
        private void btnInputInfo_Click(object sender, EventArgs e)
        {
            AppManager M = new AppManager();
            M.Show();
        }
        //已处理申请
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PassWork W = new PassWork();
            W.Show();
        }
        //退出登录
        private void btnHistory_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
        }
    }
}
