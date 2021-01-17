namespace Drug_management_system
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_returnMain = new Sunny.UI.UIButton();
            this.btn_logOut = new Sunny.UI.UIButton();
            this.label1 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btn_toAddPrescription = new System.Windows.Forms.Button();
            this.btn_toPrescription = new System.Windows.Forms.Button();
            this.btn_toDrugs = new System.Windows.Forms.Button();
            this.btn_toSupplier = new System.Windows.Forms.Button();
            this.lbl_userPower = new Sunny.UI.UILabel();
            this.lbl_userName = new Sunny.UI.UILabel();
            this.btn_toWorkers = new System.Windows.Forms.Button();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1517, 142);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // btn_returnMain
            // 
            this.btn_returnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_returnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_returnMain.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_returnMain.Location = new System.Drawing.Point(1070, 76);
            this.btn_returnMain.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_returnMain.Name = "btn_returnMain";
            this.btn_returnMain.Radius = 0;
            this.btn_returnMain.Size = new System.Drawing.Size(103, 35);
            this.btn_returnMain.TabIndex = 3;
            this.btn_returnMain.Text = "返回主页";
            this.btn_returnMain.Click += new System.EventHandler(this.btn_returnMain_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logOut.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_logOut.Location = new System.Drawing.Point(1219, 76);
            this.btn_logOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Radius = 0;
            this.btn_logOut.Size = new System.Drawing.Size(102, 35);
            this.btn_logOut.TabIndex = 4;
            this.btn_logOut.Text = "退出登录";
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(1176, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前用户：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(1176, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "权限：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(696, 423);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 26);
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "新建处方";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.Visible = false;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(853, 423);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 26);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "处方查询";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Visible = false;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(548, 423);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 26);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "药品管理";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.Visible = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(260, 423);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(117, 26);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "供货商管理";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Visible = false;
            // 
            // btn_toAddPrescription
            // 
            this.btn_toAddPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_toAddPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toAddPrescription.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_toAddPrescription.Image = ((System.Drawing.Image)(resources.GetObject("btn_toAddPrescription.Image")));
            this.btn_toAddPrescription.Location = new System.Drawing.Point(655, 242);
            this.btn_toAddPrescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_toAddPrescription.Name = "btn_toAddPrescription";
            this.btn_toAddPrescription.Size = new System.Drawing.Size(181, 178);
            this.btn_toAddPrescription.TabIndex = 5;
            this.btn_toAddPrescription.Visible = false;
            this.btn_toAddPrescription.Click += new System.EventHandler(this.btn_toAddPrescription_Click);
            // 
            // btn_toPrescription
            // 
            this.btn_toPrescription.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toPrescription.BackgroundImage")));
            this.btn_toPrescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_toPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toPrescription.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_toPrescription.Location = new System.Drawing.Point(808, 242);
            this.btn_toPrescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_toPrescription.Name = "btn_toPrescription";
            this.btn_toPrescription.Size = new System.Drawing.Size(181, 178);
            this.btn_toPrescription.TabIndex = 4;
            this.btn_toPrescription.Visible = false;
            this.btn_toPrescription.Click += new System.EventHandler(this.btn_toPrescription_Click);
            // 
            // btn_toDrugs
            // 
            this.btn_toDrugs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toDrugs.BackgroundImage")));
            this.btn_toDrugs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_toDrugs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toDrugs.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_toDrugs.Location = new System.Drawing.Point(510, 242);
            this.btn_toDrugs.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_toDrugs.Name = "btn_toDrugs";
            this.btn_toDrugs.Size = new System.Drawing.Size(181, 178);
            this.btn_toDrugs.TabIndex = 1;
            this.btn_toDrugs.Visible = false;
            this.btn_toDrugs.Click += new System.EventHandler(this.btn_toDrugs_Click);
            // 
            // btn_toSupplier
            // 
            this.btn_toSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toSupplier.BackgroundImage")));
            this.btn_toSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_toSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toSupplier.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_toSupplier.Location = new System.Drawing.Point(221, 242);
            this.btn_toSupplier.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_toSupplier.Name = "btn_toSupplier";
            this.btn_toSupplier.Size = new System.Drawing.Size(181, 178);
            this.btn_toSupplier.TabIndex = 0;
            this.btn_toSupplier.Visible = false;
            this.btn_toSupplier.Click += new System.EventHandler(this.btn_toSupplier_Click);
            // 
            // lbl_userPower
            // 
            this.lbl_userPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userPower.AutoSize = true;
            this.lbl_userPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lbl_userPower.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_userPower.Location = new System.Drawing.Point(1321, 39);
            this.lbl_userPower.Name = "lbl_userPower";
            this.lbl_userPower.Size = new System.Drawing.Size(0, 27);
            this.lbl_userPower.TabIndex = 22;
            this.lbl_userPower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_userName
            // 
            this.lbl_userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lbl_userName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbl_userName.Location = new System.Drawing.Point(1321, 11);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(0, 27);
            this.lbl_userName.TabIndex = 21;
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_toWorkers
            // 
            this.btn_toWorkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_toWorkers.BackgroundImage")));
            this.btn_toWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_toWorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toWorkers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_toWorkers.Location = new System.Drawing.Point(1113, 242);
            this.btn_toWorkers.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_toWorkers.Name = "btn_toWorkers";
            this.btn_toWorkers.Size = new System.Drawing.Size(181, 178);
            this.btn_toWorkers.TabIndex = 3;
            this.btn_toWorkers.Visible = false;
            this.btn_toWorkers.Click += new System.EventHandler(this.btn_toWorkers_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(1152, 423);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 26);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "职工管理";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.uiLabel5);
            this.groupBox1.Controls.Add(this.uiLabel4);
            this.groupBox1.Controls.Add(this.uiLabel3);
            this.groupBox1.Controls.Add(this.uiLabel2);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.btn_toAddPrescription);
            this.groupBox1.Controls.Add(this.btn_toPrescription);
            this.groupBox1.Controls.Add(this.btn_toWorkers);
            this.groupBox1.Controls.Add(this.btn_toSupplier);
            this.groupBox1.Controls.Add(this.btn_toDrugs);
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1516, 661);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 807);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_userPower);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_returnMain);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Frm_Main";
            this.Text = "Frm_Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Admin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private Sunny.UI.UIButton btn_returnMain;
        private Sunny.UI.UIButton btn_logOut;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel lbl_userPower;
        private Sunny.UI.UILabel lbl_userName;
        private System.Windows.Forms.Button btn_toPrescription;
        private System.Windows.Forms.Button btn_toDrugs;
        private System.Windows.Forms.Button btn_toSupplier;
        private System.Windows.Forms.Button btn_toAddPrescription;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.Button btn_toWorkers;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}