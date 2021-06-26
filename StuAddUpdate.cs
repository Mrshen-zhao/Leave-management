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

namespace MySchool
{
    public partial class StuAddUpdate : Form
    {
        DBHelp dbh = new DBHelp();
        public string StuNo;
        public string stuId, oldPwd, newPwd, stuName, sex,grade, phone, address, email;
            
        public StuAddUpdate()
        {
            InitializeComponent();
        }        
        //窗体加载事件
        private void StuAddUpdate_Load(object sender, EventArgs e)
        {
            //绑定年级数据
            BindGradeDate();
            this.MaincboGrade.SelectedIndex = 0;            
        }
        #region 绑定年级数据方法
        public void BindGradeDate()
        {
            //查询年级的SQL语句
            string GradeSql = string.Format("select * from Grade");
            //将sql语句发送过去，并且返回得到一个年级数据集
            SqlDataReader reader = dbh.executeReader(GradeSql);
            while (reader.Read())
            {
                this.MaincboGrade.Items.Add(reader["GradeName"].ToString());
            }
            reader.Close();
        }
        #endregion
        #region 保存按钮事件-- 添加学生信息
        private void button1_Click(object sender, EventArgs e)
        {
            addStu();
        }                   
        #endregion
        //新增学生信息的方法
        public void addStu()
        {
            string sex = "";
            if (this.rbWomen.Checked == true)
            {
                sex = "女";
            }
            else if (this.rbMan.Checked == true)
            {
                sex = "男";
            }

            int grade = 0;
            if (grade.Equals("S1"))
            {
                grade = 1;
            }
            else if (grade.Equals("S2"))
            {
                grade = 2;
            }
            else
            {
                grade = 3;
            }
            string password = this.tbPwd.Text;
            if (!password.Equals(this.tbIsPwd.Text))
            {
                MessageBox.Show("两次输入的密码不匹配", "温馨提示", MessageBoxButtons.OK);
                return;
            }
            string name = this.tbName.Text;
            string oldPwd = this.tbName.Text;
            //添加的sql语句
            string addSql = string.Format(@"insert into Student values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}')",
            this.tbStuNo.Text, tbPwd.Text, tbName.Text, sex, grade, tbPhope.Text, tbAddress.Text, dtpOutDate.Value, tbEmail.Text);
            int result = dbh.executeNonQuery(addSql);
            if (result > 0)
            {
                DialogResult re = MessageBox.Show("新增学生信息成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (re == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("新增学生信息失败", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }       
        //修改学生信息的方法
        public void updateStu()
        { 

        }
    }
}
