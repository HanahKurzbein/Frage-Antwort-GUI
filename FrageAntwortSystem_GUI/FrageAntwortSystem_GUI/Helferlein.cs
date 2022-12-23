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
        private List<string> fragenBlock = new List<string>();  // Generiert FragenBlockListe für unsere FragenBlöckeMethode 

        public List<string> FragenListe { get => fragenListe; set => fragenListe = value; }
        public List<string> FragenBlock { get => fragenBlock; set => fragenBlock = value; }

        public Helferlein()
        {

        }
        public void Einlesen()
        {
            foreach (string line in System.IO.File.ReadLines("..\\..\\..\\FRAGEN.TXT"))
            {
                string frage = line.ToString();                // Liest jede Zeile aus und macht einen String daraus und packt es in die Variable frage
                FragenListe.Add(frage);                        // Und packt es in die FragenListe, solange bis keine Zeile mehr da ist                                                   
            }
        }
        public List<string> GetList()
        {
            return FragenBlock.ToList();                                    // GetList nimmt die FragenListe und gibt sie zurück/weiter
                                                                                                        

        }
        public void FragenBlöcke(int x, int y)                                            // Bildet die FragenBlöcke und übergibt in den Klammern Variable
        {
            foreach (string line in FragenListe)                                           // Für jede Zeile in der FragenListe
            {                
                if (line.Contains($"000{x}{y}") & !line.Contains($"000{x}9"))               // Wenn in FragenListe 000 enthalten ist & wenn(solange) in FragenListe keine 9 enthalten ist
                {
                    if (!line.Contains($"000{x}1"))
                    {
                        FragenBlock.Add(line);
                        y++;
                    }
                    else if (line.Contains($"000{x}1"))
                    {
                        FragenBlock.Add(line);
                    }                    
                }
                else if (line.Contains($"000{x}2") & !line.Contains($"000{x}9"))
                {
                    FragenBlock.Add(line);
                    y = 3;
                }
            }
        }
        public void FBLöschen()
        {
            fragenBlock.Clear();                                           // Liste wird gereinigt, bleibt aber ohne Einträge bestehen.
        }
        
       
    }
}
