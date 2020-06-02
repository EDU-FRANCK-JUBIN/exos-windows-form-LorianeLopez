using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecteurMP3
{
    class Lecteur
    {
        private string cheminDeBase;
        bool change = false ;
        Random alea = new Random();
        string[] listeMP3 = null;

        public void creeListeMP3(string repertoire)
        {
            listeMP3 = Directory.GetFiles(@repertoire, "*.mp3");
        }

        public void creeListeTotale(string repertoireCourant)
        {
            listeMP3 = Directory.GetFiles(@repertoireCourant, " *.mp3", SearchOption.AllDirectories);
        }

        public void sauveListe(string chemin)
        {
            StreamWriter file = new StreamWriter(@chemin + "/listMP3.txt");

            foreach (string musique in listeMP3)
            {
                string mus = musique.Substring(chemin.Length + 1);
                file.Write(mus);
                file.Write('\n');
            }
            file.Close();
        }


        public string joue()
        {
            if(IsNullOrEmpty(listeMP3))
            {
                listeMP3 = Directory.GetFiles(@cheminDeBase, "*.mp3");
            }

            int nbMorceaux = listeMP3.Length;
            int numAlea = alea.Next(nbMorceaux);

            return listeMP3[numAlea];
        }

        public void setCheminDeBase(string chemin)
        {
            this.cheminDeBase = chemin;
            setChange();
        }

        public string getCheminDeBase()
        {
            return this.cheminDeBase;
        }

        public void setChange()
        {
            this.change = true;
        }

        public bool getChange()
        {
            return change;
        }

        static bool IsNullOrEmpty(string[] myStringArray)
        {
            return myStringArray == null || myStringArray.Length < 1;
        }

    }

}
