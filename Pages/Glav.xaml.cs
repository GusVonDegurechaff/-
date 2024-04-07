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
using Акцесвпф.Pages;

namespace Акцесвпф.Pages
{
    /// <summary>
    /// Логика взаимодействия для Glav.xaml
    /// </summary>
    public partial class Glav : Page
    {
        public Glav()
        {
            InitializeComponent();
        }

        private void OpenSearchId(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Эта кнопка пока что не работает");
        }

        private void OpenPrice(object sender, RoutedEventArgs e)
        {
            Classes.Helper.frame.Navigate(new Pages.OpenPriceWork());
        }

        private void OpenInfAbTalkbtn(object sender, RoutedEventArgs e)
        {
            
            Classes.Helper.frame.Navigate(new Pages.InfAbTalk());
        }
    }
}
