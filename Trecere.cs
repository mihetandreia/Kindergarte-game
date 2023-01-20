using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HappyTeamProject
{   

    public partial class Trecere : Form
    {
        private static void Make_visible(List<Control> widgets)
        {
            foreach (Control obj in widgets)
            {
                obj.Visible = true;
            }
        }

        public Trecere()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.IntroRo;
            splayer.Load();
            splayer.Play();
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox6);
            Make_visible(widgets);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new JocRomana0();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Trecere_Load(object sender, EventArgs e)
        {

        }
    }
}
