using System;
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
    public partial class UC_Prescription : UserControl
    {
        
        public UC_Prescription()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Change(object sender, EventArgs e) {
            string strsql, condition = "";
            DataAccess data = new DataAccess();
            data.Datacon();
            DataSet ds;
            if (txt_cName.Text != "") {
                condition += "and CName='" + txt_cName.Text + "'";
            }
            if (cbo_workers.Text != "")
            {
                condition += "and WName='" + cbo_workers.Text + "'";
            }
            //时间范围查询
            condition += "and PDate>=#" + dt_start.Value.Year.ToString() + "-" + dt_start.Value.Month.ToString() + "-" + dt_start.Value.Day.ToString() + "#";
            condition += "and PDate<=#" + dt_end.Value.Year.ToString() + "-" + dt_end.Value.Month.ToString() + "-" + dt_end.Value.Day.ToString() + "#";
            strsql = "select PID AS 处方编号,CName AS 患者姓名,WName AS 主治医师,PDate AS 开方日期 From Customer,Workers,Prescription Where 1=1 and Customer.CID=Prescription.CID and Prescription.WID=Workers.WID " + condition;
            ds = data.GetDataset(strsql);
            dataGridView1.DataSource=ds.Tables[0];
        }
        private void Load_Drugs_Workers() {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            //创立链接
            data.Datacon();
            //查询医师数据
            strsql = "select WID,WName from Workers";
            //返回结果集
            ds = data.GetDataset(strsql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo_workers.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
        }
        private void UC_Prescription_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Load_Drugs_Workers));
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
