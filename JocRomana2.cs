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
    public partial class JocRomana2 : Form
    {
        public JocRomana2()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Veve;
            splayer.Play();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Barza_Click(object sender, EventArgs e)
        {
            SadBarza.Visible = true;
        }

        private void Vrabie_Click(object sender, EventArgs e)
        {
            SadVrabie.Visible = true;
        }

        private void Randunica_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new Final();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();
        }

        private void ReadFairy_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Veve;
            splayer.Play();
        }

        private void JocRomana2_Load(object sender, EventArgs e)
        {

        }
    }
}
