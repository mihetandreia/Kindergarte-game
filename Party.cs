using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace HappyTeamProject
{
    public partial class Party : Form
    {
        public Party()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Drums;
            splayer.Play();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new Petrecere();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();

        }

        private void Party_Load(object sender, EventArgs e)
        {

        }
    }
}
