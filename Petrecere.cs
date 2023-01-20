using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HappyTeamProject
{
    public partial class Petrecere : Form
    {
        public Petrecere()
        {
            InitializeComponent();
        }

        private void Petrecere_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = true;
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");
            axWindowsMediaPlayer1.URL = filePath + @"\Club.mp4";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new Form1();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
