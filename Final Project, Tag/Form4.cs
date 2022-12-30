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
    //3 formulaires sont utilisés, ce formulaire est le formulaire d'écran de fin.
    public partial class Form4 : System.Windows.Forms.Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Le joueur qui a gagné est affiché dans la Picturebox.
            //L'utilisateur peut choisir de revenir au menu principal ou de quitter le programme.


            if (Properties.Settings.Default.p1w == true)
            { label1.Text = "P1 a gagnier!";
                pictureBox1.Image = wpic.Images[1];
            
            }
            else
            {
                label1.Text = "P2 a gagnier!";
                pictureBox1.Image = wpic.Images[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form3 main = new Form3();

            main.Show();
            Close();

        }

        private void messageDuGagnianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Le gagnant peut enregistrer un fichier texte, appelé message du gagnant

            String Message = Interaction.InputBox("Enregistrer le message du gagnant","","");
            try //S'assure qu'aucune erreur ne se produit.
                //Des erreurs se produisent généralement lors de la sauvegarde dans le même fichier.
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    //Ouvrez «savefiledialogue» pour les fichiers texte.
                    dlg.Filter = "*.txt|*.txt";
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // Le texte de «richtextbox» est entré dans le fichier.
                        System.IO.File.WriteAllText(dlg.FileName, Message);
                    }
                }
            }
            catch
            { MessageBox.Show("Ce fichier est en cours d'exécution"); }
        }
    }
}
