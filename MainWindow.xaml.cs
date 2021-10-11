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

namespace Base64Coder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Model model = new();
        
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = model;
        }

        private void EncodeOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var encoded = Base64Encode(this.model.Input);
                this.model.Output = encoded;
            }
            catch (Exception exception)
            {
                this.model.Output = exception.ToString();
            }
        }

        private void DecodeOnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var decoded = Base64Decode(this.model.Input);
                this.model.Output = decoded;
            }
            catch (Exception exception)
            {
                this.model.Output = exception.ToString();
            }
        }
        
        private static string Base64Encode(string plainText) {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        
        private static string Base64Decode(string base64EncodedData) {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}