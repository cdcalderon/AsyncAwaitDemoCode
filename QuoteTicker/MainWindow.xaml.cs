using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace QuoteTicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void GetQuotesBtn_Click(object sender, RoutedEventArgs e)
        {
            GetQuotes();
        }

        private async void GetQuotes()
        {
            getQuotesBtn.IsEnabled = false;
            var result = await Task<string>.Run(() =>
            {
                Thread.Sleep(3000);
                return "Quotes Received Successfully";
            });

            getQuotesBtn.IsEnabled = true;
            statusMessageLabel.Content = result;
        }
    }
}
