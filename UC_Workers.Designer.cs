
namespace Drug_management_system
{
    partial class UC_Workers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_wSex = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_wEdu = new System.Windows.Forms.TextBox();
            this.txt_wSalary = new System.Windows.Forms.TextBox();
            this.txt_wPhone = new System.Windows.Forms.TextBox();
            this.txt_wAddress = new System.Windows.Forms.TextBox();
            this.txt_wAge = new System.Windows.Forms.TextBox();
            this.txt_wName = new System.Windows.Forms.TextBox();
            this.btn_SelectPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_safe = new System.Windows.Forms.Button();
            this.btn_reivse = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbo_wSex);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_wEdu);
            this.groupBox1.Controls.Add(this.txt_wSalary);
            this.groupBox1.Controls.Add(this.txt_wPhone);
            this.groupBox1.Controls.Add(this.txt_wAddress);
            this.groupBox1.Controls.Add(this.txt_wAge);
            this.groupBox1.Controls.Add(this.txt_wName);
            this.groupBox1.Controls.Add(this.btn_SelectPhoto);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(491, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "职工基本信息";
            // 
            // cbo_wSex
            // 
            this.cbo_wSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_wSex.FormattingEnabled = true;
            this.cbo_wSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbo_wSex.Location = new System.Drawing.Point(104, 82);
            this.cbo_wSex.Name = "cbo_wSex";
            this.cbo_wSex.Size = new System.Drawing.Size(164, 23);
            this.cbo_wSex.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txt_Password);
            this.groupBox2.Controls.Add(this.txt_UserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(38, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 126);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "登录信息：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 19);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(368, 47);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.ReadOnly = true;
            this.txt_Password.Size = new System.Drawing.Size(165, 25);
            this.txt_Password.TabIndex = 17;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(88, 47);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(165, 25);
            this.txt_UserName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "用户名：";
            // 
            // txt_wEdu
            // 
            this.txt_wEdu.Location = new System.Drawing.Point(384, 128);
            this.txt_wEdu.Name = "txt_wEdu";
            this.txt_wEdu.ReadOnly = true;
            this.txt_wEdu.Size = new System.Drawing.Size(165, 25);
            this.txt_wEdu.TabIndex = 15;
            // 
            // txt_wSalary
            // 
            this.txt_wSalary.Location = new System.Drawing.Point(384, 85);
            this.txt_wSalary.Name = "txt_wSalary";
            this.txt_wSalary.ReadOnly = true;
            this.txt_wSalary.Size = new System.Drawing.Size(165, 25);
            this.txt_wSalary.TabIndex = 14;
            // 
            // txt_wPhone
            // 
            this.txt_wPhone.Location = new System.Drawing.Point(384, 52);
            this.txt_wPhone.Name = "txt_wPhone";
            this.txt_wPhone.ReadOnly = true;
            this.txt_wPhone.Size = new System.Drawing.Size(165, 25);
            this.txt_wPhone.TabIndex = 13;
            // 
            // txt_wAddress
            // 
            this.txt_wAddress.Location = new System.Drawing.Point(104, 174);
            this.txt_wAddress.Name = "txt_wAddress";
            this.txt_wAddress.ReadOnly = true;
            this.txt_wAddress.Size = new System.Drawing.Size(445, 25);
            this.txt_wAddress.TabIndex = 12;
            // 
            // txt_wAge
            // 
            this.txt_wAge.Location = new System.Drawing.Point(104, 128);
            this.txt_wAge.Name = "txt_wAge";
            this.txt_wAge.ReadOnly = true;
            this.txt_wAge.Size = new System.Drawing.Size(165, 25);
            this.txt_wAge.TabIndex = 11;
            // 
            // txt_wName
            // 
            this.txt_wName.Location = new System.Drawing.Point(104, 45);
            this.txt_wName.Name = "txt_wName";
            this.txt_wName.ReadOnly = true;
            this.txt_wName.Size = new System.Drawing.Size(165, 25);
            this.txt_wName.TabIndex = 9;
            // 
            // btn_SelectPhoto
            // 
            this.btn_SelectPhoto.Enabled = false;
            this.btn_SelectPhoto.Location = new System.Drawing.Point(818, 290);
            this.btn_SelectPhoto.Name = "btn_SelectPhoto";
            this.btn_SelectPhoto.Size = new System.Drawing.Size(117, 29);
            this.btn_SelectPhoto.TabIndex = 8;
            this.btn_SelectPhoto.Text = "选择照片";
            this.btn_SelectPhoto.UseVisualStyleBackColor = true;
            this.btn_SelectPhoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(745, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "联系方式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "工资：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "住址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "学历：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "年龄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Location = new System.Drawing.Point(538, 766);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 40);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "新建职工";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(354, 769);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_safe
            // 
            this.btn_safe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_safe.Enabled = false;
            this.btn_safe.Location = new System.Drawing.Point(767, 766);
            this.btn_safe.Name = "btn_safe";
            this.btn_safe.Size = new System.Drawing.Size(139, 40);
            this.btn_safe.TabIndex = 11;
            this.btn_safe.Text = "保存";
            this.btn_safe.UseVisualStyleBackColor = true;
            this.btn_safe.Click += new System.EventHandler(this.btn_safe_Click);
            // 
            // btn_reivse
            // 
            this.btn_reivse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reivse.Enabled = false;
            this.btn_reivse.Location = new System.Drawing.Point(1008, 766);
            this.btn_reivse.Name = "btn_reivse";
            this.btn_reivse.Size = new System.Drawing.Size(139, 40);
            this.btn_reivse.TabIndex = 12;
            this.btn_reivse.Text = "修改职工信息";
            this.btn_reivse.UseVisualStyleBackColor = true;
            this.btn_reivse.Click += new System.EventHandler(this.btn_reivse_Click);
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_del.Enabled = false;
            this.btn_del.Location = new System.Drawing.Point(1207, 766);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(139, 40);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.Enabled = false;
            this.btn_refresh.Location = new System.Drawing.Point(1398, 766);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(139, 40);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(491, 458);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(1035, 270);
            this.dataGridView2.TabIndex = 14;
            // 
            // UC_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_reivse);
            this.Controls.Add(this.btn_safe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Workers";
            this.Size = new System.Drawing.Size(1576, 840);
            this.Load += new System.EventHandler(this.UC_Workers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SelectPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_safe;
        private System.Windows.Forms.Button btn_reivse;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_wEdu;
        private System.Windows.Forms.TextBox txt_wSalary;
        private System.Windows.Forms.TextBox txt_wPhone;
        private System.Windows.Forms.TextBox txt_wAddress;
        private System.Windows.Forms.TextBox txt_wAge;
        private System.Windows.Forms.TextBox txt_wName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_wSex;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
