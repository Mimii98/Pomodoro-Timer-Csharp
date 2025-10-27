using System.Media; // für Sound
using System.Threading; // wird hier im code nicht benutzt 
using System.Timers; // wird hier im code nicht benutzt
using System.Windows.Forms; // für Windows Forms
namespace WinFormsApp1 // Namespace des Projekts
{
    public partial class TimerBox : Form // Hauptklasse des Formulars
    {
        // Klassenvariablen
        public TimeSpan timeleft; 
        public TimeSpan breaktime;
        bool Isactive = true;
        SoundPlayer breaksound = new SoundPlayer(@"Resources\315694__acollier123__casio-1000p-preset-piano-c.wav"); // Pfad zum Sound für die Pause
        SoundPlayer worksound = new SoundPlayer(@"Resources\346956__alexlancemx__si_bemol_tone_2016.wav"); // Pfad zum Sound für die Arbeitszeit

        public TimerBox() // Konstruktor der Klasse
        {
            InitializeComponent(); // Lädt die Komponenten des Formulars
            worksound.Load(); // Lädt den Arbeitszeit-Sound
            breaksound.Load(); // Lädt den Pausen-Sound
            this.TopMost = true; // Setzt das Formular immer im Vordergrund
        }

        private void BtnStart_Click(object sender, EventArgs e) // Ereignishandler für den Start-Button
        {

            timer1.Start(); // Startet den Timer
            breaksound.Play(); // Spielt den Pausensound ab
            this.timeleft = new TimeSpan(0, 0, 10); // Setzt die Arbeitszeit auf 25 Minuten
            this.breaktime = new TimeSpan(0, 0, 5); // Setzt die Pausenzeit auf 5 Minuten

        }

        private void btnreset_Click(object sender, EventArgs e) // Ereignishandler für den Reset-Button
        {
          
            timer1.Stop(); // Stopt den Timer
            lbl.Text = "00:00"; // Setzt das Label auf 00:00 zurück

        }

        private void timer1_Tick(object sender, EventArgs e) // Ereignishandler für den Timer-Tick
        {
            if (Isactive) // Wenn die Arbeitszeit aktiv ist
            {
                timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1)); // Zieht eine Sekunde von der verbleibenden Zeit ab
                lbl.Text = timeleft.ToString(@"mm\:ss"); // Aktualisiert das Label mit der verbleibenden Zeit
                if (timeleft.TotalSeconds <= 0) // Wenn die Zeit abgelaufen ist
                {
                        Isactive = false; // Wechselt zur Pausenzeit
                        timeleft = breaktime; // Setzt die verbleibende Zeit auf die Pausenzeit
                        breaksound.Play(); // Spielt den Pausensound ab
                        lbl2.Text = "Break Time! yey :3"; // Aktualisiert das Label mit der Pausenmeldung
                }
            }
            else // Wenn die Pausenzeit aktiv ist
            {
                timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1)); // Zieht eine Sekunde von der verbleibenden Zeit ab
                lbl.Text = timeleft.ToString(@"mm\:ss"); // Aktualisiert das Label mit der verbleibenden Zeit
                if (timeleft.TotalSeconds <= 0) // Wenn die Zeit abgelaufen ist
                {
                       Isactive = true; // Wechselt zur Arbeitszeit
                       timeleft = new TimeSpan(0, 0, 10); // Setzt die verbleibende Zeit auf die Arbeitszeit
                       worksound.Play(); // Spielt den Arbeitszeit-Sound ab
                       lbl2.Text = "Work Time! :>"; // Aktualisiert das Label mit der Arbeitszeitmeldung
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
