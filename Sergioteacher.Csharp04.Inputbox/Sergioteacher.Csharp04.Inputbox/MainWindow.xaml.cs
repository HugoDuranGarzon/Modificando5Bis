using System;
using System.Collections.Generic;
using System.IO;
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

namespace Sergioteacher.Csharp04.Inputbox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WindowInput ventanaInput;
        public string data;
        public const string rutaPorDefecto = "";

        public MainWindow()
        {
            InitializeComponent();
            ventanaInput = new WindowInput(this);


        }

        private void BIntro_Click(object sender, RoutedEventArgs e)
        {
            ventanaInput.Show();
            this.Hide();
        }

        private void VentanaPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Application.Current.Shutdown();
        }

        private void VentanaPrincipal_Activated(object sender, EventArgs e)
        {
            
        }

        private void BRefrescar_Click(object sender, RoutedEventArgs e)
        {
            string[] files = Directory.GetFiles(data);
            foreach(string i in files){
                Tsalida.Text += i + " \r\n";
            }
        }
    }
}
