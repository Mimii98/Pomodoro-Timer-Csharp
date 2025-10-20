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
            BtnStart.BackColor = Color.Transparent;
            BtnStart.FlatStyle = FlatStyle.Popup;
            BtnStart.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStart.ForeColor = Color.BurlyWood;
            BtnStart.Location = new Point(9, 121);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(94, 58);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = false;
            BtnStart.Click += BtnStart_Click;
            // 
            // lbl
            // 
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(9, 11);
            lbl.Name = "lbl";
            lbl.Size = new Size(179, 87);
            lbl.TabIndex = 3;
            lbl.Text = "00:00";
            lbl.TextAlign = ContentAlignment.TopCenter;
            lbl.Click += lbl_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Transparent;
            btnreset.FlatStyle = FlatStyle.Popup;
            btnreset.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreset.ForeColor = Color.Tan;
            btnreset.Location = new Point(111, 121);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(94, 58);
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
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(43, 98);
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
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(213, 191);
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
