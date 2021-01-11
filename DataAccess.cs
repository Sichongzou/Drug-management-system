using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Drug_management_system
{
    class DataAccess
    {
        private string strDSN;//定义连接字符串
        OleDbConnection oledbCon;//定义数据库连接对象
        //链接数据库
        public void Datacon()
        {
            strDSN = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath.ToString() + "\\DataBase\\Pharmacy.accdb";
            oledbCon = new OleDbConnection(strDSN);
        }
        //获取返回值
        public DataSet GetDataset(string sql)
        {
            DataSet ds = new DataSet();
            oledbCon.Open();
            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);
                OleDbDataAdapter oledbDa = new OleDbDataAdapter(oledbCom);
                oledbDa.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                oledbCon.Close();
            }
        }
        //执行SQL语句
        public bool SqlExec(string sql)
        {
            try
            {
                oledbCon.Open();
            }
            catch
            {
                MessageBox.Show("数据库未连接");
            }
            try
            {
                OleDbCommand oledbCom = new OleDbCommand(sql, oledbCon);
                oledbCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示");
                return false;
            }
            finally
            {
                oledbCon.Close();
            }
        }
    }
}
