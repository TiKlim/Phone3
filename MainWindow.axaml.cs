using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Phone3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            a1.Click += ClickHandler;
        }
        private void ClickHandler(object sender, RoutedEventArgs args)
        {
            string nom1 = "1";
            string nom2 = "2";
            string nom3 = "3";
            string nom4 = "4";
            string nom5 = "5";
            string nom6 = "6";
            string nom7 = "7";
            string nom8 = "8";
            string nom9 = "9";
            string nom10 = "0";
            message.Text = nom1;
        }
    }
}