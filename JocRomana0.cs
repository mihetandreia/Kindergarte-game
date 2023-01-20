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
    public partial class JocRomana0 : Form
    {
        public JocRomana0()
        {
            InitializeComponent();
            SoundPlayer splayer1 = new SoundPlayer();
            splayer1.Stream = Properties.Resources.Mac;
            splayer1.Load();
            splayer1.Play();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            //splayer.Stream = Properties.Resources.Primavara;
            splayer.Stream = Properties.Resources.Mac;
            splayer.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SadFall.Visible = true;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void WinterFairy_Click(object sender, EventArgs e)
        {
            SadWinter.Visible = true;
        }

        private void SpringFairy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new JocRomana1();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();
        }
    }
}
