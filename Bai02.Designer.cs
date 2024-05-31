namespace _22521100_Lab4
{
    partial class Bai02
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
            btn_download = new Button();
            tb_url = new TextBox();
            tb_save = new TextBox();
            rtb_Response = new RichTextBox();
            SuspendLayout();
            // 
            // btn_download
            // 
            btn_download.Location = new Point(486, 33);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(98, 63);
            btn_download.TabIndex = 0;
            btn_download.Text = "Download";
            btn_download.UseVisualStyleBackColor = true;
            btn_download.Click += btn_download_Click;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(28, 33);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(404, 23);
            tb_url.TabIndex = 1;
            // 
            // tb_save
            // 
            tb_save.Location = new Point(28, 73);
            tb_save.Name = "tb_save";
            tb_save.Size = new Size(404, 23);
            tb_save.TabIndex = 2;
            // 
            // rtb_Response
            // 
            rtb_Response.Location = new Point(28, 127);
            rtb_Response.Name = "rtb_Response";
            rtb_Response.Size = new Size(556, 297);
            rtb_Response.TabIndex = 3;
            rtb_Response.Text = "";
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 453);
            Controls.Add(rtb_Response);
            Controls.Add(tb_save);
            Controls.Add(tb_url);
            Controls.Add(btn_download);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_download;
        private TextBox tb_url;
        private TextBox tb_save;
        private RichTextBox rtb_Response;
    }
}