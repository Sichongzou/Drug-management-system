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
        Drugs drugs;
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
                    //实例化
                    drugs = new Drugs();
                    drugs.Did =Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    drugs.DName = ds.Tables[0].Rows[0][1].ToString();
                    drugs.DExplain = ds.Tables[0].Rows[0][2].ToString();
                    drugs.DCost = Convert.ToSingle(ds.Tables[0].Rows[0][3].ToString());
                    drugs.DPrice = Convert.ToSingle(ds.Tables[0].Rows[0][4].ToString());
                    drugs.SName = ds.Tables[0].Rows[0][5].ToString();
                    drugs.DStock =Convert.ToInt32(ds.Tables[0].Rows[0][6].ToString());
                    drugs.DSold= Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString());
                    //传递
                    lbl_dName.Text = drugs.DName.ToString();
                    lbl_dExplain.Text = drugs.DExplain;
                    lbl_sName.Text = drugs.SName;
                    lbl_dCost.Text = drugs.DCost.ToString();
                    lbl_dPrice.Text = drugs.DPrice.ToString();
                    lbl_dSold.Text = drugs.DSold.ToString();
                    lbl_Dstok.Text = drugs.DStock.ToString();
                    lbl_profit.Text = ((drugs.DPrice - drugs.DCost) * drugs.DSold).ToString();
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
            else {
                btn_add.Enabled = false;
                cbo_sName.Items.Clear();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string strsql;
            DataSet ds;
            DataAccess data = new DataAccess();
            strsql = "select SID from Supplier where SName='" + cbo_sName.Text + "'";
            data.Datacon();XmlReadMode 
            ds = data.GetDataset(strsql);
            string did = ds.Tables[0].Rows[0][0].ToString();
            strsql= "insert into Drugs (DName,DExplain,DCost,DPrice,DStock,SID) values('" + txt_dName.Text.ToString() + "','" + txt_dExplain.Text.ToString() + "','" + txt_dCost.Text.ToString() + "','" + txt_dPrice.Text.ToString() + "','" + txt_dStock.Text.ToString() + "'," + did + ")";
            if (data.SqlExec(strsql))
            {
                txt_log.Text += DateTime.Now.ToString() + " :添加数据成功\r\n";
            }
            else
            {
                txt_log.Text += DateTime.Now.ToString() + " :未能成功添加数据\r\n";
            }
        }
    }
}
