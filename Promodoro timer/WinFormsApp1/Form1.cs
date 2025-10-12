using System.Threading;
using System.Timers;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class TimerBox : Form
    {
        public TimeSpan timeleft;
        public TimeSpan breaktime;
        bool IsBreak = false;
        public TimerBox()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            timer1.Start();
           
            this.timeleft = new TimeSpan(0, 0, 10);
            this.breaktime = new TimeSpan(0, 0, 5);
           
          

           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            //fertig
            timer1.Stop();
            lbl.Text = "00:00";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            lbl.Text = timeleft.ToString(@"mm\:ss");
            IsBreak = false;

            if (breaktime.TotalSeconds == 0 && IsBreak == false) 
            {
                timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
                lbl.Text = timeleft.ToString(@"mm\:ss");
                IsBreak = true;

            }
            if (timeleft.TotalSeconds == 0 && IsBreak == true)
            {
              breaktime = breaktime.Subtract(TimeSpan.FromSeconds(1));
              lbl.Text = breaktime.ToString(@"mm\:ss");
              IsBreak = false;
            }


            


        }
            
                

            
















        private void lbl2_Click(object sender, EventArgs e)
        {
            // Unnötige Methode für dieses Projekt 
        }
        private void lbl_Click(object sender, EventArgs e)
        {
            // Unnötige Methode für dieses Projekt 
        }
    }
}
