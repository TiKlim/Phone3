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
            if (a30.IsChecked == true && a31.IsChecked == true && a34.IsChecked == true && a35.IsChecked == true && a42.IsChecked == true && a49.IsChecked == true && a56.IsChecked == true && a36.IsChecked == true && a43.IsChecked == true && a51.IsChecked == true && a52.IsChecked == true && a46.IsChecked == true && a40.IsChecked == true)
            {
                message.Text += "2";
            }
            if (a58.IsChecked == true && a64.IsChecked == true && a71.IsChecked == true && a79.IsChecked == true && a80.IsChecked == true && a74.IsChecked == true && a67.IsChecked == true && a82.IsChecked == true && a83.IsChecked == true && a70.IsChecked == true && a77.IsChecked == true && a62.IsChecked == true)
            {
                message.Text += "3";
            }
            if (a85.IsChecked == true && a86.IsChecked == true && a87.IsChecked == true && a88.IsChecked == true && a95.IsChecked == true && a102.IsChecked == true && a109.IsChecked == true && a105.IsChecked == true && a104.IsChecked == true && a103.IsChecked == true && a102.IsChecked == true && a101.IsChecked == true && a100.IsChecked == true)
            {
                message.Text += "4";
            }
            if (a113.IsChecked == true && a114.IsChecked == true && a115.IsChecked == true && a116.IsChecked == true && a120.IsChecked == true && a127.IsChecked == true && a134.IsChecked == true && a123.IsChecked == true && a130.IsChecked == true && a138.IsChecked == true && a139.IsChecked == true && a133.IsChecked == true && a126.IsChecked == true && a118.IsChecked == true)
            {
                message.Text += "5";
            }
            if (a142.IsChecked == true && a143.IsChecked == true && a144.IsChecked == true && a145.IsChecked == true && a146.IsChecked == true && a148.IsChecked == true && a155.IsChecked == true && a163.IsChecked == true && a154.IsChecked == true && a161.IsChecked == true && a167.IsChecked == true && a166.IsChecked == true && a158.IsChecked == true && a151.IsChecked == true)
            {
                message.Text += "6";
            }
            if (a170.IsChecked == true && a169.IsChecked == true && a176.IsChecked == true && a183.IsChecked == true && a190.IsChecked == true && a191.IsChecked == true && a192.IsChecked == true && a187.IsChecked == true && a188.IsChecked == true && a181.IsChecked == true && a182.IsChecked == true)
            {
                message.Text += "7";
            }
            if (a199.IsChecked == true && a198.IsChecked == true && a204.IsChecked == true && a211.IsChecked == true && a219.IsChecked == true && a220.IsChecked == true && a207.IsChecked == true && a214.IsChecked == true && a201.IsChecked == true && a202.IsChecked == true && a210.IsChecked == true && a217.IsChecked == true && a222.IsChecked == true && a223.IsChecked == true)
            {
                message.Text += "8";
            }
            if (a226.IsChecked == true && a227.IsChecked == true && a232.IsChecked == true && a239.IsChecked == true && a235.IsChecked == true && a242.IsChecked == true && a230.IsChecked == true && a238.IsChecked == true && a245.IsChecked == true && a247.IsChecked == true && a248.IsChecked == true && a249.IsChecked == true && a250.IsChecked == true)
            {
                message.Text += "9";
            }
            if (a254.IsChecked == true && a255.IsChecked == true && a256.IsChecked == true && a257.IsChecked == true && a258.IsChecked == true && a260.IsChecked == true && a266.IsChecked == true && a267.IsChecked == true && a273.IsChecked == true && a275.IsChecked == true && a276.IsChecked == true && a277.IsChecked == true && a278.IsChecked == true && a279.IsChecked == true)
            {
                message.Text += "0";
            }
        }

        /*private void ClickHandler1(object sender, RoutedEventArgs args)
        {
            string nom1 = "1";           
            message.Text = nom1;
        }*/
    }
}