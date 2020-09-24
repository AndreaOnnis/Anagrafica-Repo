using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnnisApp
{
    class Dati
    {
        private string nome;
        private string cognome;
        private int età;
        private string indirizzo;
        private string professione;
        public Dati(string nome, string cognome, string età, string indirizzo, string professione)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.età = int.Parse(età);
            this.indirizzo = indirizzo;
            this.professione = professione;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getCognome()
        {
            return this.cognome;
        }
        public int getEtà()
        {
            return this.età;
        }
        public string getIndirizzo()
        {
            return this.indirizzo;
        }
        public string getProfessione()
        {
            return this.professione;
        }
    }
}
