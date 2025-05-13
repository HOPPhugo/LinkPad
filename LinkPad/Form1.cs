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
        string path = AppDomain.CurrentDomain.BaseDirectory; // récupère le chemin d'accès de mon jeu ( je l'utilise pour crée et trouver les fichier pour les events)
        bool un = false;
        bool deux = false;
        bool trois = false;
        bool quatre = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\Try_To_ESCAPE_ GAME.exe";
                jeuProcess.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\Idle Game --Strange Village--";
                jeuProcess.Start();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\Chronomètre Ultime.exe";
                jeuProcess.Start();
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\bataille navale escape.exe";
            string FileName = path + @"\bateau.txt";
                jeuProcess.Start();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0x08C5D1);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.FromArgb(0x08C5D1);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.FromArgb(0x08C5D1);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.FromArgb(0x08C5D1);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/HOPPhugo");
        }
    }
}
