using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkPad
{
    public partial class Form1 : Form
    {
        // Chemin d'accès du répertoire de l'application (utilisé pour lancer les jeux)
        string path = AppDomain.CurrentDomain.BaseDirectory;


        public Form1()
        {
            InitializeComponent(); // Initialisation des composants de l'interface graphique
        }

        // Lancement du jeu "Try_To_ESCAPE_ GAME.exe" lors du clic sur le label3
        private void label3_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\games\Try_To_ESCAPE_ GAME.exe";
            jeuProcess.Start();
        }

        // Lancement du jeu "Idle Game --Strange Village--" lors du clic sur le label4
        private void label4_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\games\Idle Game --Strange Village--";
            jeuProcess.Start();
        }

        // Lancement du jeu "Chronomètre Ultime.exe" lors du clic sur le label5
        private void label5_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\games\Chronomètre Ultime.exe";
            jeuProcess.Start();
        }

        // Lancement du jeu "bataille navale escape.exe" lors du clic sur le label6
        private void label6_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\games\bataille navale escape.exe";
            jeuProcess.Start();
        }

        // Effet de survol de la souris sur le label3 : changement de couleur du texte
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0x08C5D1);
        }

        // Lorsque la souris quitte le label3 : retour à la couleur blanche
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        // Effet de survol pour le label6
        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(0x08C5D1);
        }

        // Fin du survol pour le label6
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        // Effet de survol pour le label4
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0x08C5D1);
        }

        // Fin du survol pour le label4
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        // Effet de survol pour le label5
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(0x08C5D1);
        }

        // Fin du survol pour le label5
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        // Ouverture du lien GitHub dans le navigateur par défaut
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/HOPPhugo");
        }

        // Lancement du programme "Auto Clicker Special.exe" lors du clic sur le label7
        private void label7_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\games\Auto Clicker Special.exe";
            jeuProcess.Start();
        }

        // Effet de survol pour le label7
        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.ForeColor = Color.SkyBlue;
        }

        // Fin du survol pour le label7
        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        // Méthode appelée au chargement du formulaire (actuellement vide)
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
