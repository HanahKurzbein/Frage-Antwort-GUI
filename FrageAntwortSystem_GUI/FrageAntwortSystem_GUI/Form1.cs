using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrageAntwortSystem_GUI
{
    public partial class Form1 : Form
    {

        private Helferlein helfer = new Helferlein();
        public Form1()
        {
            InitializeComponent();   // Ruft die Form1.cs Entwurf auf
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        
        private void button1_Click(object sender, EventArgs e) // 
        {
            helfer.Einlesen();    // FragenList wird ausgelesen
            helfer.FragenBlöcke(0,0); 
            ListBoxFill();        // ListBox wird mit FragenListe gefüllt

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }

        public void ListBoxFill()
        {
            foreach (string frage in helfer.GetList())
            {
                listBox1.Items.Add(frage);                // listBox wird mit der ganzen Liste(FragenListe) gefüllt (Eine Zeile in FragenListe entspricht ein Item in ListBox)

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();          // Items sollen verschwinden
            helfer.FBLöschen();              // Liste wird greinigt, aber Einträge bleiben bestehen
            helfer.FragenBlöcke(1,0);        // Bildet die Fragenblöcke
            ListBoxFill();                   
        }
    }
}
