using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace HappyTeamProject
{
    public partial class JocMate1 : Form
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
        public JocMate1()
        {
            InitializeComponent();
            SoundPlayer splayer = new SoundPlayer();
            splayer.Stream = Properties.Resources.IntroMate;
            splayer.Play();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        //8
        private void pictureBox4_Click(object sender, EventArgs e)
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

        //7
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

        //4
        private void pictureBox2_Click(object sender, EventArgs e)
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

        //sad face
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                List<Control> widgets = new List<Control>();
                
                widgets.Add(pictureBox5);
                Make_invisible(widgets);

                List<Control> visWidgets = new List<Control>();
               // 
                visWidgets.Add(pictureBox3);
                visWidgets.Add(pictureBox2);
                visWidgets.Add(pictureBox4);
                Make_visible(visWidgets);

                option = false;
            }
        }

        //happy face
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                var next = new JocMate2();
                this.Hide();
                next.Location = this.Location;
                next.StartPosition = FormStartPosition.Manual;
                next.ShowDialog();
                this.Close();

                option = false;
            }
        }


        private void JocMate1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void opt_hover(object sender, EventArgs e)
        {
            //SoundPlayer splayer = new SoundPlayer();
            //splayer.Stream = Properties.Resources.Opt;
           // splayer.Load();
            //splayer.Play();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
