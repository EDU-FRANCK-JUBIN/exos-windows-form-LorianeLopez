using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecteurMP3
{
    public partial class Form1 : Form
    {
        Lecteur lecture = new Lecteur();
        private static Timer aTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            lecture.setCheminDeBase(folderDlg.SelectedPath);
            lectureFonction();


        }

    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTitres_Click(object sender, EventArgs e)
        {
            if (lecture.getChange())
            {
                lecture.sauveListe(lecture.getCheminDeBase());
                MessageBox.Show("Un fichier contenant la liste de tous les titres à été crée dans le chemin suivant : " + lecture.getCheminDeBase(), "Liste des Titres");

            }
            else
            {
                MessageBox.Show("Veuillez d'abord selectionner un répertoire.", "Erreur");
            }
        }

        private void buttonLecture_Click(object sender, EventArgs e)
        {
            lectureFonction();
        }

        private void lectureFonction()
        {
            axWindowsMediaPlayer1.URL = lecture.joue();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            repertoire.Text = lecture.getCheminDeBase();
            string titreMorceau = axWindowsMediaPlayer1.URL.Substring(lecture.getCheminDeBase().Length + 1);
            labelTitre.Text = titreMorceau;
            axWindowsMediaPlayer1.PlayStateChange +=
      new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                aTimer = new Timer();
                aTimer.Interval = 10;
                aTimer.Enabled = true;
                lectureFonction();
            }

        }
    }
}
