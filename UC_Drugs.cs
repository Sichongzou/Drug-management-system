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
    public partial class UC_Drugs : UserControl
    {
        public UC_Drugs()
        {
            InitializeComponent();
        }
        public void fianAllDrugsByTree() {
            //刷新树状图
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select SName AS 供货商名称,DName AS 药品名称 from Supplier,Drugs where Supplier.SID=Drugs.SID";
            data.Datacon();
            ds = data.GetDataset(strsql);
            for(int i = 0; i < ds.Tables[0].Rows.Count;i++){
                //遍历所有根节点 是否出现重复供货商
                for (int j = 0; j < treeView1.Nodes.Count;j++) { 
                    
                }
            }
            
        }
        private void UC_Drugs_Load(object sender, EventArgs e)
        {

        }
    }
}
