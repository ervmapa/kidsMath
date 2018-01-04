using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp4
{

    public partial class ScoreForm : Form
    {
        WindowsMediaPlayer wplayer;
        int tid = 0;

        public ScoreForm()
        {
            InitializeComponent();
                
            Init();
        }

        public void Init()
        {
            timer1.Enabled = true;
            StartPosition = FormStartPosition.CenterScreen;

            wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "sucess1.mp3";
            wplayer.controls.play();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            tid++;
            if (tid > 5)
            {
                timer1.Enabled = false;
                wplayer.controls.stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
