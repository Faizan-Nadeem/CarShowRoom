namespace CarShowRoom
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.FromArgb(27, 60, 83);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 45);
            label1.TabIndex = 1;
            label1.Text = "NAPAK WHEELS SHOWROOM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(27, 60, 83);
            label2.Location = new Point(47, 478);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 2;
            label2.Text = "Progress........";
            label2.Click += label2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(47, 525);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(828, 18);
            progressBar1.TabIndex = 3;
            // 
            // splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(930, 573);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
    }
}
