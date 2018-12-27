using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SayHello
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        Random rand;

        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
        }

        private byte[] GetRandomBytes(int n)
        {
            //fill an array of bytes length "n" with random numbers
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);

            return randomBytes;
        }

        private void BtnSayHello_Click(object sender, RoutedEventArgs e)
        {

            byte[] rgb = GetRandomBytes(3);

            //create a solid bolor brush using the three random numbers
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255,rgb[0],rgb[1],rgb[2]));

            //set both the text color and the text box border to the random color
            txtText.BorderBrush = randomColorBrush;
            txtText.Foreground = randomColorBrush;

        }
    }
}
