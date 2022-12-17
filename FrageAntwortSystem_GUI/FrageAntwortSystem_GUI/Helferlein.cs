using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FrageAntwortSystem_GUI
{
    public class Helferlein
    {
        private List<string> fragenListe = new List<string>();

        public List<string> FragenListe { get => fragenListe; set => fragenListe = value; }


        public Helferlein()
        {

        }
        public void Einlesen()
        {
            foreach (string line in System.IO.File.ReadLines("..\\..\\..\\FRAGEN.TXT"))
            {
                string frage = line.ToString();            // Liest jede Zeile aus
                FragenListe.Add(frage);                    // Und packt es in die FragenListe        solange bis keine Zeile mehr da ist                                                   
            }
        }
        public List<string> GetList()
        {
            return FragenListe.ToList();         

        }
       
    }
}
