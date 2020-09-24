using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnnisApp
{
    class Controllo
    {
        private List<Dati> elenco;
        public Controllo()
        {
            elenco = new List<Dati>();
        }
        public List<Dati> getElenco()
        {
            return this.elenco;
        }
        public void add(Dati a)
        {
            elenco.Add(a);
        }
        public void leggi(string percorso)
        {
            FileStream stream = new FileStream(percorso, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string linea;
            while (!reader.EndOfStream)
            {
                linea = reader.ReadLine();
                string[] dati = linea.Split(';');
                Dati c = new Dati(dati[0], dati[1], dati[2], dati[3], dati[4]);
                add(c);
            }
        }
    }
}
