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
            getQuotesBtn.IsEnabled = false;
            await Task.Run(() => Thread.Sleep(3000));
            getQuotesBtn.IsEnabled = true;
            statusMessageLabel.Content = "Quotes Received Successfully";

            //getQuotesBtn.IsEnabled = false;
            //var task = Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //});

            //task.ContinueWith((t) =>
            //{
            //    Dispatcher.Invoke(() =>
            //    {
            //        getQuotesBtn.IsEnabled = true;
            //        statusMessageLabel.Content = "Quotes Received Successfully";
            //    });
            //});
        }


    }
}
