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

namespace Акцесвпф.Pages
{
    /// <summary>
    /// Логика взаимодействия для OpenPriceWork.xaml
    /// </summary>
    public partial class OpenPriceWork : Page
    {
        public OpenPriceWork()
        {
            InitializeComponent();
        }

        private void OpenGlavbtn(object sender, RoutedEventArgs e)
        {

            Classes.Helper.frame.Navigate(new Pages.Glav());
        }
    }
}
