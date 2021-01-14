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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        UC_Supplier uc_Supplier;
        UC_Customer uc_Customer;
        UC_Workers uc_Workers;
        UC_Prescription uc_Prescription;
        UC_Login uc_Login;
        UC_Drugs uc_Drugs;
        //管理员权限主页面显示
        private void Admin_show() {
            btn_toDrugs.Visible = true;
            btn_toLogin.Visible = true;
            btn_toPrescription.Visible = true;
            btn_toSupplier.Visible = true;
            btn_toWorkers.Visible = true;
        }
        //管理员权限主界面隐藏
        private void Admin_hide() {
            btn_toDrugs.Visible = false;
            btn_toLogin.Visible = false;
            btn_toPrescription.Visible = false;
            btn_toSupplier.Visible = false;
            btn_toWorkers.Visible = false;
        }
        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_returnMain_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Remove(uc_Customer);
            groupBox1.Controls.Remove(uc_Drugs);
            groupBox1.Controls.Remove(uc_Login);
            groupBox1.Controls.Remove(uc_Prescription);
            groupBox1.Controls.Remove(uc_Supplier);
            groupBox1.Controls.Remove(uc_Workers);
            Admin_show();
        }

        private void btn_toSupplier_Click(object sender, EventArgs e)
        {
            Admin_hide();
            uc_Supplier = new UC_Supplier();
            uc_Supplier.Height = groupBox1.Height;
            uc_Supplier.Width = groupBox1.Width;
            groupBox1.Controls.Add(uc_Supplier);
        }

        private void btn_toDrugs_Click(object sender, EventArgs e)
        {
            Admin_hide();
            uc_Drugs = new UC_Drugs();
            uc_Drugs.Width = groupBox1.Width;
            uc_Drugs.Height = groupBox1.Height;
            groupBox1.Controls.Add(uc_Drugs);
        }


        private void btn_toWorkers_Click(object sender, EventArgs e)
        {
            Admin_hide();
            uc_Workers = new UC_Workers();
            groupBox1.Controls.Add(uc_Workers);
        }

        private void btn_toPrescription_Click(object sender, EventArgs e)
        {
            Admin_hide();
            uc_Prescription = new UC_Prescription();
            groupBox1.Controls.Add(uc_Prescription);
        }

        private void btn_toCustomer_Click(object sender, EventArgs e)
        {
            Admin_hide();
            uc_Customer = new UC_Customer();
            groupBox1.Controls.Add(uc_Customer);
        }

        private void btn_toLogin_Click(object sender, EventArgs e)
        {
            Admin_hide();
            uc_Login = new UC_Login();
            groupBox1.Controls.Add(uc_Login);
        }
    }
}
