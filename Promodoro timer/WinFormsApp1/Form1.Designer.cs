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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerBox));
            BtnStart = new Button();
            lbl1 = new Label();
            btnreset = new Button();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.BackColor = Color.RosyBrown;
            BtnStart.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStart.Image = Timer.Properties.Resources._20250306_215610;
            BtnStart.Location = new Point(12, 161);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(94, 54);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = false;
            // 
            // lbl1
            // 
            lbl1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Image = Timer.Properties.Resources._20250306_215610;
            lbl1.Location = new Point(12, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(196, 113);
            lbl1.TabIndex = 3;
            lbl1.Text = "Time ";
            lbl1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreset.Image = Timer.Properties.Resources._20250306_215610;
            btnreset.Location = new Point(114, 161);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(94, 54);
            btnreset.TabIndex = 4;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            // 
            // TimerBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(225, 219);
            Controls.Add(btnreset);
            Controls.Add(lbl1);
            Controls.Add(BtnStart);
            Margin = new Padding(2);
            Name = "TimerBox";
            Text = "Promodoro Timer";
            ResumeLayout(false);
        }

        #endregion
        private Button BtnStart;
        private Label lbl1;
        private Button btnreset;
    }
}
