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
using Validacja.ViewModel;

namespace Validacja
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MW_ViewModel Viewmodel { get; set; }
        public MainWindow()
        {
            Viewmodel = new MW_ViewModel();
            DataContext = Viewmodel;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*Testowanie Validacji */

            var result = Viewmodel.Validation.Validate(Viewmodel.MW_Model);
            /*Wyświetlanie powiadomień błędu */
               Errors.Text = string.Join("|", result.Errors);
            if (result.IsValid)
                MessageBox.Show("Wszystko OK!!!");
        }
    }
}
