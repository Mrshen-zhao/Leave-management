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
    public partial class Login : Form
    {
     
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        

        public Login()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void Login_Load(object sender, EventArgs e)
        {
            //绑定登录类型
            BindLoginType();
        }
        //绑定登录类型方法
        public void BindLoginType()
        {
            string sql = string.Format("select * from LoginType");
            SqlConnection conn = new SqlConnection(strCon);
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "LoginType");
            this.cboType.DataSource = ds.Tables["LoginType"];
            this.cboType.ValueMember = "TypeId";//隐藏
            this.cboType.DisplayMember = "LoginType";//显示
        }
        //登录事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string type = this.cboType.Text;
            int TypeNum = 0;
            if (type.Equals("学生"))
            {
                TypeNum = 1;
            }
            else if (type.Equals("班主任"))
            {
                TypeNum = 2;
            }
            
            string name = this.tbUserName.Text;      
            string password=this.tbUserPwd.Text;
            if (name == null || name == "" || name.Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (password == null || password == "" || password.Equals(string.Empty))
            {
                MessageBox.Show("请输入用户密码！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conn = new SqlConnection(strCon);
                conn.Open();
                string sql = string.Format(@"select COUNT(*) from UserInfo where Name='{0}' and
                  Passwork='{1}' and Typeid={2}", name, password, TypeNum);
                SqlCommand comm = new SqlCommand(sql,conn);
                int num =(int) comm.ExecuteScalar();
                if (num > 0)
                {

                    MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (this.cboType.SelectedIndex==0)
                    {
                        StudentManager stu = new StudentManager();
                        stu.names = name;//把名字传到主窗体上
                        stu.Show();                                                
                        this.Hide(); 

                    }
                    else if (this.cboType.SelectedIndex==1)
                    {
                        SchoolManager M = new SchoolManager();
                        M.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("登录失败", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        
    }
}
