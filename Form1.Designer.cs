namespace BadgeAward
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
            lblPoints = new Label();
            DeductPoints = new Button();
            GivePoints = new Button();
            BadgeAwardBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BadgeAwardBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.ForeColor = SystemColors.ControlText;
            lblPoints.Location = new Point(391, 137);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(15, 15);
            lblPoints.TabIndex = 0;
            lblPoints.Text = "A";
            lblPoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeductPoints
            // 
            DeductPoints.Location = new Point(486, 251);
            DeductPoints.Name = "DeductPoints";
            DeductPoints.Size = new Size(75, 23);
            DeductPoints.TabIndex = 1;
            DeductPoints.Text = "Remove";
            DeductPoints.UseVisualStyleBackColor = true;
            DeductPoints.Click += DeductPoints_Click;
            // 
            // GivePoints
            // 
            GivePoints.Location = new Point(189, 251);
            GivePoints.Name = "GivePoints";
            GivePoints.Size = new Size(75, 23);
            GivePoints.TabIndex = 2;
            GivePoints.Text = "Give";
            GivePoints.UseVisualStyleBackColor = true;
            GivePoints.Click += GivePoints_Click;
            // 
            // BadgeAwardBox1
            // 
            BadgeAwardBox1.Location = new Point(412, 121);
            BadgeAwardBox1.Name = "BadgeAwardBox1";
            BadgeAwardBox1.Size = new Size(52, 50);
            BadgeAwardBox1.SizeMode = PictureBoxSizeMode.Zoom;
            BadgeAwardBox1.TabIndex = 3;
            BadgeAwardBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BadgeAwardBox1);
            Controls.Add(GivePoints);
            Controls.Add(DeductPoints);
            Controls.Add(lblPoints);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)BadgeAwardBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPoints;
        private Button DeductPoints;
        private Button GivePoints;
        private PictureBox BadgeAwardBox1;
    }
}
