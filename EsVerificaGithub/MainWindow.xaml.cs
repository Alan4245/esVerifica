﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace EsVerificaGithub
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Libro> libri;
        Biblioteca biblioteca;

        public MainWindow()
        {
            InitializeComponent();
            Inizializzazione();
            libri = new List<Libro>();
        }

        


        public void Inizializzazione()
        {

            using(StreamReader sr = new StreamReader("datiBiblioteca.txt"))
            {

                string line;

                line = sr.ReadLine();
                string[] lineaSplittata = line.Split('|');
                txtNome.Text = lineaSplittata[0];
                txtIndirizzo.Text = lineaSplittata[1];
                txtTabellaOraria.Text = lineaSplittata[2];
                biblioteca = new Biblioteca(txtNome.Text, txtIndirizzo.Text, txtTabellaOraria.Text, libri);

            }

        }

        private void btn_ricercaTitolo_Click(object sender, RoutedEventArgs e)
        {

            string titolo = txtTitolo.Text;
            List<Libro> libriCompatibili = new List<Libro>();

            foreach(Libro libro in libri)
            {



                if (libro.Titolo == titolo)
                    libriCompatibili.Add(libro);

            }

            //stampo la ricerca sul txtRicerca
            

        }

        private void btn_ricercaAutore_Click(object sender, RoutedEventArgs e)
        {

            //stessa cosa della ricerca per titolo

        }

        private void btn_CreaLibro_Click(object sender, RoutedEventArgs e)
        {

            int numPagine = int.Parse(txtPagine.Text);
            string titolo = txtTitolo.Text;
            string autore = txtAutore.Text;
            string editore = txtEditore.Text;
            int anno = int.Parse(txtAnno.Text);

            Libro newLibro = new Libro(autore, titolo, anno, editore, numPagine);
            libri.Add(newLibro);

        }
    }
}
