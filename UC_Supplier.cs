using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Drug_management_system
{
    public partial class UC_Supplier : UserControl
    {
        public UC_Supplier()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void findAll() {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select SID AS 供货商ID,SName AS 供货商名称,SDirector AS 负责人,SPhone AS 联系方式,SAddress AS 供货商地址 from Supplier";
            data.Datacon();
            ds = data.GetDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void UC_Supplier_Load(object sender, EventArgs e)
        {
            //开线程进行耗时操作
            Thread thread = new Thread(new ThreadStart(findAll));
            thread.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select SID AS 供货商ID,SName AS 供货商名称,SDirector AS 负责人,SPhone AS 联系方式,SAddress AS 供货商地址 from Supplier";
            data.Datacon();
            ds = data.GetDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            findAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_sName.Visible == true) {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    if (dataGridView1.Rows[i].Selected) {
                        lbl_sName.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        lbl_sDirector.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        lbl_sPhone.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        lbl_sAddress.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }
        }
    }
}
