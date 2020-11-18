using System;
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
        public MainWindow()
        {
            InitializeComponent();
            Inizializzazione();
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

            }

        }

        private void btn_ricercaTitolo_Click(object sender, RoutedEventArgs e)
        {



        }

        private void btn_ricercaAutore_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
