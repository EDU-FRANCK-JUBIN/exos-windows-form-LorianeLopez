using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        float num;
        float answer = 0;
        int compteur = 0;
        bool egal = false;
        bool erreur = false;

        int count;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
        #region test
        private void button_CE_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            label2.Text = "";
            compteur = 0;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            int lenght = textBoxResult.TextLength - 1;
            string text = textBoxResult.Text;
            textBoxResult.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBoxResult.Text = textBoxResult.Text + text[i];
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBoxResult.Text);
                textBoxResult.Clear();
                textBoxResult.Focus();
                count = 4;
                label2.Text = num.ToString() + "/";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                if (!erreur)
                {
                    egal = false;
                    label2.Text = "";
                    num = float.Parse(textBoxResult.Text);
                    textBoxResult.Clear();
                    textBoxResult.Focus();
                    count = 4;
                    label2.Text = num.ToString() + "/";
                    compteur = compteur + 1;
                }
            }
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 7;
         
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 8;
           
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text+ 9;
         

        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBoxResult.Text);
                textBoxResult.Clear();
                textBoxResult.Focus();
                count = 3;
                label2.Text = num.ToString() + "*";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                if (!erreur)
                {
                    egal = false;
                    label2.Text = "";
                    num = float.Parse(textBoxResult.Text);
                    textBoxResult.Clear();
                    textBoxResult.Focus();
                    count = 3;
                    label2.Text = num.ToString() + "*";
                    compteur = compteur + 1;
                }
            }
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 4;
            
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 5;
            
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 6;
            
        }

        private void button_sous_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBoxResult.Text);
                textBoxResult.Clear();
                textBoxResult.Focus();
                count = 2;
                label2.Text = num.ToString() + "-";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                if (!erreur)
                {
                    egal = false;
                    label2.Text = "";
                    num = float.Parse(textBoxResult.Text);
                    textBoxResult.Clear();
                    textBoxResult.Focus();
                    count = 2;
                    label2.Text = num.ToString() + "-";
                    compteur = compteur + 1;
                }
            }

        }

        private void number_1_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 1;
            
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 2;
           
        }

        private void number_3_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 3;
          
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (compteur <= 0)
            {
                num = float.Parse(textBoxResult.Text);
                textBoxResult.Clear();
                textBoxResult.Focus();
                count = 1;
                label2.Text = num.ToString() + "+";
                compteur = compteur + 1;
            }
            else
            {
                Calcul();
                if (!erreur)
                {
                    egal = false;
                    label2.Text = "";
                    num = float.Parse(textBoxResult.Text);
                    textBoxResult.Clear();
                    textBoxResult.Focus();
                    count = 1;
                    label2.Text = num.ToString() + "+";
                }
            }

        }

        private void button_mystery_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = textBoxResult.Text + "Ce mystère n'est pas élucidé...";
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            if (egal)
            {
                textBoxResult.Clear();
                label2.Text = "";
                compteur = 0;
            }
            textBoxResult.Text = textBoxResult.Text + 0;
            
        }

        private void button_virg_Click(object sender, EventArgs e)
        {
            if (!textBoxResult.Text.Contains(",")) { 
                 textBoxResult.Text = textBoxResult.Text + ",";
             }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private void button_egal_Click(object sender, EventArgs e)
        {
            Calcul();
            label2.Text = "";
        }

        public void Calcul()
        {

            switch (count)
            {
                case 1:
                    try
                    {
                        answer = num + float.Parse(textBoxResult.Text);
                        textBoxResult.Text = label2.Text + textBoxResult.Text + " = " + answer.ToString();
                        egal = true;
                    }
                    catch (FormatException e)
                    {
                        textBoxResult.Text = "Calcul Impossible";
                        erreur = true;
                        label2.Text = "";
                        compteur = 0;
                    }
                    break;
                case 2:
                    try { 
                        answer = num - float.Parse(textBoxResult.Text);
                        textBoxResult.Text = label2.Text + textBoxResult.Text + " = " + answer.ToString();
                        egal = true;
                     }
                    catch (FormatException e)
                    {
                        textBoxResult.Text = "Calcul Impossible";
                        erreur = true;
                        label2.Text = "";
                        compteur = 0;
                     }
                     break;
                case 3:
                    try
                    {
                        answer = num * float.Parse(textBoxResult.Text);
                        textBoxResult.Text = label2.Text + textBoxResult.Text + " = " + answer.ToString();
                        egal = true;
                    }
                    catch (FormatException e)
                    {
                        textBoxResult.Text = "Calcul Impossible";
                        erreur = true;
                        label2.Text = "";
                        compteur = 0;
                    }
                    break;
                case 4:
                    try
                    {
                        answer = num / float.Parse(textBoxResult.Text);
                        textBoxResult.Text = label2.Text + textBoxResult.Text + " = " + answer.ToString();
                        egal = true;
                    }
                    catch (FormatException e)
                    {
                        textBoxResult.Text = "Calcul Impossible";
                        erreur = true;
                        label2.Text = "";
                        compteur = 0;
                    }
                    break;
                default:
                    break;
                    
            }

        }
    }
}
