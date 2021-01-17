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
        public string userName;
        public string userPower;
        public Frm_Login frm_Login;
        public Frm_Main()
        {
            InitializeComponent();
        }
        UC_Supplier uc_Supplier;
        UC_Workers uc_Workers;
        UC_Prescription uc_Prescription;
        UC_Drugs uc_Drugs;
        UC_AddPrescription uc_AddPrescription;
        //管理员权限主页面显示
        private void Control_show() {
            if (userPower == "医师")
            {
                btn_toAddPrescription.Visible = true;
                uiLabel5.Visible = true;
                return;
            }
            btn_toDrugs.Visible = true;
            btn_toPrescription.Visible = true;
            btn_toSupplier.Visible = true;
            btn_toWorkers.Visible = true;
            uiLabel1.Visible = true;
            uiLabel2.Visible = true;
            uiLabel3.Visible = true;
            uiLabel4.Visible = true;

        }
        //管理员权限主界面隐藏
        private void Control_hide() {
            if (userPower == "医师") { 
                btn_toAddPrescription.Visible = false;
                uiLabel5.Visible = false;
                return;
            }
            btn_toDrugs.Visible = false;
            btn_toPrescription.Visible = false;
            btn_toSupplier.Visible = false;
            btn_toWorkers.Visible = false;
            uiLabel1.Visible = false;
            uiLabel2.Visible = false;
            uiLabel3.Visible = false;
            uiLabel4.Visible = false;

        }
        private void Frm_Admin_Load(object sender, EventArgs e)
        {
            lbl_userName.Text = userName;
            lbl_userPower.Text = userPower;
            Control_show();
        }

        private void btn_returnMain_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Remove(uc_Drugs);
            groupBox1.Controls.Remove(uc_Prescription);
            groupBox1.Controls.Remove(uc_Supplier);
            groupBox1.Controls.Remove(uc_Workers);
            groupBox1.Controls.Remove(uc_AddPrescription);
            Control_show();
        }

        private void btn_toSupplier_Click(object sender, EventArgs e)
        {
            Control_hide();
            uc_Supplier = new UC_Supplier();
            uc_Supplier.Height = groupBox1.Height;
            uc_Supplier.Width = groupBox1.Width;
            groupBox1.Controls.Add(uc_Supplier);
        }

        private void btn_toDrugs_Click(object sender, EventArgs e)
        {
            Control_hide();
            uc_Drugs = new UC_Drugs();
            uc_Drugs.Width = groupBox1.Width;
            uc_Drugs.Height = groupBox1.Height;
            groupBox1.Controls.Add(uc_Drugs);
        }


        private void btn_toWorkers_Click(object sender, EventArgs e)
        {
            Control_hide();
            uc_Workers = new UC_Workers();
            uc_Workers.Width = groupBox1.Width;
            uc_Workers.Height = groupBox1.Height;
            groupBox1.Controls.Add(uc_Workers);
        }

        private void btn_toPrescription_Click(object sender, EventArgs e)
        {
            Control_hide();
            uc_Prescription = new UC_Prescription();
            uc_Prescription.Left = groupBox1.Width/2- uc_Prescription.Width/2;
            uc_Prescription.Top = groupBox1.Height/2-uc_Prescription.Height/2;
            groupBox1.Controls.Add(uc_Prescription);
        }

        private void btn_toAddPrescription_Click(object sender, EventArgs e)
        {
            Control_hide();
            uc_AddPrescription = new UC_AddPrescription();
            uc_AddPrescription.Width = groupBox1.Width;
            uc_AddPrescription.Height = groupBox1.Height;
            groupBox1.Controls.Add(uc_AddPrescription);
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            frm_Login.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
