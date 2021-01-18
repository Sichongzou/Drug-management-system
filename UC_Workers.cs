using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drug_management_system
{
    public partial class UC_Workers : UserControl
    {
        string Wid,UserName;
        OpenFileDialog fileDialog = new OpenFileDialog();
        string filePath="";
        string myFilePath= Application.StartupPath.ToString()+"\\Picture\\";
        public UC_Workers()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void rivise_message() {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select WID,WName,WAge,WPhone,WEdu,WAddress,WSex,WSalary,UserName from Workers Where WID=" + Wid;
            data.Datacon();
            ds = data.GetDataset(strsql);
            Wid = ds.Tables[0].Rows[0][0].ToString();
            txt_wName.Text = ds.Tables[0].Rows[0][1].ToString();
            txt_wAge.Text = ds.Tables[0].Rows[0][2].ToString();
            txt_wPhone.Text = ds.Tables[0].Rows[0][3].ToString();
            txt_wEdu.Text = ds.Tables[0].Rows[0][4].ToString();
            txt_wAddress.Text = ds.Tables[0].Rows[0][5].ToString();
            cbo_wSex.Text = ds.Tables[0].Rows[0][6].ToString();
            txt_wSalary.Text = ds.Tables[0].Rows[0][7].ToString();
            UserName = ds.Tables[0].Rows[0][8].ToString();
            txt_UserName.Text = ds.Tables[0].Rows[0][8].ToString();
            //二次构造SQL语句查询对应密码
            strsql = "select UserPassword from Login Where UserName = '" + txt_UserName.Text + "'";
            ds = data.GetDataset(strsql);
            txt_Password.Text = ds.Tables[0].Rows[0][0].ToString();
            //放入头像 使用文件流方式读取Image.FromFile()会导致文件流一直开启，文件被锁定
            //读取文件流
            FileStream fs = new FileStream(myFilePath + Wid + ".png", FileMode.Open, FileAccess.Read);
            int byteLength = (int)fs.Length;
            byte[] fileBytes = new byte[byteLength];
            fs.Read(fileBytes, 0, byteLength);
            //关闭文件流 解除文件锁定
            fs.Close();
            pictureBox1.Image = Image.FromStream(new MemoryStream(fileBytes));
        }
        private void findAllDoctor() {
            string strsql;
            DataAccess data = new DataAccess();
            DataSet ds;
            strsql = "select WID AS 职工编号,WName AS 姓名 from Workers";
            data.Datacon();
            ds = data.GetDataset(strsql);
            dataGridView1.DataSource = ds.Tables[0];
            //避免无数据时修改属性出现bug
            if (dataGridView1.Columns.Count > 1) { 
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {   
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(fileDialog.FileName);
                filePath=fileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //无效化删除按钮 和 修改按钮
            btn_reivse.Enabled = false;
            btn_del.Enabled = false;
            if (btn_add.Text == "新建职工") {
                btn_add.Text = "取消新建";
                btn_SelectPhoto.Enabled = true;
                btn_safe.Enabled = true;
                txt_wName.ReadOnly=false;
                txt_wAge.ReadOnly = false;
                txt_wAddress.ReadOnly = false;
                txt_wPhone.ReadOnly = false;
                cbo_wSex.Enabled= true;
                txt_wSalary.ReadOnly = false;
                txt_wEdu.ReadOnly = false;
                txt_Password.ReadOnly = false;
                txt_UserName.ReadOnly = false;
            }
            else {
                btn_add.Text = "新建职工";
                btn_safe.Enabled = false;
                btn_SelectPhoto.Enabled = false;
                txt_wName.ReadOnly=true;
                txt_wAge.ReadOnly = true;
                txt_wAddress.ReadOnly = true;
                txt_wPhone.ReadOnly = true;
                cbo_wSex.Enabled = false;
                txt_wSalary.ReadOnly = true;
                txt_wEdu.ReadOnly = true;
                txt_Password.ReadOnly = true;
                txt_UserName.ReadOnly = true;
            }
            //清空数据
            txt_wName.Text = "";
            txt_wAge.Text = "";
            txt_wAddress.Text = "";
            txt_wPhone.Text = "";
            cbo_wSex.Text = "";
            txt_wSalary.Text = "";
            txt_wEdu.Text = "";
            txt_Password.Text = "";
            txt_UserName.Text = "";
            pictureBox1.Image = null;
            dataGridView2.DataSource = null;
        }

        private void btn_reivse_Click(object sender, EventArgs e)
        {
            if (btn_reivse.Text == "修改职工信息")
            {
                btn_reivse.Text = "取消修改";
                btn_add.Enabled = false;
                btn_del.Enabled = false;
                btn_safe.Enabled = true;
                btn_SelectPhoto.Enabled = true;
                txt_wName.ReadOnly = false;
                txt_wAge.ReadOnly = false;
                txt_wAddress.ReadOnly = false;
                txt_wPhone.ReadOnly = false;
                cbo_wSex.Enabled = true;
                txt_wSalary.ReadOnly = false;
                txt_wEdu.ReadOnly = false;
                txt_Password.ReadOnly = false;
                txt_UserName.ReadOnly = false;
            }
            else
            {
                btn_reivse.Text = "修改职工信息";
                btn_add.Enabled = true;
                btn_safe.Enabled = false;
                btn_del.Enabled = true;
                btn_refresh.Enabled = true;
                btn_SelectPhoto.Enabled = false;
                txt_wName.ReadOnly = true;
                txt_wAge.ReadOnly = true;
                txt_wAddress.ReadOnly = true;
                txt_wPhone.ReadOnly = true;
                cbo_wSex.Enabled = false;
                txt_wSalary.ReadOnly = true;
                txt_wEdu.ReadOnly = true;
                txt_Password.ReadOnly = true;
                txt_UserName.ReadOnly = true;
                //防止用户修改了信息 进行重新查询赋值
                Thread thread = new Thread(new ThreadStart(rivise_message));
                thread.Start();

            }
        }

        private void btn_safe_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || txt_wName.Text == "" || txt_wAddress.Text == "" || txt_wAge.Text == "" || txt_wEdu.Text == "" || txt_wPhone.Text == "" || txt_wSalary.Text == "" || cbo_wSex.Text == "" || txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("不能有空的字段（包括图片！）");
                return;
            }
            if (btn_add.Enabled == true)
            {
                //这里写新建部分
                string strsql;
                DataAccess data = new DataAccess();
                //向Worker添加信息
                strsql = "insert into Workers (WName,WAge,WPhone,WEdu,WAddress,WSex,WSalary,UserName) values('" + txt_wName.Text.ToString() + "','" + txt_wAge.Text.ToString() + "','" + txt_wPhone.Text.ToString() + "','" + txt_wEdu.Text.ToString() + "','" + txt_wAddress.Text.ToString() + "','" + cbo_wSex.Text.ToString() + "','" + txt_wSalary.Text.ToString() + "','" + txt_UserName.Text.ToString() + "')";
                data.Datacon();
                data.SqlExec(strsql);
                //向Login添加登录信息
                strsql = "insert into Login (UserName,UserPassword,UserPower) values('" + txt_UserName.Text.ToString() + "','" + txt_Password.Text.ToString() + "','医师')";
                data.SqlExec(strsql);
                //查询新生成的WID 用作头像文件的命名
                strsql = "select WID from Workers where WName='" + txt_wName.Text.ToString() + "' and WPhone='" + txt_wPhone.Text.ToString() + "'";
                DataSet ds = data.GetDataset(strsql);
                //构造图片文件名
                string wid = ds.Tables[0].Rows[0][0].ToString() + ".png";
                //头像本地处理
                if (filePath != "")
                {
                    File.Copy(filePath, myFilePath + wid, true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                }
                btn_add.Text = "新建职工";
            }
            else {
                //这里写修改部分
                string strsql;
                DataAccess data = new DataAccess();
                //修改Worker信息
                strsql = "update Workers set WName='" + txt_wName.Text.ToString() + "',WAge='" + txt_wAge.Text.ToString() + "',WPhone='" + txt_wPhone.Text.ToString() + "',WEdu='" + txt_wEdu.Text.ToString() + "',WAddress='" + txt_wAddress.Text + "',WSex='" + cbo_wSex.Text + "',WSalary=" + txt_wSalary.Text.ToString() + ",UserName='" + txt_UserName.Text.ToString() + "' Where Wid=" + Wid;
                data.Datacon();
                data.SqlExec(strsql);
                //修改Login表信息
                strsql = "update Login set UserName='" + txt_UserName.Text + "',UserPassword='"+txt_Password.Text+"' Where UserName='"+UserName+"'";
                data.SqlExec(strsql);
                //修改图片
                if (filePath != "") { 
                    File.Copy(filePath, myFilePath + Wid+".png", true);//三个参数分别是源文件路径，存储路径，若存储路径有相同文件是否替换
                }
                btn_reivse.Text = "修改职工信息";
            }
            //刷新
            btn_add.Enabled = true;
            btn_safe.Enabled = false;
            btn_del.Enabled = true;
            btn_refresh.Enabled = true;
            btn_SelectPhoto.Enabled = false;
            txt_wName.ReadOnly = true;
            txt_wAge.ReadOnly = true;
            txt_wAddress.ReadOnly = true;
            txt_wPhone.ReadOnly = true;
            cbo_wSex.Enabled = false;
            txt_wSalary.ReadOnly = true;
            txt_wEdu.ReadOnly = true;
            txt_Password.ReadOnly = true;
            txt_UserName.ReadOnly = true;
            findAllDoctor();
        }

        private void UC_Workers_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(findAllDoctor));
            thread.Start();
            cbo_wSex.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_wName.ReadOnly == true) {
                string selectWid="";
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    if (dataGridView1.Rows[i].Selected) {
                        selectWid = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        break;
                    }
                }
                if (selectWid != "")
                {
                    string strsql;
                    DataAccess data = new DataAccess();
                    DataSet ds;
                    strsql = "select WID,WName,WAge,WPhone,WEdu,WAddress,WSex,WSalary,UserName from Workers Where WID=" + selectWid;
                    data.Datacon();
                    ds = data.GetDataset(strsql);
                    Wid = ds.Tables[0].Rows[0][0].ToString();
                    txt_wName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txt_wAge.Text = ds.Tables[0].Rows[0][2].ToString();
                    txt_wPhone.Text = ds.Tables[0].Rows[0][3].ToString();
                    txt_wEdu.Text = ds.Tables[0].Rows[0][4].ToString();
                    txt_wAddress.Text = ds.Tables[0].Rows[0][5].ToString();
                    cbo_wSex.Text = ds.Tables[0].Rows[0][6].ToString();
                    txt_wSalary.Text = ds.Tables[0].Rows[0][7].ToString();
                    UserName = ds.Tables[0].Rows[0][8].ToString();
                    txt_UserName.Text = ds.Tables[0].Rows[0][8].ToString();
                    //二次构造SQL语句查询对应密码
                    strsql = "select UserPassword from Login Where UserName = '" + txt_UserName.Text + "'";
                    ds = data.GetDataset(strsql);
                    txt_Password.Text = ds.Tables[0].Rows[0][0].ToString();
                    //放入头像 使用文件流方式读取Image.FromFile()会导致文件流一直开启，文件被锁定
                    FileStream fs = new FileStream(myFilePath + Wid + ".png", FileMode.Open, FileAccess.Read);
                    int byteLength = (int)fs.Length;
                    byte[] fileBytes = new byte[byteLength];
                    fs.Read(fileBytes, 0, byteLength);
                    //关闭文件流 解除文件锁定
                    fs.Close();
                    pictureBox1.Image = Image.FromStream(new MemoryStream(fileBytes));
                    //解锁修改 和 删除按钮
                    btn_del.Enabled = true;
                    btn_reivse.Enabled = true;
                    //向dataGridView2添加数据
                    strsql = "select PID AS 处方编号,CName AS 客户姓名,PDate AS 开方日期 from Prescription,Customer Where Customer.CID=Prescription.CID and WID=" + Wid;
                    ds = data.GetDataset(strsql);
                    //处理dataGridView2的列界面
                    dataGridView2.DataSource = ds.Tables[0];
                    //避免无数据时修改属性出现bug
                    if (dataGridView2.Columns.Count > 1)
                    {
                        dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            findAllDoctor();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("警告：您正在删除:" + txt_wName.Text + "，这是不可逆的，是否继续?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr.ToString() == "OK")
            {
                string strsql;
                DataAccess data = new DataAccess();
                //删除Worker表中的数据
                strsql = "delete from Workers where WID=" + Wid;
                data.Datacon();
                data.SqlExec(strsql);
                //删除Login表中的数据
                strsql = "delete from Login where UserName='" + Wid + "'" ;
                data.SqlExec(strsql);
                //删除头像图片
                File.Delete(myFilePath + Wid + ".png");
                txt_wName.Text = "";
                txt_wAge.Text = "";
                txt_wAddress.Text = "";
                txt_wPhone.Text = "";
                cbo_wSex.Text = "";
                txt_wSalary.Text = "";
                txt_wEdu.Text = "";
                txt_Password.Text = "";
                txt_UserName.Text = "";
                pictureBox1.Image = null;
                dataGridView2.DataSource = null;
                findAllDoctor();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            int i;
            string pid = "";
            for (i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Selected)
                {
                    pid = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }
            if (i == dataGridView2.Rows.Count)
            {
                MessageBox.Show("当前未选中行，请先选中行！");
                return;
            }
            string strsql, content;
            DataAccess data = new DataAccess();
            data.Datacon();
            DataSet ds;
            content = "此处方包含内容如下：\r\n";
            //查询处方内容表中的所有PID订单
            strsql = "Select DID,PcNumber from Prescription_content where pid=" + pid;
            ds = data.GetDataset(strsql);
            //通过DID去药品表中寻找药品名称 对应数量构造字符串
            DataSet dr;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                strsql = "Select DName from Drugs where Did=" + ds.Tables[0].Rows[i][0];
                dr = data.GetDataset(strsql);
                if (dr.Tables[0].Rows.Count == 0)
                {
                    content += "已删除的药品" + "  X" + ds.Tables[0].Rows[i][1] + "\r\n";
                }
                else
                {
                    content += dr.Tables[0].Rows[0][0] + "  X" + ds.Tables[0].Rows[i][1] + "\r\n";
                }
            }
            //通过PID去寻找医嘱
            strsql = "Select PRemarks from Prescription where Pid=" + pid;
            dr = data.GetDataset(strsql);
            content += "\r\n医嘱：" + dr.Tables[0].Rows[0][0].ToString();
            MessageBox.Show(content);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '*')
            {
                txt_Password.PasswordChar = '\0';
            }
            else {
                txt_Password.PasswordChar = '*';
            }
        }
    }
}
