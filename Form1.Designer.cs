namespace _22521100_Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_bai01 = new Button();
            btn_bai02 = new Button();
            btn_bai05 = new Button();
            btn_bai06 = new Button();
            SuspendLayout();
            // 
            // btn_bai01
            // 
            btn_bai01.Location = new Point(185, 82);
            btn_bai01.Name = "btn_bai01";
            btn_bai01.Size = new Size(75, 23);
            btn_bai01.TabIndex = 0;
            btn_bai01.Text = "Bài 1";
            btn_bai01.UseVisualStyleBackColor = true;
            btn_bai01.Click += btn_bai01_Click;
            // 
            // btn_bai02
            // 
            btn_bai02.Location = new Point(387, 82);
            btn_bai02.Name = "btn_bai02";
            btn_bai02.Size = new Size(75, 23);
            btn_bai02.TabIndex = 1;
            btn_bai02.Text = "Bài 2";
            btn_bai02.UseVisualStyleBackColor = true;
            btn_bai02.Click += btn_bai02_Click;
            // 
            // btn_bai05
            // 
            btn_bai05.Location = new Point(185, 237);
            btn_bai05.Name = "btn_bai05";
            btn_bai05.Size = new Size(75, 23);
            btn_bai05.TabIndex = 4;
            btn_bai05.Text = "Bài 5";
            btn_bai05.UseVisualStyleBackColor = true;
            btn_bai05.Click += btn_bai05_Click;
            // 
            // btn_bai06
            // 
            btn_bai06.Location = new Point(387, 237);
            btn_bai06.Name = "btn_bai06";
            btn_bai06.Size = new Size(75, 23);
            btn_bai06.TabIndex = 5;
            btn_bai06.Text = "Bài 6";
            btn_bai06.UseVisualStyleBackColor = true;
            btn_bai06.Click += btn_bai06_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 425);
            Controls.Add(btn_bai06);
            Controls.Add(btn_bai05);
            Controls.Add(btn_bai02);
            Controls.Add(btn_bai01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_bai01;
        private Button btn_bai02;
        private Button btn_bai05;
        private Button btn_bai06;
    }
}
