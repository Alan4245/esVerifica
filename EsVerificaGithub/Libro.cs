using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVerificaGithub
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoPubblicazione;
        private string _editore;
        private int _numeroPagine;

        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }

        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Nome dell'autore non valido");
                }
                _autore = value;
            }
        }

        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Titolo del libro");
                }
                _titolo = value;
            }
        }

        public int AnnoPubblicazione
        {
            get
            {
                return _annoPubblicazione;
            }
            set
            {
                if (value < 1000) //ho ipotizzato che l'anno di pubblicazione minore che ci possa essere sia l'anno 1000
                {
                    throw new Exception("Anno pubblicazione del libro non valido");
                }
                _annoPubblicazione = value;
            }
        }

        public string Editore
        {
            get
            {
                return _editore;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Editore non valido");
                }
                _editore = value;
            }
        }

        public int NumeroPagine
        {
            get
            {
                return _numeroPagine;
            }
            set
            {
                if (value < 20) //ho ipotizzato che il minimo numero complessivo di pagine sia 20
                {
                    throw new Exception("Numero delle pagine non valido");
                }
                _numeroPagine = value;
            }
        }

        public int ReadingTime()
        {
            int tmp = NumeroPagine / 100;
            return tmp + 1;
        }

        public override string ToString()
        {
            return $"{Autore}|{Titolo}|{AnnoPubblicazione}|{Editore}|{NumeroPagine}";
        }


    }
}
