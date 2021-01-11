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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_revise = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_sAddress = new System.Windows.Forms.TextBox();
            this.txt_sPhone = new System.Windows.Forms.TextBox();
            this.txt_sDirector = new System.Windows.Forms.TextBox();
            this.txt_sName = new System.Windows.Forms.TextBox();
            this.lbl_sAddress = new System.Windows.Forms.Label();
            this.lbl_sPhone = new System.Windows.Forms.Label();
            this.lbl_sDirector = new System.Windows.Forms.Label();
            this.lbl_sName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_saverevise = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_revise);
            this.groupBox1.Controls.Add(this.btn_saverevise);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 755);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(266, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 297);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作日志";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(32, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(418, 225);
            this.textBox1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(71, 501);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(114, 57);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_revise
            // 
            this.btn_revise.Location = new System.Drawing.Point(71, 390);
            this.btn_revise.Name = "btn_revise";
            this.btn_revise.Size = new System.Drawing.Size(114, 57);
            this.btn_revise.TabIndex = 11;
            this.btn_revise.Text = "修改";
            this.btn_revise.UseVisualStyleBackColor = true;
            this.btn_revise.Visible = false;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(71, 299);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(114, 57);
            this.btn_del.TabIndex = 10;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(71, 125);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 57);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "新增";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_sAddress);
            this.groupBox2.Controls.Add(this.txt_sPhone);
            this.groupBox2.Controls.Add(this.txt_sDirector);
            this.groupBox2.Controls.Add(this.txt_sName);
            this.groupBox2.Controls.Add(this.lbl_sAddress);
            this.groupBox2.Controls.Add(this.lbl_sPhone);
            this.groupBox2.Controls.Add(this.lbl_sDirector);
            this.groupBox2.Controls.Add(this.lbl_sName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Location = new System.Drawing.Point(266, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 322);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本信息";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // txt_sAddress
            // 
            this.txt_sAddress.Location = new System.Drawing.Point(364, 246);
            this.txt_sAddress.Name = "txt_sAddress";
            this.txt_sAddress.Size = new System.Drawing.Size(99, 25);
            this.txt_sAddress.TabIndex = 16;
            // 
            // txt_sPhone
            // 
            this.txt_sPhone.Location = new System.Drawing.Point(364, 174);
            this.txt_sPhone.Name = "txt_sPhone";
            this.txt_sPhone.Size = new System.Drawing.Size(99, 25);
            this.txt_sPhone.TabIndex = 15;
            // 
            // txt_sDirector
            // 
            this.txt_sDirector.Location = new System.Drawing.Point(364, 106);
            this.txt_sDirector.Name = "txt_sDirector";
            this.txt_sDirector.Size = new System.Drawing.Size(99, 25);
            this.txt_sDirector.TabIndex = 14;
            // 
            // txt_sName
            // 
            this.txt_sName.Location = new System.Drawing.Point(364, 52);
            this.txt_sName.Name = "txt_sName";
            this.txt_sName.Size = new System.Drawing.Size(99, 25);
            this.txt_sName.TabIndex = 13;
            // 
            // lbl_sAddress
            // 
            this.lbl_sAddress.AutoSize = true;
            this.lbl_sAddress.Location = new System.Drawing.Point(245, 246);
            this.lbl_sAddress.Name = "lbl_sAddress";
            this.lbl_sAddress.Size = new System.Drawing.Size(55, 15);
            this.lbl_sAddress.TabIndex = 12;
            this.lbl_sAddress.Text = "label8";
            // 
            // lbl_sPhone
            // 
            this.lbl_sPhone.AutoSize = true;
            this.lbl_sPhone.Location = new System.Drawing.Point(245, 184);
            this.lbl_sPhone.Name = "lbl_sPhone";
            this.lbl_sPhone.Size = new System.Drawing.Size(55, 15);
            this.lbl_sPhone.TabIndex = 11;
            this.lbl_sPhone.Text = "label7";
            // 
            // lbl_sDirector
            // 
            this.lbl_sDirector.AutoSize = true;
            this.lbl_sDirector.Location = new System.Drawing.Point(245, 112);
            this.lbl_sDirector.Name = "lbl_sDirector";
            this.lbl_sDirector.Size = new System.Drawing.Size(55, 15);
            this.lbl_sDirector.TabIndex = 10;
            this.lbl_sDirector.Text = "label6";
            // 
            // lbl_sName
            // 
            this.lbl_sName.AutoSize = true;
            this.lbl_sName.Location = new System.Drawing.Point(245, 49);
            this.lbl_sName.Name = "lbl_sName";
            this.lbl_sName.Size = new System.Drawing.Size(55, 15);
            this.lbl_sName.TabIndex = 9;
            this.lbl_sName.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "联系方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(50, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "供货商地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "负责人：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "供货商名字：";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(71, 218);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(114, 57);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(877, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(330, 671);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_saverevise
            // 
            this.btn_saverevise.Location = new System.Drawing.Point(71, 390);
            this.btn_saverevise.Name = "btn_saverevise";
            this.btn_saverevise.Size = new System.Drawing.Size(114, 57);
            this.btn_saverevise.TabIndex = 12;
            this.btn_saverevise.Text = "保存修改";
            this.btn_saverevise.UseVisualStyleBackColor = true;
            this.btn_saverevise.Visible = false;
            // 
            // UC_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "UC_Supplier";
            this.Size = new System.Drawing.Size(1269, 803);
            this.Load += new System.EventHandler(this.UC_Supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_saverevise;
        private System.Windows.Forms.Button btn_revise;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_sAddress;
        private System.Windows.Forms.Label lbl_sPhone;
        private System.Windows.Forms.Label lbl_sDirector;
        private System.Windows.Forms.Label lbl_sName;
        private System.Windows.Forms.TextBox txt_sAddress;
        private System.Windows.Forms.TextBox txt_sPhone;
        private System.Windows.Forms.TextBox txt_sDirector;
        private System.Windows.Forms.TextBox txt_sName;
    }
}
