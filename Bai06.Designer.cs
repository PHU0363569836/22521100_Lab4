namespace _22521100_Lab4
{
    partial class Bai06
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
            btn_get = new Button();
            label1 = new Label();
            label2 = new Label();
            tb_token = new TextBox();
            tb_url = new TextBox();
            rtb_view = new RichTextBox();
            SuspendLayout();
            // 
            // btn_get
            // 
            btn_get.Location = new Point(489, 39);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(75, 64);
            btn_get.TabIndex = 0;
            btn_get.Text = "Get";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 39);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 1;
            label1.Text = "Url";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 80);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "token";
            // 
            // tb_token
            // 
            tb_token.Location = new Point(134, 80);
            tb_token.Name = "tb_token";
            tb_token.Size = new Size(318, 23);
            tb_token.TabIndex = 3;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(134, 39);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(318, 23);
            tb_url.TabIndex = 4;
            // 
            // rtb_view
            // 
            rtb_view.Location = new Point(57, 144);
            rtb_view.Name = "rtb_view";
            rtb_view.Size = new Size(507, 286);
            rtb_view.TabIndex = 5;
            rtb_view.Text = "";
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 455);
            Controls.Add(rtb_view);
            Controls.Add(tb_url);
            Controls.Add(tb_token);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_get);
            Name = "Bai06";
            Text = "Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_get;
        private Label label1;
        private Label label2;
        private TextBox tb_token;
        private TextBox tb_url;
        private RichTextBox rtb_view;
    }
}