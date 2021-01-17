namespace Drug_management_system
{
    partial class UC_Supplier
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btn_add = new Sunny.UI.UIButton();
            this.btn_save = new Sunny.UI.UIButton();
            this.btn_revise = new Sunny.UI.UIButton();
            this.btn_del = new Sunny.UI.UIButton();
            this.btn_refresh = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txt_sName = new Sunny.UI.UITextBox();
            this.txt_sDirector = new Sunny.UI.UITextBox();
            this.txt_sPhone = new Sunny.UI.UITextBox();
            this.txt_sAddress = new Sunny.UI.UITextBox();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.txt_log = new Sunny.UI.UITextBox();
            this.dataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.dataGridView1);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox3);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox2);
            this.uiGroupBox1.Controls.Add(this.btn_refresh);
            this.uiGroupBox1.Controls.Add(this.btn_del);
            this.uiGroupBox1.Controls.Add(this.btn_revise);
            this.uiGroupBox1.Controls.Add(this.btn_save);
            this.uiGroupBox1.Controls.Add(this.btn_add);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(18, 5);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1447, 782);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_add.Location = new System.Drawing.Point(41, 83);
            this.btn_add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(111, 56);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "新建";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_save.Location = new System.Drawing.Point(41, 194);
            this.btn_save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 56);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "保存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_revise
            // 
            this.btn_revise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_revise.Enabled = false;
            this.btn_revise.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_revise.Location = new System.Drawing.Point(41, 296);
            this.btn_revise.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_revise.Name = "btn_revise";
            this.btn_revise.Size = new System.Drawing.Size(111, 56);
            this.btn_revise.TabIndex = 26;
            this.btn_revise.Text = "修改";
            this.btn_revise.Click += new System.EventHandler(this.btn_revise_Click);
            // 
            // btn_del
            // 
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.Enabled = false;
            this.btn_del.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_del.Location = new System.Drawing.Point(41, 403);
            this.btn_del.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(111, 56);
            this.btn_del.TabIndex = 27;
            this.btn_del.Text = "删除";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_refresh.Location = new System.Drawing.Point(41, 505);
            this.btn_refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(111, 56);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.txt_sAddress);
            this.uiGroupBox2.Controls.Add(this.txt_sPhone);
            this.uiGroupBox2.Controls.Add(this.txt_sDirector);
            this.uiGroupBox2.Controls.Add(this.txt_sName);
            this.uiGroupBox2.Controls.Add(this.uiLabel4);
            this.uiGroupBox2.Controls.Add(this.uiLabel3);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(229, 53);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(602, 293);
            this.uiGroupBox2.TabIndex = 29;
            this.uiGroupBox2.Text = "基本信息";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(42, 44);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(134, 42);
            this.uiLabel1.TabIndex = 25;
            this.uiLabel1.Text = "供货商名字：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(42, 95);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(134, 42);
            this.uiLabel2.TabIndex = 26;
            this.uiLabel2.Text = "负责人 ：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(42, 155);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(134, 42);
            this.uiLabel3.TabIndex = 27;
            this.uiLabel3.Text = "联系方式：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(42, 215);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(134, 42);
            this.uiLabel4.TabIndex = 28;
            this.uiLabel4.Text = "供货商地址：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sName
            // 
            this.txt_sName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sName.FillColor = System.Drawing.Color.White;
            this.txt_sName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_sName.Location = new System.Drawing.Point(207, 44);
            this.txt_sName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sName.Maximum = 2147483647D;
            this.txt_sName.Minimum = -2147483648D;
            this.txt_sName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_sName.Name = "txt_sName";
            this.txt_sName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_sName.ReadOnly = true;
            this.txt_sName.Size = new System.Drawing.Size(356, 34);
            this.txt_sName.TabIndex = 30;
            // 
            // txt_sDirector
            // 
            this.txt_sDirector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sDirector.FillColor = System.Drawing.Color.White;
            this.txt_sDirector.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_sDirector.Location = new System.Drawing.Point(207, 95);
            this.txt_sDirector.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sDirector.Maximum = 2147483647D;
            this.txt_sDirector.Minimum = -2147483648D;
            this.txt_sDirector.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_sDirector.Name = "txt_sDirector";
            this.txt_sDirector.Padding = new System.Windows.Forms.Padding(5);
            this.txt_sDirector.ReadOnly = true;
            this.txt_sDirector.Size = new System.Drawing.Size(356, 34);
            this.txt_sDirector.TabIndex = 31;
            // 
            // txt_sPhone
            // 
            this.txt_sPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sPhone.FillColor = System.Drawing.Color.White;
            this.txt_sPhone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_sPhone.Location = new System.Drawing.Point(207, 155);
            this.txt_sPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sPhone.Maximum = 2147483647D;
            this.txt_sPhone.Minimum = -2147483648D;
            this.txt_sPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_sPhone.Name = "txt_sPhone";
            this.txt_sPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txt_sPhone.ReadOnly = true;
            this.txt_sPhone.Size = new System.Drawing.Size(356, 34);
            this.txt_sPhone.TabIndex = 31;
            // 
            // txt_sAddress
            // 
            this.txt_sAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sAddress.FillColor = System.Drawing.Color.White;
            this.txt_sAddress.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_sAddress.Location = new System.Drawing.Point(207, 223);
            this.txt_sAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sAddress.Maximum = 2147483647D;
            this.txt_sAddress.Minimum = -2147483648D;
            this.txt_sAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_sAddress.Name = "txt_sAddress";
            this.txt_sAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txt_sAddress.ReadOnly = true;
            this.txt_sAddress.Size = new System.Drawing.Size(356, 34);
            this.txt_sAddress.TabIndex = 31;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiGroupBox3.Controls.Add(this.txt_log);
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(229, 356);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(602, 247);
            this.uiGroupBox3.TabIndex = 1;
            this.uiGroupBox3.Text = "操作日志";
            // 
            // txt_log
            // 
            this.txt_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_log.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_log.FillColor = System.Drawing.Color.White;
            this.txt_log.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_log.Location = new System.Drawing.Point(35, 37);
            this.txt_log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_log.Maximum = 2147483647D;
            this.txt_log.Minimum = -2147483648D;
            this.txt_log.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Padding = new System.Windows.Forms.Padding(5);
            this.txt_log.ReadOnly = true;
            this.txt_log.Size = new System.Drawing.Size(540, 185);
            this.txt_log.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(847, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectedIndex = -1;
            this.dataGridView1.ShowGridLine = true;
            this.dataGridView1.Size = new System.Drawing.Size(211, 536);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // UC_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.uiGroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "UC_Supplier";
            this.Size = new System.Drawing.Size(1487, 810);
            this.Load += new System.EventHandler(this.UC_Supplier_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btn_add;
        private Sunny.UI.UIButton btn_refresh;
        private Sunny.UI.UIButton btn_del;
        private Sunny.UI.UIButton btn_revise;
        private Sunny.UI.UIButton btn_save;
        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UITextBox txt_log;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UITextBox txt_sAddress;
        private Sunny.UI.UITextBox txt_sPhone;
        private Sunny.UI.UITextBox txt_sDirector;
        private Sunny.UI.UITextBox txt_sName;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
    }
}
