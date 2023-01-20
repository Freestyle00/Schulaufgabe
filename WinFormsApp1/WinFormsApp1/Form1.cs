using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public CKomponente RechenKomponente = new CKomponente();

        private void button1_Click(object sender, EventArgs e)
        {
            string kosten = textBox1.Text;
            float kostenint = 0;
            if (kosten != "")
            { 
                kostenint = float.Parse(kosten);
            }
            string stromverbauch = textBox2.Text;
            float stromvebrauchint = 0;
            if (stromverbauch != "")
            {
                stromvebrauchint = float.Parse(stromverbauch);
            }
            string Anzahl = textBox3.Text;
            int Anzahlint = Convert.ToInt32(Anzahl);
            string AusGerät = comboBox1.SelectedItem.ToString();
            Console.WriteLine(AusGerät);
            Speicher.RechenKomponente.Kostenzuweisung(AusGerät, kostenint);
            Speicher.RechenKomponente.Stromzuweisung(AusGerät, stromvebrauchint);
            Speicher.RechenKomponente.Anzahlzuweisung(AusGerät, Anzahlint);

            Speicher.kosten += Speicher.RechenKomponente.Kostenrechnung();
            Speicher.strom += Speicher.RechenKomponente.Stromrechung();

            label5.Text = "Kosten: " + Speicher.kosten.ToString();
            label6.Text = "Stromverbrauch: " + Speicher.strom.ToString();
        }
    }
}
