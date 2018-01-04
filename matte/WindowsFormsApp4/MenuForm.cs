using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp4
{
    public partial class MenuForm : Form
    {

        WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public MenuForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wplayer.URL = "start.mp3";


            // Save the choosen operators to be used
            List<Operator> operatorList = new List<Operator>();
            if (checkBoxMinus.Checked)
                operatorList.Add(Operator.MINUS);
            if (checkBoxPlus.Checked)
                operatorList.Add(Operator.PLUS);
            if (checkBoxMulti.Checked)
                operatorList.Add(Operator.MULT);
            if (checkBoxDiv.Checked)
                operatorList.Add(Operator.DIV);

            MainForm mainform = new MainForm(Int32.Parse(lblAntal.Text), Int32.Parse(lblLevel.Text), operatorList);
            this.Hide();
            mainform.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            wplayer.URL = "click.mp3";
            wplayer.controls.play();
        }

        private void trackBarLevel_Scroll(object sender, EventArgs e)
        {
            wplayer.URL = "click.mp3";
            wplayer.controls.play();
            lblLevel.Text = trackBarLevel.Value.ToString();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void trackBarAntal_Scroll(object sender, EventArgs e)
        {
            wplayer.URL = "click.mp3";
            wplayer.controls.play();
            lblAntal.Text = trackBarAntal.Value.ToString();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPlus_CheckedChanged(object sender, EventArgs e)
        {
            wplayer.URL = "click.mp3";
            wplayer.controls.play();
        }

        private void checkBoxMinus_CheckedChanged(object sender, EventArgs e)
        {
            wplayer.URL = "click.mp3";
            wplayer.controls.play();
        }

        private void checkBoxDiv_CheckedChanged(object sender, EventArgs e)
        {
            wplayer.URL = "click.mp3";
            wplayer.controls.play();
        }
    }
}
