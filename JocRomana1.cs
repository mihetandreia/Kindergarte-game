﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace HappyTeamProject
{
    public partial class JocRomana1 : Form
    {
        public JocRomana1()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Urs;
            splayer.Play();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lalea_Click(object sender, EventArgs e)
        {
            SadLalea.Visible = true;
        }

        private void Ghiocel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new JocRomana2();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();
        }

        private void Zambila_Click(object sender, EventArgs e)
        {
            SadZambila.Visible = true;
        }

        private void ReadFairy_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Urs;
            splayer.Play();
        }

        private void JocRomana1_Load(object sender, EventArgs e)
        {

        }
    }
}
