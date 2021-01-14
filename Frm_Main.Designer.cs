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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_returnMain = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_toLogin = new System.Windows.Forms.Button();
            this.btn_toPrescription = new System.Windows.Forms.Button();
            this.btn_toWorkers = new System.Windows.Forms.Button();
            this.btn_toDrugs = new System.Windows.Forms.Button();
            this.btn_toSupplier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1517, 142);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_returnMain
            // 
            this.btn_returnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_returnMain.Location = new System.Drawing.Point(1240, 74);
            this.btn_returnMain.Name = "btn_returnMain";
            this.btn_returnMain.Size = new System.Drawing.Size(103, 35);
            this.btn_returnMain.TabIndex = 3;
            this.btn_returnMain.Text = "返回主页";
            this.btn_returnMain.UseVisualStyleBackColor = true;
            this.btn_returnMain.Click += new System.EventHandler(this.btn_returnMain_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logOut.Location = new System.Drawing.Point(1389, 74);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(102, 35);
            this.btn_logOut.TabIndex = 4;
            this.btn_logOut.Text = "退出登录";
            this.btn_logOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前用户：XXX";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1346, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "权限：管理员";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_toLogin);
            this.groupBox1.Controls.Add(this.btn_toPrescription);
            this.groupBox1.Controls.Add(this.btn_toWorkers);
            this.groupBox1.Controls.Add(this.btn_toDrugs);
            this.groupBox1.Controls.Add(this.btn_toSupplier);
            this.groupBox1.Location = new System.Drawing.Point(0, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1517, 652);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btn_toLogin
            // 
            this.btn_toLogin.Location = new System.Drawing.Point(849, 170);
            this.btn_toLogin.Name = "btn_toLogin";
            this.btn_toLogin.Size = new System.Drawing.Size(134, 52);
            this.btn_toLogin.TabIndex = 7;
            this.btn_toLogin.Text = "用户管理";
            this.btn_toLogin.UseVisualStyleBackColor = true;
            this.btn_toLogin.Click += new System.EventHandler(this.btn_toLogin_Click);
            // 
            // btn_toPrescription
            // 
            this.btn_toPrescription.Location = new System.Drawing.Point(455, 316);
            this.btn_toPrescription.Name = "btn_toPrescription";
            this.btn_toPrescription.Size = new System.Drawing.Size(134, 52);
            this.btn_toPrescription.TabIndex = 4;
            this.btn_toPrescription.Text = "处方管理";
            this.btn_toPrescription.UseVisualStyleBackColor = true;
            this.btn_toPrescription.Click += new System.EventHandler(this.btn_toPrescription_Click);
            // 
            // btn_toWorkers
            // 
            this.btn_toWorkers.Location = new System.Drawing.Point(658, 316);
            this.btn_toWorkers.Name = "btn_toWorkers";
            this.btn_toWorkers.Size = new System.Drawing.Size(134, 52);
            this.btn_toWorkers.TabIndex = 3;
            this.btn_toWorkers.Text = "职工管理";
            this.btn_toWorkers.UseVisualStyleBackColor = true;
            this.btn_toWorkers.Click += new System.EventHandler(this.btn_toWorkers_Click);
            // 
            // btn_toDrugs
            // 
            this.btn_toDrugs.Location = new System.Drawing.Point(658, 170);
            this.btn_toDrugs.Name = "btn_toDrugs";
            this.btn_toDrugs.Size = new System.Drawing.Size(134, 52);
            this.btn_toDrugs.TabIndex = 1;
            this.btn_toDrugs.Text = "药品管理";
            this.btn_toDrugs.UseVisualStyleBackColor = true;
            this.btn_toDrugs.Click += new System.EventHandler(this.btn_toDrugs_Click);
            // 
            // btn_toSupplier
            // 
            this.btn_toSupplier.Location = new System.Drawing.Point(455, 170);
            this.btn_toSupplier.Name = "btn_toSupplier";
            this.btn_toSupplier.Size = new System.Drawing.Size(134, 52);
            this.btn_toSupplier.TabIndex = 0;
            this.btn_toSupplier.Text = "供货商管理";
            this.btn_toSupplier.UseVisualStyleBackColor = true;
            this.btn_toSupplier.Click += new System.EventHandler(this.btn_toSupplier_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 807);
            this.Controls.Add(this.groupBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button btn_returnMain;
        private System.Windows.Forms.Button btn_logOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_toLogin;
        private System.Windows.Forms.Button btn_toPrescription;
        private System.Windows.Forms.Button btn_toWorkers;
        private System.Windows.Forms.Button btn_toDrugs;
        private System.Windows.Forms.Button btn_toSupplier;
    }
}