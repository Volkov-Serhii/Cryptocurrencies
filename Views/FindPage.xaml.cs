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

namespace Cryptocurrencies.Views
{
    public partial class FindPage : Page
    {
        public FindPage(ApplicationViewModel DATA)
        {
            InitializeComponent();
            DataContext = DATA;
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FindPage((ApplicationViewModel)DataContext));
        }
    }
}
