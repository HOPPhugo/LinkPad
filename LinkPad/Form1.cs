using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\Try_To_ESCAPE_ GAME.exe";
            jeuProcess.Start();
            return;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\Idle Game --Strange Village--";
            jeuProcess.Start();
            return;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\Chronomètre Ultime.exe";
            jeuProcess.Start();
            return;
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

            Process jeuProcess = new Process();
            jeuProcess.StartInfo.FileName = path + @"\bataille navale escape.exe";
            jeuProcess.Start();
            return;
        }
    }
}
