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

namespace PracticaAreaFiguras
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Btnrec_area_Click(object sender, RoutedEventArgs e)
        {
            double Base = double.Parse(boxrec_base.Text);
            double Altura = double.Parse(boxrec_altura.Text);
            double AreaRec = (Base * Altura);
            txtrec_resul.Text = AreaRec.ToString();
            
        }

        private void btntri_area_Click(object sender, RoutedEventArgs e)
        {
            double Base = double.Parse(boxtri_base.Text);
            double Altura = double.Parse(boxtri_altura.Text);
            double AreaTri = (Base * Altura) / 2;
            txttri_resul.Text = AreaTri.ToString();
        }

        private void Btncir_area_Click(object sender, RoutedEventArgs e)
        {
            double Radio = double.Parse(boxcir_radio.Text);

            double AreaCir = Math.PI * (Radio * Radio);
            txtcir_resul.Text = AreaCir.ToString();
        }

        private void Btntra_area_Click(object sender, RoutedEventArgs e)
        {
            double BaseMayor = double.Parse(boxtra_basemayor.Text);
            double BaseMenor = double.Parse(boxtra_basemenor.Text);
            double Altura = double.Parse(boxtra_altura.Text);

            double Areatra = ((BaseMayor + BaseMenor) / 2) * Altura;

            txttra_resul.Text = Areatra.ToString();
        }
    }
}
