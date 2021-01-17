
namespace Drug_management_system
{
    partial class Frm_Login
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
            this.Button1 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txt_userName = new Sunny.UI.UITextBox();
            this.Button2 = new Sunny.UI.UIButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txt_userPassword = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button1.Location = new System.Drawing.Point(142, 204);
            this.Button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(95, 37);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "登录";
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(115, 63);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(86, 27);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "账号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_userName
            // 
            this.txt_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userName.FillColor = System.Drawing.Color.White;
            this.txt_userName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_userName.Location = new System.Drawing.Point(220, 56);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_userName.Maximum = 2147483647D;
            this.txt_userName.Minimum = -2147483648D;
            this.txt_userName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_userName.Size = new System.Drawing.Size(140, 34);
            this.txt_userName.TabIndex = 14;
            // 
            // Button2
            // 
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Button2.Location = new System.Drawing.Point(333, 204);
            this.Button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(95, 37);
            this.Button2.TabIndex = 15;
            this.Button2.Text = "退出";
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(115, 124);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(86, 27);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 16;
            this.uiLabel2.Text = "密码：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_userPassword
            // 
            this.txt_userPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userPassword.FillColor = System.Drawing.Color.White;
            this.txt_userPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_userPassword.Location = new System.Drawing.Point(220, 117);
            this.txt_userPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_userPassword.Maximum = 2147483647D;
            this.txt_userPassword.Minimum = -2147483648D;
            this.txt_userPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_userPassword.Name = "txt_userPassword";
            this.txt_userPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txt_userPassword.Size = new System.Drawing.Size(140, 34);
            this.txt_userPassword.TabIndex = 15;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(559, 307);
            this.Controls.Add(this.txt_userPassword);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(94)))));
            this.Name = "Frm_Login";
            this.Text = "登录信息";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton Button1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_userName;
        private Sunny.UI.UIButton Button2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_userPassword;
    }
}