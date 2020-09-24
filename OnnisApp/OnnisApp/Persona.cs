using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnnisApp
{
    class Persona
    {
        private string nome;
        private string cognome;
        private string classe;
        private string sesso;
        private string dataDiNascita;

        public ElencoPersone(string nome, string cognome, string classe, string sesso, string dataDiNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.classe = classe;
            this.sesso = sesso;
            this.dataDiNascita = dataDiNascita;
        }

        public string getNome()
        {
            return this.nome;
        }
        public string getCognome()
        {
            return this.cognome;
        }
        public string getClasse()
        {
            return this.classe;
        }
        public string getSesso()
        {
            return this.sesso;
        }
        public string getDataDiNascita()
        {
            return this.dataDiNascita;
        }
    }
}
