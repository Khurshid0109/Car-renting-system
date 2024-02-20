namespace Car_rental_system
{
    partial class InitialForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            MyProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            Percentage = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            MyProgress.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Red;
            guna2CirclePictureBox1.Cursor = Cursors.SizeWE;
            guna2CirclePictureBox1.FillColor = Color.RoyalBlue;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(76, 91);
            guna2CirclePictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(195, 190);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.Controls.Add(Percentage);
            MyProgress.Controls.Add(guna2CirclePictureBox1);
            MyProgress.FillColor = Color.Red;
            MyProgress.FillThickness = 12;
            MyProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MyProgress.ForeColor = Color.White;
            MyProgress.Location = new Point(216, 85);
            MyProgress.Margin = new Padding(3, 4, 3, 4);
            MyProgress.Minimum = 0;
            MyProgress.Name = "MyProgress";
            MyProgress.ProgressColor = Color.Black;
            MyProgress.ProgressColor2 = Color.Black;
            MyProgress.ProgressThickness = 8;
            MyProgress.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            MyProgress.Size = new Size(371, 371);
            MyProgress.TabIndex = 1;
            MyProgress.Text = "guna2CircleProgressBar1";
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Percentage.ForeColor = Color.Lime;
            Percentage.Location = new Point(131, 300);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(0, 40);
            Percentage.TabIndex = 3;
            Percentage.Click += Percentage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(216, 25);
            label1.Name = "label1";
            label1.Size = new Size(352, 40);
            label1.TabIndex = 2;
            label1.Text = "CAR RENTAL SYSTEM";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(842, 589);
            Controls.Add(label1);
            Controls.Add(MyProgress);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InitialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += InitialForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            MyProgress.ResumeLayout(false);
            MyProgress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar MyProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Percentage;
    }
}

