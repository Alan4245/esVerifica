using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVerificaGithub
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _tabellaOraria;


        public Biblioteca(string Nome, string Indirizzo, string tabellaOraria, List<Libro> Libri)
        {
            Nome = _nome;
            Indirizzo = _indirizzo;
            

        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }

        }

        public string Indirizzo
        {
            get
            {
                return _indirizzo;
            }
            set
            {
                _indirizzo = value;
            }
        }

        public string TabellaOraria
        {

            get
            {
                return _tabellaOraria;
            }
            set
            {
                _tabellaOraria = value;
            }

        }





    }
}
