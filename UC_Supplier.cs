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
        private string sid;//用于记录修改或删除字段的索引
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            findAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_sName.ReadOnly== true) {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    if (dataGridView1.Rows[i].Selected) {
                        sid=dataGridView1.Rows[i].Cells[0].Value.ToString();
                        txt_sName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        txt_sDirector.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        txt_sPhone.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        txt_sAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_sName.Text = "";
            txt_sDirector.Text = "";
            txt_sAddress.Text = "";
            txt_sPhone.Text = "";
            btn_revise.Enabled = false;
            btn_del.Enabled = false;
            if (btn_add.Text == "新建")
            {
                btn_add.Text = "取消新建";
                txt_sAddress.ReadOnly = false;
                txt_sDirector.ReadOnly = false;
                txt_sName.ReadOnly = false;
                txt_sPhone.ReadOnly = false;
                btn_save.Enabled = true;
            }
            else {
                btn_add.Text = "新建";
                txt_sAddress.ReadOnly = true;
                txt_sDirector.ReadOnly = true;
                txt_sName.ReadOnly = true;
                txt_sPhone.ReadOnly = true;
                btn_save.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_sName_TextChanged(object sender, EventArgs e)
        {
            if (txt_sName.ReadOnly == true) {
                btn_revise.Enabled = true;
                btn_del.Enabled = true;
            }
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            if (btn_revise.Text == "修改")
            {
                btn_revise.Text = "取消修改";
                btn_add.Enabled = false;
                txt_sAddress.ReadOnly = false;
                txt_sDirector.ReadOnly = false;
                txt_sName.ReadOnly = false;
                txt_sPhone.ReadOnly = false;
                btn_save.Enabled = true;
                btn_del.Enabled = false;
            }
            else {
                btn_revise.Text = "修改";
                btn_add.Enabled = true;
                txt_sName.Text = "";
                txt_sDirector.Text = "";
                txt_sAddress.Text = "";
                txt_sPhone.Text = "";
                txt_sAddress.ReadOnly = true;
                txt_sDirector.ReadOnly = true;
                txt_sName.ReadOnly = true;
                txt_sPhone.ReadOnly = true;
                btn_del.Enabled = false;
                btn_revise.Enabled = false;
                btn_save.Enabled = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == true)
            {
                //执行添加语句
                if (txt_sName.Text.ToString() == "" || txt_sDirector.Text.ToString() == "" || txt_sPhone.Text.ToString() == "" || txt_sAddress.Text.ToString() == "")
                {
                    MessageBox.Show("不能插入空数据！");
                }
                else
                {
                    string strsql;
                    DataAccess data = new DataAccess();
                    strsql = "insert into Supplier (SName,SDirector,SPhone,SAddress) values('" + txt_sName.Text.ToString() + "','" + txt_sDirector.Text.ToString() + "','" + txt_sPhone.Text.ToString() + "','" + txt_sAddress.Text.ToString() + "')";
                    data.Datacon();
                    if (data.SqlExec(strsql))
                    {
                        txt_log.Text += DateTime.Now.ToString() + " :添加数据成功\r\n";
                    }
                    else
                    {
                        txt_log.Text += DateTime.Now.ToString() + " :未能成功添加数据\r\n";
                    }
                    btn_add.Text = "新建";
                    btn_add.Enabled = true;
                    txt_sAddress.ReadOnly = true;
                    txt_sDirector.ReadOnly = true;
                    txt_sName.ReadOnly = true;
                    txt_sPhone.ReadOnly = true;
                    btn_del.Enabled = false;
                    btn_revise.Enabled = false;
                    txt_sName.Text = "";
                    txt_sDirector.Text = "";
                    txt_sAddress.Text = "";
                    txt_sPhone.Text = "";
                    btn_save.Enabled = false;
                }
            }
            else
            {
                //执行修改语句
                if (txt_sName.Text.ToString() == "" || txt_sDirector.Text.ToString() == "" || txt_sPhone.Text.ToString() == "" || txt_sAddress.Text.ToString() == "")
                {
                    MessageBox.Show("修改后数据不能为空！");
                }
                else {
                    string strsql;
                    DataAccess data = new DataAccess();
                    strsql = "update Supplier set SName='" +txt_sName.Text+ "',SDirector='"+txt_sDirector.Text+"',SPhone='"+txt_sPhone.Text+"',SAddress='"+txt_sAddress.Text+"' where sid="+sid;
                    data.Datacon();
                    if (data.SqlExec(strsql))
                    {
                        txt_log.Text += DateTime.Now.ToString() + " :修改数据成功\r\n";
                    }
                    else { txt_log.Text += DateTime.Now.ToString() + " :未成功修改数据\r\n"; }
                    btn_revise.Text = "修改";
                    btn_add.Enabled = true;
                    txt_sName.Text = "";
                    txt_sDirector.Text = "";
                    txt_sAddress.Text = "";
                    txt_sPhone.Text = "";
                    txt_sAddress.ReadOnly = true;
                    txt_sDirector.ReadOnly = true;
                    txt_sName.ReadOnly = true;
                    txt_sPhone.ReadOnly = true;
                    btn_del.Enabled = false;
                    btn_revise.Enabled = false;
                    btn_save.Enabled = false;
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("警告：您正在删除一条信息，这是不可逆的，是否继续?", "警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (dr.ToString() == "OK") {
                string strsql;
                DataAccess data = new DataAccess();
                strsql = "delete from Supplier where SID="+sid;
                data.Datacon();
                if (data.SqlExec(strsql)) {
                    txt_log.Text += DateTime.Now.ToString() + " :删除数据成功\r\n";
                }
                else { txt_log.Text += DateTime.Now.ToString() + " :未能成功删除数据\r\n"; }
            }
        }

        
    }
}
