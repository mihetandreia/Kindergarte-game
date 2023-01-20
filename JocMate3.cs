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
    public partial class JocMate3 : Form
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
        public JocMate3()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.Pitici;
            splayer.Load();
            splayer.Play();
        }
        //7
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox6);
          
            SoundPlayer splayer1 = new SoundPlayer();
            splayer1.Stream = Properties.Resources.Ok;
            splayer1.Load();
            splayer1.Play();
 
            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);


            option = true;
        }

        //6
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox5);
           
            SoundPlayer splayer2 = new SoundPlayer();
            splayer2.Stream = Properties.Resources.NotOk;
            splayer2.Load();
            splayer2.Play();

            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);

            option = true;
        }

        //8
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox5);
           
            SoundPlayer splayer3 = new SoundPlayer();
            splayer3.Stream = Properties.Resources.NotOk;
            splayer3.Load();
            splayer3.Play();
 
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
                //this.Close();
                this.Hide();
                var next = new Trecere();
                next.Location = this.Location;
                next.StartPosition = FormStartPosition.Manual;
                next.ShowDialog();
                this.Close();

                option = false;
            }
        }

        private void JocMate3_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
