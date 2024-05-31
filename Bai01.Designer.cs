namespace _22521100_Lab4
{
    partial class Bai01
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
            tb_url = new TextBox();
            btn_Get = new Button();
            rtb_Response = new RichTextBox();
            SuspendLayout();
            // 
            // tb_url
            // 
            tb_url.Location = new Point(42, 27);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(421, 23);
            tb_url.TabIndex = 0;
            // 
            // btn_Get
            // 
            btn_Get.Location = new Point(480, 26);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(75, 23);
            btn_Get.TabIndex = 1;
            btn_Get.Text = "Get";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // rtb_Response
            // 
            rtb_Response.Location = new Point(42, 98);
            rtb_Response.Name = "rtb_Response";
            rtb_Response.Size = new Size(513, 289);
            rtb_Response.TabIndex = 2;
            rtb_Response.Text = "";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 414);
            Controls.Add(rtb_Response);
            Controls.Add(btn_Get);
            Controls.Add(tb_url);
            Name = "Bai01";
            Text = "Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_url;
        private Button btn_Get;
        private RichTextBox rtb_Response;
    }
}