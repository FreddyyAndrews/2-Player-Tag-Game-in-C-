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

namespace Final_Project__Tag
{
    //Projet final pour ICS4U, le premier quadrimestre de l'année scolaire 2020-2021
    // Ce jeu démontre l'utilisation de nombreuses procédures complexes, l'utilisation de minuteries et de boîtes à images animées,
    //l'utilisation de la musique et des supports système et même l'utilisation de fichiers.
    //3 Formulaires sont utilisés, ce formulaire est le formulaire d'écran de saisie.

    public partial class Form3 : System.Windows.Forms.Form
    {
        SoundPlayer simpleSound = new SoundPlayer("8-Bit RPG Music - Victory Theme  Original Composition.wav");
       
        public Form3()
        {
            
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //La musique s'allume et définit les images des boutons.

            simpleSound.Play();
            button1.BackgroundImage = imageList1.Images[0];
            button2.BackgroundImage = imageList1.Images[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ouvre le jeu en mode 1 joueur.

            Properties.Settings.Default.Players = true;
                Properties.Settings.Default.Save();
                Form jeuform = new Form();
                jeuform.Show();
                this.Hide();
                
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ouvre le jeu en mode 2 joueurs. 

            Properties.Settings.Default.Players = false;
                Properties.Settings.Default.Save();
                Form jeuform = new Form();
                jeuform.Show();
                this.Hide();
            
           
        }
        

        private void cmtjouer_Click(object sender, EventArgs e)
        {
            //Explique au joueur comment jouer.
            MessageBox.Show("Choisissez le nombre de joueurs avec lesquels vous souhaitez jouer. " +
                "Définissez le nombre de points auquel vous souhaitez jouer, le premier à atteindre le but gagne." +
                " Chaque coffre vaut 1 point. Attention aux lasers, ils prennent tous vos points. P1 Utilise les" +
                "touches directionnelles pour bouger, P2 utilise WASD. Amuser Vous!!!!!!!", "Comment Jouer");
        }
    }
}
