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
    public partial class MyInfo : Form
    {
        public MyInfo()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        public string name;
        private void label12_Click(object sender, EventArgs e)
        {

        }
        //窗体加载事件
        private void MyInfo_Load(object sender, EventArgs e)
        {
            //绑定信息
            BindInfo(name);
        }
        public void BindInfo(string name)
        {
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format("select StudentId,ClassNo,Name,Sex,Stage,Phone,Dormitory,SchoolName from UserInfo where Name='{0}'",name);
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader der = comm.ExecuteReader();
            while (der.Read())
            {
                this.lbSutId.Text = der["StudentId"].ToString();
                this.lbClass.Text = der["ClassNo"].ToString();
                this.lbName.Text = der["Name"].ToString();
                this.lbSex.Text = der["Sex"].ToString();
                this.lbStage.Text = der["Stage"].ToString();
                this.lbPhone.Text = der["Phone"].ToString();
                this.lbSushe.Text = der["Dormitory"].ToString();
                this.lbSchool.Text = der["SchoolName"].ToString();
                
            }
            der.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSex_Click(object sender, EventArgs e)
        {

        }
    }
}
