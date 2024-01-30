using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Net.Http.Headers;

namespace Phone3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Butoon.Click += Butoon_Click;

       
        }

        private void Butoon_Click(object? sender, RoutedEventArgs e)
        {
            if (a9.IsChecked == true && a15.IsChecked == true && a16.IsChecked == true && a17.IsChecked == true && a18.IsChecked == true && a19.IsChecked == true && a20.IsChecked == true && a21.IsChecked == true)
            {
                message.Text = "1";
            }
            else if (a30.IsChecked == true && a31.IsChecked == true && a34.IsChecked == true && a35.IsChecked == true && a18.IsChecked == true && a19.IsChecked == true && a20.IsChecked == true && a21.IsChecked == true)
            {
                message.Text = "1";
            }
        }

        /*private void ClickHandler1(object sender, RoutedEventArgs args)
        {
            string nom1 = "1";           
            message.Text = nom1;
        }*/
    }
}