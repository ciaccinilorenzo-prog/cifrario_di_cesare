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
            string frase = txt_frase_C.Text;
            char outputC = ' ';
            int chiave, i = 0, modificatore;
            char t = frase[i];

            chiave = Convert.ToInt32(txt_chiave_C.Text);

            for (i = 0; i < frase.Length; i++)
            {
                modificatore = Convert.ToInt32(frase[i]);

                modificatore = modificatore + chiave;

                outputC = Convert.ToChar(modificatore);


                //outputC = outputC + t;
            }
            lbl_criptata.Text = "la frase criptata è: " + outputC.ToString();
        }
    }
}
