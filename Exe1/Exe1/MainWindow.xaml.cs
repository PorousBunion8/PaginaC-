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

namespace Exe1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            // Ocultar o Grid de login
            LoginGrid.Visibility = Visibility.Collapsed;

            // Mostrar o Frame e navegar para a nova página
            MainFrame.Visibility = Visibility.Visible;
            MainFrame.Navigate(new Page1());
        }
    }
}
