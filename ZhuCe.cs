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
    public partial class ZhuCe : Form
    {
        public ZhuCe()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        public string name;
        //窗体加载事件
        private void ZhuCe_Load(object sender, EventArgs e)
        {
            //绑定登录身份
            BindType(name);
        }
        //绑定登录类型的方法
        public void BindType(string name)
        {
            
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format("select * from UserInfo where Name='{0}'", name);
            SqlCommand comm = new SqlCommand(sql,conn);
            SqlDataReader re = comm.ExecuteReader();
            while (re.Read())
            {
                this.tbName.Text=re["Name"].ToString();
                this.tbMima.Text=re["Passwork"].ToString();
            }
            re.Close();
            conn.Close();
        }
        //确认事件
        private void btnYes_Click(object sender, EventArgs e)
        {
           
            
            SqlConnection conn = new SqlConnection(strCon);
            if (this.tbPwd.Text.Equals(string.Empty))
            {
                MessageBox.Show("请输入新密码！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (this.tbIsPwd.Equals(string.Empty))
            {
                 MessageBox.Show("请确认用户密码！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            else
            {
                if (!this.tbPwd.Text.Equals(this.tbIsPwd.Text))
                {
                    MessageBox.Show("两次输入密码不正确", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    conn.Open();
                    string sql = string.Format(@"update UserInfo set Passwork='{0}' where Name='{1}'", this.tbPwd.Text,name);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int num = comm.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }           
            conn.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
