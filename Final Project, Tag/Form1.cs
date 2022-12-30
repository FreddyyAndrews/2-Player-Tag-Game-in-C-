using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic;

namespace Final_Project__Tag
{
    //Projet final pour ICS4U, le premier quadrimestre de l'année scolaire 2020-2021
   // Ce jeu démontre l'utilisation de nombreuses procédures complexes, l'utilisation de minuteries et de boîtes à images animées,
   //l'utilisation de la musique et des supports système et même l'utilisation de fichiers.
   //3 formulaires sont utilisés, ce formulaire est le formulaire de jeu principal.

    public partial class Form : System.Windows.Forms.Form
    {
        //Déclaration des variables et contrôles.

        int p1points =0,p2points=0,speed=10;
        SoundPlayer simpleSound = new SoundPlayer("AdhesiveWombat - 8 Bit Adventure.wav");
        PictureBox chest = new PictureBox();
        PictureBox beam = new PictureBox();
        PictureBox beam2 = new PictureBox();
       
        string a,b,chestype;
        bool p1overlappedbeam = false, p2overlappedbeam = false,p1overlappedbeam2,p2overlappedbeam2,
            p1overlappedchest=false,p2overlappedchest=false;
        int i,i2,v;

        private void p1_Click(object sender, EventArgs e)
        {

        }

        int slower =0,slower2=0;
        public Form()
        {
            InitializeComponent();
            
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Vérifie si un joueur ou le mode 2 joueurs a été sélectionné, si un mode 1 joueur a été sélectionné,
            //le joueur 2 ne sera pas visible.  

            if (Properties.Settings.Default.Players == true)
            { p2.Visible = false;
                p2score.Visible = false;
            }
            else 
            { p2.Visible = true;
                speed += 8;
            }



            //Joue la musique.
            simpleSound.Play();

            //Définit l'image dans les Picturebox des joueurs.
            p1.Image = imageListright.Images[1];
            p2.Image = P2left.Images[0];
            //Définit l'image d'arrière-plan
            this.BackgroundImage = Properties.Resources.background_for_video_game;

            Random rnd = new Random();
            int num = rnd.Next(8);

            //choisit au hasard où le premier coffre au trésor est placé. 
            chest.Image = effects.Images[0];
            chest.Size= new System.Drawing.Size(64,64);
            if (num==0)
            { chest.Location = new Point(0, 0); }
            if (num == 1)
            { chest.Location = new Point(0, 0); }
            if (num == 2)
            { chest.Location = new Point(0, 400); }
            if (num == 3)
            { chest.Location = new Point(250, 0); }
            if (num == 4)
            { chest.Location = new Point(250, 250); }
            if (num == 5)
            { chest.Location = new Point(250, 400); }
            if (num == 6)
            { chest.Location = new Point(500, 0); }
            if (num == 7)
            { chest.Location = new Point(500, 0); }
            if (num == 8)
            { chest.Location = new Point(500, 400); }
            
            this.Controls.Add(chest);
        }

        private void chesttimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void beamtimer_Tick(object sender, EventArgs e)
        {
            //Selon le type de coffre, une séquence de laser différente sera créée avec les Picturebox. 


            if (chestype=="h")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(32, 700);
                    beam.Location = new Point(150, 0);
                    this.Controls.Add(beam);


                    beam2.Image = Properties.Resources.Red_svg;
                    beam2.Size = new System.Drawing.Size(32, 700);
                    beam2.Location = new Point(400, 0);
                    this.Controls.Add(beam2);

                }

                //Il appellera alors le vide public "beamss".
                beamss();
            }
            if (chestype=="v")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(700, 32);
                    beam.Location = new Point(0, 55);
                    this.Controls.Add(beam);


