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
    public partial class JocMate2 : Form
    {
        private bool option = false;
        private static void Make_visible(List<Control> widgets)
        {
            foreach (Control obj in widgets)
            {
                obj.Visible = true;
            }
        }

        private static void Make_invisible(List<Control> widgets)
        {
            foreach (Control obj in widgets)
            {
                obj.Visible = false;
            }
        }
        public JocMate2()
        {
            InitializeComponent(); 
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Strumfi;
            splayer.Load();
            splayer.Play();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
       
        //0
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox5);
           
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.NotOk;
            splayer.Load();
            splayer.Play();
     

            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);

            option = true;
        }

        //4
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox5);
  
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.NotOk;
            splayer.Load();
            splayer.Play();

            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);

            option = true;
        }

        //3
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox6);
 
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Ok;
            splayer.Load();
            splayer.Play();

            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);

            option = true;
        }

        //sad flower
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                List<Control> widgets = new List<Control>();

                widgets.Add(pictureBox5);
                Make_invisible(widgets);

                List<Control> visWidgets = new List<Control>();
                visWidgets.Add(pictureBox4);
                visWidgets.Add(pictureBox3);
                visWidgets.Add(pictureBox2);
                Make_visible(visWidgets);

                option = false;
            }
        }

        //happy flower
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                var next = new JocMate3();
                this.Hide();
                next.Location = this.Location;
                next.StartPosition = FormStartPosition.Manual;
                //next.FormClosing += delegate { this.Show(); };
                next.ShowDialog();
                this.Close();

                option = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void JocMate2_Load(object sender, EventArgs e)
        {

        }
    }
}
