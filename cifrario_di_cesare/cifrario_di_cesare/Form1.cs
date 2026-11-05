using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cifrario_di_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cripta_Click(object sender, EventArgs e)
        {
            string frase = txt_frase_C.Text, outputC2 = "";
            char outputC = ' ';
            int chiave, i = 0, modificatore;
            

            chiave = Convert.ToInt32(txt_chiave_C.Text);

            for (i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    modificatore = Convert.ToInt32(frase[i]);
                    

                    modificatore = modificatore + chiave;
                    if (modificatore > 122)
                    {
                        modificatore = modificatore - 26;
                    }
                    else
                    {
                        if (modificatore < 96 && modificatore > 90)
                        {
                            modificatore = modificatore - 26;
                        }
                    }

                    outputC = Convert.ToChar(modificatore);

                    outputC2 = outputC2 + outputC;
                    
                }
                else
                {
                    outputC2 = outputC2 + " ";
                }


            }
            lbl_criptata.Text = "la frase criptata è: " + outputC2.ToString();
        }

        private void btn_decripta_Click(object sender, EventArgs e)
        {
            string frase = txt_frase_D.Text, outputD2 = "";
            char outputD = ' ';
            int chiave, i = 0, modificatore;
        }
    }
}
