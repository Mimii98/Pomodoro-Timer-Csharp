namespace WinFormsApp1
{
    partial class TimerBox
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerBox));
            BtnStart = new Button();
            lbl = new Label();
            btnreset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl2 = new Label();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.BackColor = Color.RosyBrown;
            BtnStart.BackgroundImage = Timer.Properties.Resources._20250306_215610;
            BtnStart.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStart.Image = Timer.Properties.Resources._20250306_215610;
            BtnStart.Location = new Point(9, 144);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(94, 54);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = false;
            BtnStart.Click += BtnStart_Click;
            // 
            // lbl
            // 
            lbl.BackColor = Color.RosyBrown;
            lbl.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Image = Timer.Properties.Resources._20250306_215610;
            lbl.Location = new Point(9, 11);
            lbl.Name = "lbl";
            lbl.Size = new Size(196, 87);
            lbl.TabIndex = 3;
            lbl.Text = "00:00";
            lbl.TextAlign = ContentAlignment.TopCenter;
            lbl.Click += lbl_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.RosyBrown;
            btnreset.BackgroundImage = Timer.Properties.Resources._20250306_215610;
            btnreset.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreset.Image = Timer.Properties.Resources._20250306_215610;
            btnreset.Location = new Point(111, 144);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(94, 54);
            btnreset.TabIndex = 4;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Image = Timer.Properties.Resources._20250306_215610;
            lbl2.Location = new Point(29, 112);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(119, 20);
            lbl2.TabIndex = 5;
            lbl2.Text = "Work Time :3";
            lbl2.Click += lbl2_Click;
            // 
            // TimerBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(213, 210);
            Controls.Add(lbl2);
            Controls.Add(btnreset);
            Controls.Add(lbl);
            Controls.Add(BtnStart);
            Margin = new Padding(2);
            Name = "TimerBox";
            Text = "Promodoro Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnStart;
        private Label lbl;
        private Button btnreset;
        private System.Windows.Forms.Timer timer1;
        private Label lbl2;
    }
}
