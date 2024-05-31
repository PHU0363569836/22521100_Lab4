namespace _22521100_Lab4
{
    partial class Bai05
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
            btn_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_password = new TextBox();
            tb_url = new TextBox();
            tb_username = new TextBox();
            rtb_view = new RichTextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(483, 45);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(136, 125);
            btn_login.TabIndex = 0;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 48);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 155);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(149, 147);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(328, 23);
            tb_password.TabIndex = 4;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(149, 45);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(328, 23);
            tb_url.TabIndex = 5;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(149, 91);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(328, 23);
            tb_username.TabIndex = 6;
            // 
            // rtb_view
            // 
            rtb_view.Location = new Point(51, 210);
            rtb_view.Name = "rtb_view";
            rtb_view.Size = new Size(568, 222);
            rtb_view.TabIndex = 7;
            rtb_view.Text = "";
            // 
            // Bai05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 444);
            Controls.Add(rtb_view);
            Controls.Add(tb_username);
            Controls.Add(tb_url);
            Controls.Add(tb_password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Name = "Bai05";
            Text = "Bai05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_password;
        private TextBox tb_url;
        private TextBox tb_username;
        private RichTextBox rtb_view;
    }
}