                    beam2.Image = Properties.Resources.Red_svg;
                    beam2.Size = new System.Drawing.Size(700, 32);
                    beam2.Location = new Point(0, 300);
                    this.Controls.Add(beam2);

                }


                beamss();
            }
           if (chestype=="x")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(700, 32);
                    beam.Location = new Point(0, 55);
                    this.Controls.Add(beam);


                    beam2.Image = Properties.Resources.Red_svg;
                    beam2.Size = new System.Drawing.Size(32, 700);
                    beam2.Location = new Point(400, 0);
                    this.Controls.Add(beam2);

                }
                beamss();
            }
            if (chestype=="w")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(32, 250);
                    beam.Location = new Point(150, 0);
                    this.Controls.Add(beam);


                    beam2.Image = Properties.Resources.Red_svg;
                    beam2.Size = new System.Drawing.Size(32, 700);
                    beam2.Location = new Point(400, 200);
                    this.Controls.Add(beam2);

                }
                beamss();

               
            }
            if (chestype=="p")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(700, 32);
                    beam.Location = new Point(175, 300);
                    this.Controls.Add(beam);


                    beam2.Image = Properties.Resources.Red_svg;
                    beam2.Size = new System.Drawing.Size(400, 32);
                    beam2.Location = new Point(0, 100);
                    this.Controls.Add(beam2);

                }
                beamss();
            }
            if (chestype == "b")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(700, 300);
                    beam.Location = new Point(0, 200);
                    this.Controls.Add(beam);


                   

                }
                beamss();
            }
            if (chestype == "t")
            {
                v++;
                if (v == 1)
                {
                    beam.Image = Properties.Resources.Red_svg;
                    beam.Size = new System.Drawing.Size(700, 300);
                    beam.Location = new Point(0, 0);
                    this.Controls.Add(beam);




                }
                beamss();
            }
            if (chestype == "s")
            {
                speed += 1;
                beamtimer.Stop();
            }
            beam.BringToFront();
            beam2.BringToFront();
        }
        public void beamss()
        {
            if (v >= 100)
            {
               // La couleur du faisceau passera du rouge au noir après 100 ticks.Une fois que le faisceau est noir, 
                //si le joueur chevauche le faisceau, il perdra tous ses points. 

                if (v==101)
                {
                    //10 seront ajoutés à la vitesse des joueurs pour compenser le décalage.
                    speed += 10; }

                beam.Image = Properties.Resources.Black;
                beam2.Image = Properties.Resources.Black;
                p1overlappedbeam = p1.Bounds.IntersectsWith(beam.Bounds);
                p1overlappedbeam2 = p1.Bounds.IntersectsWith(beam2.Bounds);
                p2overlappedbeam = p2.Bounds.IntersectsWith(beam.Bounds);
                p2overlappedbeam2 = p2.Bounds.IntersectsWith(beam2.Bounds);
                

                if (p1overlappedbeam == true || p1overlappedbeam2 == true)
                {

                    if (p1points>0)
                    {
                        p1points = 0;
                        p1score.Text = "P1: " + p1points;
                    }
                    

                }

                if (p2overlappedbeam == true || p2overlappedbeam2 == true)
                {
                    if (p2points > 0)
                    {
                        p2points = 0;
                        p2score.Text = "P2: " + p2points;
                    }
                }


                if (v >= 180)
                {
                    List<Control> controlsList = new List<Control>();
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            controlsList.Add(ctrl);
                        }
                    }
                    foreach (Control ctrl in controlsList)
                    {
                        if (ctrl != p1 && ctrl != chest && ctrl != p2)
                        { this.Controls.Remove(ctrl); }

                    }
                    v = 0;
                    if (Properties.Settings.Default.Players == true)
                    {
                        speed = 10;
                    }
                    else
                    {
                        speed = 18;
                    }

                    beamtimer.Stop();
                    
                }
               
            }
        }
        private void effecttimer_Tick(object sender, EventArgs e)
        {
              
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            timer.Start();

            //Les clics clés enregistreront le mouvement des joueurs dans une string. 
            if (e.KeyCode == Keys.Right)
            {
                
                 a = "right";
                
               
                 
            }
            else if (e.KeyCode == Keys.Left)
            {
               
                 a = "left"; 
                
                 
            }
                
            else if (e.KeyCode == Keys.Up)
            {
               
                 a = "up"; 
               
            }
            else if (e.KeyCode == Keys.Down)
            {
               
                 a = "down"; 
                
            }

            

            if (e.KeyCode == Keys.D)
            {

                b = "right";


            }
            else if (e.KeyCode == Keys.A)
            {

                b = "left";


            }

            else if (e.KeyCode == Keys.W)
            {

                b = "up";

            }
            else if (e.KeyCode == Keys.S)
            {

                b = "down";

            }
            if (e.KeyCode==Keys.Escape) //Si le joueur met le jeu en pause en cliquant sur échapper, un menu de pause apparaît.

            {
                timer.Stop();
                
                DialogResult dialog = MessageBox.Show("Souhaitez-vous revenir au menu principal?", "Jeu en pause", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    Form3 main = new Form3();
                    main.Show();
                    Close();
                }
                else
                {
                    timer.Start();
                }
            }
            
        }
        public void chestreset()
        {
            //Si le joueur chevauche les limites d'un coffre, sa position sera réinitialisée au hasard.

            chest.Visible = false;

            Random rnd = new Random();
            int num = rnd.Next(8);


            if (num == 0)
            {

                chest.Location = new Point(0, 0);
                beamtimer.Start(); //La minuterie de laser démarre et un laser est créé.
                chestype = "h";

            }
            if (num == 1)
            { chest.Location = new Point(0, 250);
                beamtimer.Start();
                chestype = "v";
            }
            if (num == 2)
            { chest.Location = new Point(0, 400);
                beamtimer.Start();
                chestype = "x";
            }
            if (num == 3)
            { chest.Location = new Point(250, 0);
                beamtimer.Start();
                chestype = "w";
            }
            if (num == 4)
            { chest.Location = new Point(250, 250);
                beamtimer.Start();
                chestype = "p";
            }
            if (num == 5)
            { chest.Location = new Point(250, 400);
                beamtimer.Start();
                chestype = "b";
            }
            if (num == 6)
            { chest.Location = new Point(500, 0);
                beamtimer.Start();
                chestype = "t";
            }
            if (num == 7)
            { chest.Location = new Point(500, 250);
                beamtimer.Start();
                chestype = "s";
            }
            if (num == 8)
            { chest.Location = new Point(500, 400); }
            chest.Visible = true;
        }
        public void p1move()
        {
            //Selon la direction choisie par le joueur,
            //le joueur se déplacera à chaque tick et parcourra l'animation. S'ils sortent de l'écran,
            //ils seront réinitialisés de l'autre côté de l'écran. 

            try
            {
                if (a == "right")
                {
                    if (p1.Left >= 650)
                    {
                        p1.Left = (-5);
                    }
                    slower++;
                    p1.Left += speed;

                    if (slower % 8 == 0)
                    {
                        i++;

                        p1.Image = imageListright.Images[i - 1];
                        if (i == 2)
                        { i = 0; }
                    }
                    if (slower == 100)
                    { slower = 0; }


                }
                if (a == "left")
                {
                    if (p1.Left <= -5)
                    {

                        p1.Left = 650;
                    }
                    slower++;
                    p1.Left -= speed;

                    if (slower % 8 == 0)
                    {
                        i++;

                        p1.Image = imageListleft.Images[i - 1];
                        if (i == 2)
                        { i = 0; }
                    }
                    if (slower == 100)
                    { slower = 0; }
                }
                if (a == "up")
                {
                    if (p1.Top <= -5)
                    {

                        p1.Top = 430;
                    }
                    slower++;
                    p1.Top -= speed;

                    if (slower % 8 == 0)
                    {
                        i++;

                        p1.Image = imageListback.Images[i - 1];
                        if (i == 2)
                        { i = 0; }
                    }
                    if (slower == 100)
                    { slower = 0; }


                }
                if (a == "down")
                {
                    if (p1.Top >= 430)
                    {

                        p1.Top = (-5);
                    }
                    slower++;
                    p1.Top += speed;

                    if (slower % 8 == 0)
                    {
                        i++;

                        p1.Image = imageListdown.Images[i - 1];
                        if (i == 2)
                        { i = 0; }
                    }
                    if (slower == 100)
                    { slower = 0; }


                }
            }
            catch
            { }
            
            
            
        }
        public void p2move()
        {
            try
            {
                if (p2.Left >= 650)
                {
                    p2.Left = (-5);
                }
                else if (p2.Left <= -60)
                {

                    p2.Left = 650;
                }
                else if (p2.Top <= -60)
                {

                    p2.Top = 430;
                }
                else if (p2.Top >= 430)
                {

                    p2.Top = (-30);
                }
                if (b == "right")
                {
                    slower2++;
                    p2.Left += speed;

                    if (slower2 % 8 == 0)
                    {
                        i2++;

                        p2.Image = P2right.Images[i2 - 1];
                        if (i2 == 2)
                        { i2 = 0; }
                    }
                    if (slower2 == 100)
                    { slower2 = 0; }


                }
                if (b == "left")
                {
                    slower2++;
                    p2.Left -= speed;

                    if (slower2 % 8 == 0)
                    {
                        i2++;

                        p2.Image = P2left.Images[i2 - 1];
                        if (i2 == 2)
                        { i2 = 0; }
                    }
                    if (slower2 == 100)
                    { slower2 = 0; }
                }
                if (b == "up")
                {
                    slower2++;
                    p2.Top -= speed;

                    if (slower2 % 8 == 0)
                    {
                        i2++;

                        p2.Image = P2up.Images[i2 - 1];
                        if (i2 == 2)
                        { i2 = 0; }
                    }
                    if (slower2 == 100)
                    { slower2 = 0; }


                }
                if (b == "down")
                {
                    slower2++;
                    p2.Top += speed;

                    if (slower2 % 8 == 0)
                    {
                        i2++;

                        p2.Image = p2down.Images[i2 - 1];
                        if (i2 == 2)
                        { i2 = 0; }
                    }
                    if (slower2 == 100)
                    { slower2 = 0; }


                }
            }
            catch
            { }
            
           
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //Le tick du chronomètre vérifiera si le joueur chevauche les limites du coffre au trésor, il recevra un point si oui.

            p1overlappedchest = p1.Bounds.IntersectsWith(chest.Bounds);
             p2overlappedchest = p2.Bounds.IntersectsWith(chest.Bounds);

            if (p1overlappedchest==true)
            {
                p1points += 1;
                chestreset();
                p1score.Text = "P1: " + p1points;
                if (p1points==Properties.Settings.Default.score)
                {
                    Properties.Settings.Default.p1w = true;
                    Form4 endform = new Form4();

                    // Show the settings form
                    endform.Show();
                  
                    Close();
                }
            }
            if (p2overlappedchest == true)
            {
                p2points += 1;
                
                chestreset();
                p2score.Text = "P2: " + p2points;
                if (p2points == Properties.Settings.Default.score)
                {
                    Properties.Settings.Default.p1w = false;
                    Form4 endform = new Form4();

                    // Show the settings form
                    endform.Show();
                    
                    Close();
                }

            }
           p1move();
            p2move();
            

            
        }
    }
}


