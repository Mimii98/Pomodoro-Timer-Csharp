using System.Media;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Media;
namespace WinFormsApp1
{
    public partial class TimerBox : Form
    {
        public TimeSpan timeleft;
        public TimeSpan breaktime;
        bool Isactive = true;
        SoundPlayer breaksound = new SoundPlayer(@"Resources\315694__acollier123__casio-1000p-preset-piano-c.wav");
        SoundPlayer worksound = new SoundPlayer(@"Resources\346956__alexlancemx__si_bemol_tone_2016.wav");
        public TimerBox()
        {
            InitializeComponent();
            worksound.Load();
            breaksound.Load();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            timer1.Start();
            this.timeleft = new TimeSpan(0, 25, 0);
            this.breaktime = new TimeSpan(0, 5, 0);
           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            //fertig
            timer1.Stop();
            lbl.Text = "00:00";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Isactive)
            {
                 timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
                 lbl.Text = timeleft.ToString(@"mm\:ss");
                 if (timeleft.TotalSeconds <= 0)
                 {
                        Isactive = false;
                        timeleft = breaktime;
                        SystemSounds.Asterisk.Play();
                        breaksound.Play();
                        lbl2.Text = "Break Time! yey :3";
                 }
            }
            else
            {
                timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
                lbl.Text = timeleft.ToString(@"mm\:ss");
                if (timeleft.TotalSeconds <= 0)
                {
                       Isactive = true;
                       timeleft = new TimeSpan(0, 25, 0);
                       SystemSounds.Exclamation.Play();
                       worksound.Play();
                       lbl2.Text = "Work Time! :>";
                }
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
