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
    public partial class ShenHe : Form
    {
        public ShenHe()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=.;Initial Catalog=学生请假管理系统;Integrated Security=True";
        DataSet ds = new DataSet();
        public int Id;//申请编号
        public Waiting W=new Waiting();
        //窗体加载事件
        private void ShenHe_Load(object sender, EventArgs e)
        {
            //把选中的行的数据赋到窗体上
            BindInfo(Id);
            //绑定审核标志
            BindCommark();
        }
        //赋值的方法
        public void BindInfo(int Id)
        {
            
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format("select * from ApplicationInfo where ApplicationNum={0}",Id);
            SqlCommand comm = new SqlCommand(sql,conn);
            SqlDataReader re = comm.ExecuteReader();
            while (re.Read())
            {
                this.lbAppId.Text = re["ApplicationNum"].ToString();
                this.lbStuId.Text = re["StudentId"].ToString();
                this.lbName.Text = re["Name"].ToString();
                this.lbClassNo.Text = re["ClassNo"].ToString();
                this.lbAppDate.Text = re["ApplicationDate"].ToString();
                this.lbStartDate.Text = re["StartDate"].ToString();
                this.lbOverDate.Text = re["OverDate"].ToString();
                this.lbResion.Text = re["LeaveReason"].ToString();
            }
            re.Close();
            conn.Close();
        }
        //绑定审核标志
        public void BindCommark()
        {
            SqlConnection conn = new SqlConnection(strCon);
            string sql = string.Format("select * from Commarks");
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds, "Commarks");
            this.cboComark.DataSource = ds.Tables["Commarks"];
            this.cboComark.DisplayMember = "Commark";
        }
        //审核确定事件
        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            string sql = string.Format(@"update ApplicationInfo set ConfirmName='{0}',ConfirmMark='{1}' where ApplicationNum={2}",this.tbComName.Text,this.cboComark.Text,Id);
            SqlCommand comm = new SqlCommand(sql,conn);
            int num = comm.ExecuteNonQuery();
            if (num>0)
            {
                MessageBox.Show("审核成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                W.BindInfo();
                this.Close();
            }
            else
            {
                MessageBox.Show("审核失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        //关闭
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
