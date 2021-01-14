using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Drug_management_system.bean;

namespace Drug_management_system
{
    public partial class UC_Drugs : UserControl
    {
        TreeNode treeNodeFather;
        Drugs drugs=null;
        public UC_Drugs()
        {
            InitializeComponent();
        }
        public void findAllDrugsByTree() {
            //刷新树状图
            treeView1.Nodes.Clear();
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select SName AS 供货商名称,DName AS 药品名称 from Supplier,Drugs where Supplier.SID=Drugs.SID order by SName";
            data.Datacon();
            ds = data.GetDataset(strsql);
            string sname = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (sname != ds.Tables[0].Rows[i][0].ToString())
                {
                    treeNodeFather = treeView1.Nodes.Add(ds.Tables[0].Rows[i][0].ToString());
                }
                treeNodeFather.Nodes.Add(ds.Tables[0].Rows[i][1].ToString());
                sname = ds.Tables[0].Rows[i][0].ToString();
            }
            txt_log.Text += "树状图已刷新\r\n";
        }
        private void UC_Drugs_Load(object sender, EventArgs e)
        {
            findAllDrugsByTree();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = treeView1.SelectedNode;
            if (treeNode == null)
            {
                return;
            }
            if (treeNode.Parent != null)
            {
                if (treeNode.Nodes.Count == 0)
                {
                    string strsql;
                    DataAccess data = new DataAccess();
                    DataSet ds;
                    strsql = "select Drugs.DID,Dname,DExplain,Dcost,DPrice,Sname,Dstock,(select sum(PCNumber) from prescription_content,Drugs where prescription_content.DID=Drugs.DID and DName='" + treeNode.Text.ToString() + "') from Drugs,Supplier where Drugs.SID=Supplier.SID and DName='" + treeNode.Text.ToString() + "'";
                    data.Datacon(); 
                    ds = data.GetDataset(strsql);
                    tabControl1.SelectedIndex = 0;
                    btn_add.Enabled = false;
                    btn_del.Enabled = true;
                    //实例化
                    drugs = new Drugs();
                    drugs.Did =Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    drugs.DName = ds.Tables[0].Rows[0][1].ToString();
                    drugs.DExplain = ds.Tables[0].Rows[0][2].ToString();
                    drugs.DCost = Convert.ToSingle(ds.Tables[0].Rows[0][3].ToString());
                    drugs.DPrice = Convert.ToSingle(ds.Tables[0].Rows[0][4].ToString());
                    drugs.SName = ds.Tables[0].Rows[0][5].ToString();
                    drugs.DStock =Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString());
                    //避免药品为销售记录是返回的空内容造成的类型错误
                    if (ds.Tables[0].Rows[0][7].ToString() == "") {
                        drugs.DSold = 0;
                    }
                    else
                    {
                        drugs.DSold= Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString());
                    }
                    
                    //传递
                    lbl_dName.Text = drugs.DName.ToString();
                    lbl_dExplain.Text = drugs.DExplain;
                    lbl_sName.Text = drugs.SName;
                    lbl_dCost.Text = drugs.DCost.ToString();
                    lbl_dPrice.Text = drugs.DPrice.ToString();
                    lbl_dSold.Text = drugs.DSold.ToString();
                    lbl_Dstok.Text = drugs.DStock.ToString();
                    lbl_profit.Text = Math.Round(((drugs.DPrice - drugs.DCost) * drugs.DSold),2).ToString();
                    txt_log.Text += "已查询药品:"+ treeNode.Text.ToString() + "\r\n";
                }
            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            findAllDrugsByTree();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                string strsql;
                DataAccess data = new DataAccess();
                DataSet ds;
                strsql = "select SName from Supplier";
                data.Datacon();
                ds = data.GetDataset(strsql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbo_sName.Items.Add(ds.Tables[0].Rows[i][0]);
                }
                cbo_sName.SelectedIndex = 0;
                btn_add.Enabled = true;
            }
            else{
                btn_add.Enabled = false;
                cbo_sName.Items.Clear();
            }
            if (drugs != null && tabControl1.SelectedTab == tabPage1)
            {
                btn_del.Enabled = true;
            }
            else {
                btn_del.Enabled = false;
            }
            if (tabControl1.SelectedTab == tabPage3) {
                cbo_addStock.Items.Clear();
                string strsql;
                DataAccess data = new DataAccess();
                DataSet ds;
                strsql = "select DName from Drugs";
                data.Datacon();
                ds = data.GetDataset(strsql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbo_addStock.Items.Add(ds.Tables[0].Rows[i][0]);
                }
                cbo_addStock.SelectedIndex = 0;
                if (drugs != null)
                {
                    txt_reDName.Text = drugs.DName;
                    txt_reDExplain.Text = drugs.DExplain;
                    txt_reCost.Text = drugs.DCost.ToString();
                    txt_reDPrice.Text = drugs.DPrice.ToString();
                    btn_revise.Enabled = true;
                }
                else {
                    btn_revise.Enabled = false;
                }
            }
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (drugs != null) { 
                    lbl_dName.Text = drugs.DName.ToString();
                    lbl_dExplain.Text = drugs.DExplain;
                    lbl_sName.Text = drugs.SName;
                    lbl_dCost.Text = drugs.DCost.ToString();
                    lbl_dPrice.Text = drugs.DPrice.ToString();
                    lbl_dSold.Text = drugs.DSold.ToString();
                    lbl_Dstok.Text = drugs.DStock.ToString();
                    lbl_profit.Text = Math.Round(((drugs.DPrice - drugs.DCost) * drugs.DSold), 2).ToString();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string strsql;
            DataSet ds;
            DataAccess data = new DataAccess();
            if (txt_dName.Text != "" && txt_dCost.Text != "" && txt_dExplain.Text != "" && txt_dPrice.Text != "" && txt_dStock.Text != "")
            {
                //第一次构造SQL语句 查询供货商SID
                strsql = "select SID from Supplier where SName='" + cbo_sName.Text + "'";
                data.Datacon();
                ds = data.GetDataset(strsql);
                string did = ds.Tables[0].Rows[0][0].ToString();
                //第二次构造SQL语句 插入数据
                strsql = "insert into Drugs (DName,DExplain,DCost,DPrice,DStock,SID) values('" + txt_dName.Text.ToString() + "','" + txt_dExplain.Text.ToString() + "','" + txt_dCost.Text.ToString() + "','" + txt_dPrice.Text.ToString() + "','" + txt_dStock.Text.ToString() + "'," + did + ")";
                if (data.SqlExec(strsql))
                {
                    txt_log.Text += DateTime.Now.ToString() + " :添加数据成功\r\n";
                }
                else
                {
                    txt_log.Text += DateTime.Now.ToString() + " :未能成功添加数据\r\n";
                }
            }
            else {
                MessageBox.Show("不能出现空的数据！");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("警告：您正在删除:"+drugs.DName+"，这是不可逆的，是否继续?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr.ToString() == "OK")
            {
                string strsql;
                DataAccess data = new DataAccess();
                strsql = "delete from Drugs where DID=" + drugs.Did;
                data.Datacon();
                if (data.SqlExec(strsql))
                {
                    txt_log.Text += DateTime.Now.ToString() + " :删除数据成功\r\n";
                }
                else { txt_log.Text += DateTime.Now.ToString() + " :未能成功删除数据\r\n"; }
            }
        }

        private void txt_addStork_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btn_addStork_Click(object sender, EventArgs e)
        {
            if (txt_addStock.Text != "")
            {
                if (Convert.ToInt32(txt_addStock.Text) == 0)
                {
                    MessageBox.Show("请输入一个有效数值！");
                }
                else {
                    string strsql;
                    DataAccess data = new DataAccess();
                    strsql = "update Drugs set DStock= DStock +" + txt_addStock.Text +" where DName='" + cbo_addStock.Text+"'";
                    data.Datacon();
                    if (data.SqlExec(strsql))
                    {
                        txt_log.Text += DateTime.Now.ToString() + " :库存添加成功\r\n";
                    }
                    else { txt_log.Text += DateTime.Now.ToString() + " :未成功添加库存\r\n"; }
                }
            }
            else {
                MessageBox.Show("入库数量不能为空！");
            }
        }

        private void txt_addStork_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && e.KeyChar != '-')
                e.Handled = true;

            //-的处理。
            if (e.KeyChar == '-'&&txt_addStock.Text.Length != 0)                           //-
            {
                e.Handled = true;   //-只能在第一位
            }

            /*if (e.KeyChar != '-' && (int)e.KeyChar != 8) {
                if (Convert.ToInt32(txt_addStork.Text) < 0)
                {
                    btn_addStork.Text = "出库";
                }
                else {
                    btn_addStork.Text = "入库";
                }
            }*/
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            string strsql;
            DataAccess data = new DataAccess();
            strsql = "update Drugs set DName='" + txt_reDName.Text + "',DExplain='" + txt_reDExplain.Text + "',DCost=" + txt_reCost.Text + ",DPrice='" + txt_reDPrice.Text + "' where did=" + drugs.Did;
            data.Datacon();
            if (data.SqlExec(strsql))
            {
                txt_log.Text += DateTime.Now.ToString() + " :修改药品信息成功\r\n";
            }
            else { txt_log.Text += DateTime.Now.ToString() + " :未成功修改药品\r\n"; }
            //更新实体类
            drugs.DName = txt_reDName.Text;
            drugs.DExplain = txt_reDExplain.Text;
            drugs.DPrice =Convert.ToSingle(txt_reDPrice.Text);
            drugs.DCost = Convert.ToSingle(txt_reCost.Text);
            tabControl1_Click(sender,e);
        }
    }
}
