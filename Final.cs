using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace HappyTeamProject
{
    public partial class Final : Form
    {
        private System.Windows.Forms.Timer tmr;

        public Final()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Surpriza;
            splayer.Play();
            
            //tmr = new System.Windows.Forms.Timer();
           // tmr.Tick += delegate {
           //     this.Close();
           // };
            //tmr.Interval = (int)TimeSpan.FromMinutes(300).TotalSeconds;
           // tmr.Start();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new Party();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();

        }

        private void Final_Load(object sender, EventArgs e)
        {

        }
    }
}
