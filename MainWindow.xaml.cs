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

namespace Tema2_Imagen
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

        private void OpacidadMediaClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Opacity = 0.5;
        }

        private void OpacidadBajaClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Opacity = 0;
        }

        private void OpacidadAltaClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Opacity = 1;
        }

        private void AjusteRellenoClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Stretch = Stretch.Fill;
        }

        private void AjusteUniformeClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Stretch = Stretch.Uniform;
        }

        private void AjusteRellenoUniformeClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Stretch = Stretch.UniformToFill;
        }

        private void AjusteSinAjusteClicked(object sender, RoutedEventArgs e)
        {
            ImagenBox.Stretch = Stretch.None;
        }
    }
}
