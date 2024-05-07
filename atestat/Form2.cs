
using atestat.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace atestat
{
    public partial class Form2 : Form
    {

        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool goup = false;
        PictureBox[] pics = new PictureBox[10];
        PictureBox[] guard= new PictureBox[100];
        int[] ok = new int[10];
        int[] okg = new int[100];
        int i = 6, scor = 0, lc = 0, lmax = 0, score = 0;
        bool vizitat = false;
        int force = 6;
        int jumpspeed = 0;
        int cnt = 10;
        int cntg = 2;
        int nivel = 1;
        int nrguard = 1;
        bool mort = false;


        public Form2()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            pickey.BackColor = System.Drawing.Color.Transparent;
            lblsk.BackColor = System.Drawing.Color.Transparent;
            usaNivel.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)///lagul e de la background
        {
          
            for (int j = 1; j <= 6; j++)
                ok[j] = 1;
            pics[1] = new PictureBox();
            pics[1].Size = new Size(150, 20);
            pics[1].Location = new Point(0, 0);
            pics[1].BackColor = Color.Black;
            this.Controls.Add(pics[1]);
            pics[2] = new PictureBox();
            pics[2].Size = new Size(150, 20);
            pics[2].Location = new Point(200, 200);
            pics[2].BackColor = Color.Black;
            this.Controls.Add(pics[2]);
            pics[3] = new PictureBox();
            pics[3].Size = new Size(150, 20);
            pics[3].Location = new Point(250, 100);
            pics[3].BackColor = Color.Black;
            this.Controls.Add(pics[3]);
            pics[4] = new PictureBox();
            pics[4].Size = new Size(150, 20);
            pics[4].Location = new Point(300, 500);
            pics[4].BackColor = Color.Black;
            this.Controls.Add(pics[4]);
            pics[5] = new PictureBox();
            pics[5].Size = new Size(150, 20);
            pics[5].Location = new Point(200, 400);
            pics[5].BackColor = Color.Black;
            this.Controls.Add(pics[5]);
            pics[6] = new PictureBox();
            pics[6].Size = new Size(150, 20);
            pics[6].Location = new Point(100, 300);
            pics[6].BackColor = Color.Black;
            this.Controls.Add(pics[6]);
            for (int x = 1; x <= 6; x++)
                pics[x].Image = Properties.Resources.rafa;

            pics[1].Tag = "m";
            pics[3].Tag = "m";
            pics[5].Tag = "m";

            guard[nrguard] = new PictureBox();
            guard[nrguard].Size = new Size(52, 58);
            Random rnd1 = new Random();
            int xx1 = rnd1.Next(guard[nrguard].Width, 500 - guard[nrguard].Width);
            int yy1 = rnd1.Next(guard[nrguard].Height, 650 - 3 * guard[nrguard].Height);
            guard[nrguard].Location = new Point(xx1, yy1);
            guard[nrguard].Tag = "g";
            guard[nrguard].Image = Properties.Resources._890_8903649_prison_guard_prison_guard_pixel_art2;
            this.Controls.Add(guard[nrguard]);

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
        private async Task ShowNivelScreen()
        {
            // Create a new form to display the black screen
            Form blackScreenForm = new Form();
            blackScreenForm.FormBorderStyle = FormBorderStyle.None;
            blackScreenForm.BackColor = System.Drawing.Color.Black;
            blackScreenForm.StartPosition = FormStartPosition.CenterScreen;
            blackScreenForm.Size =new Size (500,650);

            // Create a label with the text "Nivel [nivel]"
            System.Windows.Forms.Label nivelLabel = new System.Windows.Forms.Label();
            nivelLabel.Text = "Nivelul " + nivel;
            nivelLabel.ForeColor = System.Drawing.Color.White;
            nivelLabel.Font = new System.Drawing.Font("Arial", 24);
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point((blackScreenForm.ClientSize.Width - nivelLabel.Width) / 2, (blackScreenForm.ClientSize.Height - nivelLabel.Height) / 2);
            blackScreenForm.Controls.Add(nivelLabel); 
            
            System.Windows.Forms.Label schimb= new System.Windows.Forms.Label();
            if (nivel % 5 == 0)
            {
                schimb.Text = "Pază sporită";
            }
            else
                schimb.Text = "Paza e în alertă";///schimb
            schimb.ForeColor = System.Drawing.Color.White;
            schimb.Font = new System.Drawing.Font("Arial", 24);
            schimb.AutoSize = true;
            schimb.Location = new System.Drawing.Point((blackScreenForm.ClientSize.Width - schimb.Width) / 2, (blackScreenForm.ClientSize.Height - schimb.Height) / 2+48);
            blackScreenForm.Controls.Add(schimb);

            // Show the black screen form
            blackScreenForm.Show();

            // Wait for 3 seconds
            await Task.Delay(1500);

            // Close the black screen form after 3 seconds
            blackScreenForm.Close();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pickey_Click(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            pics[1].Location = new Point(0, 0);
            pics[2].Location = new Point(200, 200);
            pics[3].Location = new Point(250, 100);
            pics[4].Location = new Point(300, 500);
            pics[5].Location = new Point(200, 400);
            pics[6].Location = new Point(100, 300);
            for (int i = 1; i <= 6; i++)
                pics[i].Visible = true;
            goleft = false;
            goright = false;
            jumping = false;
            goup = false;
            scor = 0;
           
            if (mort == true)
            {   
                score = 0;
                cntg = 2;
                for (int j = 2; j <= nrguard; j++)
                    this.Controls.Remove(guard[j]);
                nrguard = 1;
                nivel = 1;
            }
            
                for (int j=1;j<=nrguard;j++)///amestec gardianii 
                {
                    Random rnd = new Random();
                    int xx = rnd.Next(guard[j].Width, 500 - guard[j].Width);
                    int yy = rnd.Next(guard[j].Height, 650 - 3 * guard[j].Height);
                    guard[j].Location = new Point(xx, yy);
                }
            jumpspeed = 0;
            pickey.Location = new Point(205, 43);
            label1.Location = new Point(237, 563);
          
            vizitat = false;
            pickey.Visible = true;
            force = 6;
            jumpspeed = 0;
            lblsk.Text = "Ai eliberat " + score + " prizonieri";
            usaNivel.Visible = false;
            mort = false;
           
            timer1.Start();
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (((e.KeyCode == Keys.W) || ( e.KeyCode == Keys.Up)) && !jumping)
            {
                vizitat = false;
                jumping = true;
                goup = true;


            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goright = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int j = 1; j <= i; j++)///miscarea treptelor
            {
                if (pics[j].Tag == "m")///daca e treapta care se misca stanga dreapta
                {
                    
                    if (pics[j].Left < 500 - pics[j].Width && ok[j] == 1)///miscarea spre dreapta
                    {
                        if (label1.Bounds.IntersectsWith(pics[j].Bounds))///sa ma misc cu treapta miscatoare
                        {
                            label1.Left += cnt;
                            if (goleft == true && label1.Left > 0)
                                label1.Left -= 10;
                        }
                        pics[j].Left = pics[j].Left + cnt;
                        if (pics[j].Left >= 500 - pics[j].Width)
                            ok[j] = 0;
                    }
                    else if (ok[j] == 0)///miscarea spre stanga
                    {
                        if (label1.Bounds.IntersectsWith(pics[j].Bounds))
                        {
                            label1.Left -= cnt;
                            if (goright == true && label1.Left < 480 - label1.Width)
                                label1.Left += 10;
                        }
                        pics[j].Left -= cnt;
                        if (pics[j].Left <= 0)
                            ok[j] = 1;
                    }

                }
                
            }
            
            
            ///sa mi se miste guardu
            for (int j=1;j<=nrguard;j++)
            if (guard[j].Left < 500 - guard[j].Width && okg[j] == 1)
            {
                    guard[j].Left = guard[j].Left + cntg;
                if (guard[j].Left >= 500 - guard[j].Width)
                        okg[j] = 0;
            }
            else if (okg[j] == 0)
            {
                    guard[j].Left -= cntg;
                if (guard[j].Left <= 0)
                        okg[j] = 1;
            }

            ///sa imi pun usa 
            if (label1.Top <= 2 * label1.Height && usaNivel.Visible == false)
            {
                usaNivel.Location = new Point(0, 0);
                usaNivel.Visible = true;
            }

            ///restul copmenzilor
            label1.Top += jumpspeed;
            if (jumpspeed > 0)
                lc += jumpspeed;

            if (jumping == true && force < 0)///daca sar in gol sa se activeze gravitatia
                jumping = false;

            if (goleft == true && label1.Left>0)
                label1.Left -= 10;

            if (goright == true && label1.Left < 480 - label1.Width)
                label1.Left += 10;

            if (jumping)
            {
                jumpspeed = -10;
                force -= 1;
                pickey.Top += 10;
                usaNivel.Top += 10;
                ///sa pun cheia
                if ((pickey.Top + pickey.Height >= 650) && scor % 10 == 0)
                {
                    Random rnd = new Random();

                    int loc = rnd.Next(pickey.Height, 500 - pickey.Width);
                    pickey.Location = new Point(loc, 0);
                    pickey.Visible = true;

                }
                
                for (int j = 1; j <= nrguard; j++)
                {
                   guard[j].Top += 10;
                   
                }


                ///sa imi pun treptele 
                for (int j = 1; j <= i; j++)
                {
                    if (label1.Top < pics[j].Top - 3 * label1.Height)
                        pics[j].Visible = false;

                    pics[j].Top += 10;
                    if (pics[j].Top + pics[j].Height >= 650)
                    {
                        pics[j].Visible = true;
                        Random rnd = new Random();
                        int loc = rnd.Next(pics[j].Height, 500 - pics[j].Width);
                        pics[j].Location = new Point(loc, 0);
                    }
                }

            }

            if (!jumping && goup)
                jumpspeed = 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if (label1.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (label1.Bounds.IntersectsWith(x.Bounds) && jumping == false  && x.Visible == true && (string)x.Tag != "g" && (string)x.Tag != "key" && (string)x.Tag != "usa")///daca e treapta
                        {
                            if (label1.Top < x.Top)
                            {
                                
                                if ((vizitat == false) && (lc >= lmax))
                                {
                                    lmax = lc;
                                    scor++;
                                    vizitat = true;

                                }
                                label1.Top = x.Top - label1.Height+1;
                                jumpspeed = 0;
                                force = 6;
                            }
                            
                          
                           
                        }

                        if ((string)x.Tag == "key")//daca atingem cheia
                        {
                            if (label1.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                            {
                                x.Visible = false;
                                score++;
                            }
                        }
                        if ((string)x.Tag=="usa" && usaNivel.Visible==true)//daca atingem usa urcam un nivel
                        {
                            nivel++;
                            if (nivel % 5 == 0)
                            {
                                cntg = 2;///viteza e normala
                                nrguard++;
                                guard[nrguard] = new PictureBox();
                                guard[nrguard].Size = new Size(52, 58);
                                Random rnd1 = new Random();
                                int xx1 = rnd1.Next(guard[nrguard].Width, 500 - guard[nrguard].Width);
                                int yy1 = rnd1.Next(guard[nrguard].Height, 650 - 3 * guard[nrguard].Height);
                                guard[nrguard].Location = new Point(xx1, yy1);
                                guard[nrguard].Tag = "g";
                                guard[nrguard].Image = Properties.Resources._890_8903649_prison_guard_prison_guard_pixel_art2;
                                this.Controls.Add(guard[nrguard]);

                            }
                            reset();
                                if (nivel%5!=0)
                            cntg += 2;///marim viteza guardului
                            
                           
                            ShowNivelScreen();

                        }
                        if ((string)x.Tag == "g")///daca atingem guardu
                        {
                            mort = true;
                            timer1.Stop();
                            var result = MessageBox.Show("Vrei sa resetezi?", "Meniu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                                System.Windows.Forms.Application.OpenForms["Form1"].Show();
                            }
                            else
                            {
                                reset();
                            }
                        }
                    }
                }
            }
            if (score == 1)///bara de text
                lblsk.Text = "Ai eliberat " + score + " prizonier";
            else
                lblsk.Text = "Ai eliberat " + score + " prizonieri";


            if (label1.Top > 600 && goup)///daca pici jos sa mori
            {
                mort = true;
                timer1.Stop();
                var result = MessageBox.Show("Vrei sa resetezi?", "Meniu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    this.Close();
                    System.Windows.Forms.Application.OpenForms["Form1"].Show();
                }
                else///resetezi jocu
                {
                    mort = true;
                    reset();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.W )||( e.KeyCode == Keys.Up))
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                goright = false;
            }


        }
    }
}
