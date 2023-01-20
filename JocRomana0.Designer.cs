
namespace HappyTeamProject
{
    partial class JocRomana0
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JocRomana0));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ReadFairy = new System.Windows.Forms.PictureBox();
            this.SpringFairy = new System.Windows.Forms.PictureBox();
            this.FallFairy = new System.Windows.Forms.PictureBox();
            this.WinterFairy = new System.Windows.Forms.PictureBox();
            this.SadWinter = new System.Windows.Forms.PictureBox();
            this.SadFall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReadFairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpringFairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FallFairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinterFairy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SadWinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SadFall)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadFairy
            // 
            this.ReadFairy.BackColor = System.Drawing.Color.Transparent;
            this.ReadFairy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReadFairy.BackgroundImage")));
            this.ReadFairy.Image = ((System.Drawing.Image)(resources.GetObject("ReadFairy.Image")));
            this.ReadFairy.Location = new System.Drawing.Point(207, 206);
            this.ReadFairy.Name = "ReadFairy";
            this.ReadFairy.Size = new System.Drawing.Size(332, 504);
            this.ReadFairy.TabIndex = 0;
            this.ReadFairy.TabStop = false;
            this.ReadFairy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SpringFairy
            // 
            this.SpringFairy.BackColor = System.Drawing.Color.Transparent;
            this.SpringFairy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpringFairy.BackgroundImage")));
            this.SpringFairy.Image = ((System.Drawing.Image)(resources.GetObject("SpringFairy.Image")));
            this.SpringFairy.Location = new System.Drawing.Point(851, 10);
            this.SpringFairy.Name = "SpringFairy";
            this.SpringFairy.Size = new System.Drawing.Size(301, 334);
            this.SpringFairy.TabIndex = 2;
            this.SpringFairy.TabStop = false;
            this.SpringFairy.Click += new System.EventHandler(this.SpringFairy_Click);
            // 
            // FallFairy
            // 
            this.FallFairy.BackColor = System.Drawing.Color.White;
            this.FallFairy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FallFairy.BackgroundImage")));
            this.FallFairy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FallFairy.Image = global::HappyTeamProject.Properties.Resources.pisica;
            this.FallFairy.Location = new System.Drawing.Point(851, 366);
            this.FallFairy.Name = "FallFairy";
            this.FallFairy.Size = new System.Drawing.Size(301, 283);
            this.FallFairy.TabIndex = 3;
            this.FallFairy.TabStop = false;
            this.FallFairy.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // WinterFairy
            // 
            this.WinterFairy.BackColor = System.Drawing.Color.White;
            this.WinterFairy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WinterFairy.BackgroundImage")));
            this.WinterFairy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WinterFairy.Location = new System.Drawing.Point(851, 667);
            this.WinterFairy.Name = "WinterFairy";
            this.WinterFairy.Size = new System.Drawing.Size(301, 244);
            this.WinterFairy.TabIndex = 3;
            this.WinterFairy.TabStop = false;
            this.WinterFairy.Click += new System.EventHandler(this.WinterFairy_Click);
            // 
            // SadWinter
            // 
            this.SadWinter.BackColor = System.Drawing.Color.Transparent;
            this.SadWinter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SadWinter.BackgroundImage")));
            this.SadWinter.Location = new System.Drawing.Point(1193, 712);
            this.SadWinter.Name = "SadWinter";
            this.SadWinter.Size = new System.Drawing.Size(131, 132);
            this.SadWinter.TabIndex = 7;
            this.SadWinter.TabStop = false;
            this.SadWinter.Visible = false;
            // 
            // SadFall
            // 
            this.SadFall.BackColor = System.Drawing.Color.Transparent;
            this.SadFall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SadFall.BackgroundImage")));
            this.SadFall.Location = new System.Drawing.Point(1194, 422);
            this.SadFall.Name = "SadFall";
            this.SadFall.Size = new System.Drawing.Size(130, 131);
            this.SadFall.TabIndex = 9;
            this.SadFall.TabStop = false;
            this.SadFall.Visible = false;
            // 
            // JocRomana0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1353, 991);
            this.Controls.Add(this.SadFall);
            this.Controls.Add(this.SadWinter);
            this.Controls.Add(this.WinterFairy);
            this.Controls.Add(this.FallFairy);
            this.Controls.Add(this.SpringFairy);
            this.Controls.Add(this.ReadFairy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JocRomana0";
            this.Text = "JocRomana";
            ((System.ComponentModel.ISupportInitialize)(this.ReadFairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpringFairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FallFairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinterFairy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SadWinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SadFall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox ReadFairy;
        private System.Windows.Forms.PictureBox SpringFairy;
        private System.Windows.Forms.PictureBox FallFairy;
        private System.Windows.Forms.PictureBox WinterFairy;
        private System.Windows.Forms.PictureBox SadWinter;
        private System.Windows.Forms.PictureBox SadFall;
    }
}