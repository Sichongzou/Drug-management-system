using Drug_management_system.bean;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drug_management_system
{
    public partial class UC_AddPrescription : UserControl
    {
        public string wid = "1";
        //使用ArrayList存储药品信息，避免过多访问数据库
        ArrayList drugs = new ArrayList();
        public UC_AddPrescription()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void LoadAll()
        {
            //重置DrugsList
            drugs.Clear();

            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select DID,Dname,DExplain,Dcost,DPrice,Dstock from Drugs";
            data.Datacon();
            ds = data.GetDataset(strsql);
            cbo_dName.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //实例化
                Drug drug = new Drug();
                drug.Did = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                drug.DName = ds.Tables[0].Rows[i][1].ToString();
                drug.DExplain = ds.Tables[0].Rows[i][2].ToString();
                drug.DCost = Convert.ToSingle(ds.Tables[0].Rows[i][3].ToString());
                drug.DPrice = Convert.ToSingle(ds.Tables[0].Rows[i][4].ToString());
                drug.DStock = Convert.ToInt32(ds.Tables[0].Rows[i][5].ToString());
                //放入List
                drugs.Add(drug);
                //初始化cbo_dName
                cbo_dName.Items.Add(((Drug)drugs[i]).DName);
                
            }
        }
        private void UC_AddPrescription_Load(object sender, EventArgs e)
        {
            //开线程进行耗时操作
            Thread thread = new Thread(new ThreadStart(LoadAll));
            thread.Start();
        }

        private void cbo_dName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < drugs.Count; i++) {
                Drug drug = (Drug)drugs[i];
                if (drug.DName == cbo_dName.Text) {
                    lbl_dPrice.Text = "单价:  " + drug.DPrice;
                    lbl_dExplain.Text = "用药说明:  " + drug.DExplain;
                    lbl_dStork.Text = "库存数量:  " + drug.DStock;
                    break;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_dNumber.Text == "") {
                MessageBox.Show("输入不合法。", "错误");
                return;
            }
            if (Convert.ToInt32(txt_dNumber.Text) == 0) {
                MessageBox.Show("输入不合法。", "错误");
                return;
            }
            for (int i = 0; i < drugs.Count; i++)
            {
                Drug drug = (Drug)drugs[i];
                if (drug.DName == cbo_dName.Text)
                {
                    //判断库存是否足够
                    if (drug.DStock < Convert.ToInt32(txt_dNumber.Text))
                    {
                        MessageBox.Show("库存不足！");
                    }
                    else {
                        //判断dataGridView1是否存在重复药物
                        int j;
                        for (j = 0; j < dataGridView1.Rows.Count; j++) {
                            //已存在药物
                            if (dataGridView1.Rows[j].Cells[1].Value.ToString() == drug.DName) {
                                //优先判断总库存是否足够
                                if (Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value) + Convert.ToInt32(txt_dNumber.Text.ToString()) > drug.DStock)
                                {
                                    MessageBox.Show("库存不足！请核实库存数量");
                                    return;
                                }
                                //添加数量
                                dataGridView1.Rows[j].Cells[3].Value = (Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value) + Convert.ToInt32(txt_dNumber.Text.ToString())).ToString();
                                //重新计算价格 保留两位小数避免误差
                                dataGridView1.Rows[j].Cells[5].Value = Math.Round(Convert.ToInt32(dataGridView1.Rows[j].Cells[3].Value) * Convert.ToSingle(dataGridView1.Rows[j].Cells[4].Value),2);
                                break;
                            }
                        }
                        //未存在药物
                        if (j == dataGridView1.Rows.Count) {
                            //添加新行
                            DataGridViewRow row = new DataGridViewRow();
                            DataGridViewTextBoxCell dt1 = new DataGridViewTextBoxCell();
                            dt1.Value = drug.Did;
                            row.Cells.Add(dt1);
                            DataGridViewTextBoxCell dt2 = new DataGridViewTextBoxCell();
                            dt2.Value = drug.DName;
                            row.Cells.Add(dt2);
                            DataGridViewTextBoxCell dt3 = new DataGridViewTextBoxCell();
                            dt3.Value = drug.DExplain;
                            row.Cells.Add(dt3);
                            DataGridViewTextBoxCell dt4 = new DataGridViewTextBoxCell();
                            dt4.Value = txt_dNumber.Text;
                            row.Cells.Add(dt4);
                            DataGridViewTextBoxCell dt5 = new DataGridViewTextBoxCell();
                            dt5.Value = drug.DPrice;
                            row.Cells.Add(dt5);
                            DataGridViewTextBoxCell dt6 = new DataGridViewTextBoxCell();
                            dt6.Value = Math.Round(drug.DPrice * Convert.ToInt32(txt_dNumber.Text),2);
                            row.Cells.Add(dt6);
                            dataGridView1.Rows.Add(row);
                        }
                    }
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            if (txt_cName.Text != "")
            {
                strsql = "select CID AS 患者编号,CName AS 患者姓名,CAge AS 年龄,CSex AS 患者性别,CPhone AS 联系方式 from Customer where CName='" + txt_cName.Text + "'";
            }
            else {
                strsql = "select CID AS 患者编号,CName AS 患者姓名,CAge AS 年龄,CSex AS 患者性别,CPhone AS 联系方式 from Customer";
            }
            data.Datacon();
            ds = data.GetDataset(strsql);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected)
                {
                    txt_cName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    txt_cAge.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                    cbo_cSex.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
                    txt_cPhone.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Single money=0;
            string message="生成处方如下：\r\n";
            //前置条件
            if (txt_cName.Text == "" || txt_cPhone.Text == "" || txt_cAge.Text == "" || cbo_cSex.Text == "")
            {
                MessageBox.Show("请完善患者基本信息！", "Error");
                return;
            }
            if (dataGridView1.Rows.Count == 0) {
                MessageBox.Show("请添加药品！", "Error");
                return;
            }
            //判断客户是否存在
            string cid,pid;
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select CID from Customer Where CName='"+txt_cName.Text+"' And CAge="+txt_cAge.Text+" And CSex='"+cbo_cSex.Text+"' And CPhone='"+txt_cPhone.Text+"'";
            data.Datacon();
            ds = data.GetDataset(strsql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                //未查询到客户信息 开始新建客户chuang
                //创建新数据
                strsql ="insert into  Customer (CName,CAge,CSex,CPhone) Values('" + txt_cName.Text + "'," + txt_cAge.Text + ",'" + cbo_cSex.Text + "','" + txt_cPhone.Text + "')";
                data.SqlExec(strsql);
                //查询新创建数据的CID
                strsql = "select CID from Customer Where CName='" + txt_cName.Text + "' And CAge=" + txt_cAge.Text + " And CSex='" + cbo_cSex.Text + "' And CPhone='" + txt_cPhone.Text + "'";
                ds = data.GetDataset(strsql);
                cid = ds.Tables[0].Rows[0][0].ToString();
            }
            else {
                //查询到客户信息取出CID
                cid = ds.Tables[0].Rows[0][0].ToString();
            }
            message += "客户姓名：" + txt_cName.Text + ",性别：" + cbo_cSex.Text + "\r\n" + "年龄：" + txt_cAge.Text + ",联系方式：" + txt_cPhone.Text + "\r\n\r\n";
            //构造当前日期
            string date;
            date = "" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "";
            //生成处方字段
            strsql = "insert into  Prescription (PDate,WID,CID,PRemarks) Values('" + date + "'," + wid + "," + cid + ",'" + txt_PRemarks.Text + "')";
            data.SqlExec(strsql);
            //返回新生成的处方ID
            strsql = "Select PID From Prescription Where PDate=#" + date + "# and WID=" + wid + " and CID=" + cid + " and PRemarks='" + txt_PRemarks.Text + "'";
            ds = data.GetDataset(strsql);
            pid = ds.Tables[0].Rows[0][0].ToString();
            //生成处方内容字段 并从库存扣除药品数量
            for (int i = 0; i < dataGridView1.Rows.Count; i++) { 
                strsql= "insert into  Prescription_content (DID,PcNumber,PID) Values("+ dataGridView1.Rows[i].Cells[0].Value.ToString() + "," + dataGridView1.Rows[i].Cells[3].Value.ToString() + "," + pid+")";
                data.SqlExec(strsql);
                strsql = "Update  Drugs Set  DStock= Dstock-" + dataGridView1.Rows[i].Cells[3].Value.ToString() +" Where DID="+dataGridView1.Rows[i].Cells[0].Value.ToString();
                data.SqlExec(strsql);
                message+= dataGridView1.Rows[i].Cells[1].Value.ToString()+" X "+dataGridView1.Rows[i].Cells[3].Value.ToString()+"\r\n";
                money += Convert.ToSingle(dataGridView1.Rows[i].Cells[5].Value.ToString());
             }
            money = (Single)Math.Round(money, 2);
            message += "\r\n总金额：" + money;
            //刷新整个页面
            LoadAll();
            lbl_dPrice.Text = "单价:  " ;
            lbl_dExplain.Text = "用药说明:  ";
            lbl_dStork.Text = "库存数量:  ";
            txt_cName.Text = "";
            txt_cAge.Text = "";
            cbo_cSex.Text = "";
            txt_cPhone.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView2.DataSource=null;
            txt_dNumber.Text = "";
            txt_PRemarks.Text = "";
            MessageBox.Show(message);
        }
    }
}
