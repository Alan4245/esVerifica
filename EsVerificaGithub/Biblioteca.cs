﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsVerificaGithub
{
    class Biblioteca
    {
        private string _nome;
       private  string _indirizzo;
        private float _orarioApertura;
       private float _orarioChiusura;


        public Biblioteca(string Nome, string Indirizzo,float orarioApertura, float orarioChiusura, List <string > Libri)
        {
            Nome = _nome;
            Indirizzo = _indirizzo;
            orarioApertura = _orarioApertura;
            orarioChiusura = _orarioChiusura;

        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                return _nome;
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
                return _indirizzo;
            }
        }

        public float orarioApertura
        {
            get
            {
                return _orarioApertura;
            }
            set
            {
                return _orarioApertura;
            }
        }

        public float orarioChiusura
        {
            get
            {
                return _orarioChiusura;
            }
            set
            {
                return _orarioChiusura;
            }
        }

        


    }
}
