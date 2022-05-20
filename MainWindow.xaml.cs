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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Light_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("light.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Dark_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("dark.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
