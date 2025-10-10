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

        private void lbl_Click(object sender, EventArgs e)
        {
            // Unnötige Methode für dieses Projekt 
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
          

        }

        private void btnreset_Click(object sender, EventArgs e)
        {


        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             TimeSpan timeleft = new TimeSpan(0, 25, 0);
             TimerBox.Text = TimerBox.ToString(@"mm\:ss");
             timeleft = timeleft.Add(TimeSpan.FromSeconds(-1));




        }
    }
}
