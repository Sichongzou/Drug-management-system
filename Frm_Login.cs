using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Drug_management_system
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //前置判断
            if (txt_userName.Text == "" || txt_userPassword.Text == "")
            {
                MessageBox.Show("输入不合法！请重新输入！");
                return;
            }
            //查询账户名与密码
            string strsql;
            DataAccess data = new DataAccess();
            data.Datacon();
            DataSet ds;
            strsql = "select UserPower From Login Where UserName='" + txt_userName.Text + "' and UserPassword='" + txt_userPassword.Text + "'";
            ds = data.GetDataset(strsql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("用户名或密码错误，请核实用户名与密码！");
                return;
            }
            Frm_Main frm_Main = new Frm_Main();
            frm_Main.userName = txt_userName.Text;
            if (ds.Tables[0].Rows[0][0].ToString() == "管理员")
            {
                frm_Main.userPower = "管理员";
            }
            else
            {
                frm_Main.userPower = "医师";
            }
            frm_Main.frm_Login = this;
            frm_Main.Show();
            txt_userName.Text = "";
            txt_userPassword.Text = "";
            this.Hide();
        }
    }
}
