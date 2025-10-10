using System.Threading;
using System.Timers;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class TimerBox : Form
    {
        public TimeSpan timeleft;
        public TimeSpan breaktime;

        public TimerBox()
        {
            InitializeComponent();
           
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
             TimeSpan timeleft = new TimeSpan(0,0, 10);
             lbl.Text = timeleft.ToString(@"mm\:ss");
             timer1.Start();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            lbl.Text = timeleft.ToString(@"mm\:ss");

            if (timeleft.TotalSeconds <= 0) 
            {
                timeleft.Stop();
                
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
