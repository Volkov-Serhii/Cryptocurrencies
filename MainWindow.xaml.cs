using Cryptocurrencies.Views;
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

namespace Cryptocurrencies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
            MainFrame.Content = new MainPage((ApplicationViewModel)DataContext);
        }

        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.NavigationService.Navigate(new MainPage((ApplicationViewModel)DataContext));
        }

        private void FindPage_Click(object sender, RoutedEventArgs e)
        {
           MainFrame.NavigationService.Navigate(new FindPage((ApplicationViewModel)DataContext));
        }

        private void DetailsPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new DetailsPage((ApplicationViewModel)DataContext));
        }
    }
}
