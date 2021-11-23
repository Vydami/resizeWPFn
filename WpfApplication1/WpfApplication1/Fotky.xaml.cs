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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Fotky.xaml
    /// </summary>
    public partial class Fotky : Window
    {
        
        public Fotky()
        {
            InitializeComponent();
            int cislo = MainWindow.fotkanumb;
            if (cislo == 0)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/zf.png", UriKind.Relative));
            }
            if (cislo == 1)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/RCc.jpg", UriKind.Relative));
            }
            if (cislo == 2)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/RCc.jpg", UriKind.Relative));
            }
            if (cislo == 3)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/RCc.jpg", UriKind.Relative));
            }
            if (cislo == 4)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/RCc.jpg", UriKind.Relative));
            }
            if (cislo == 5)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/zf.png", UriKind.Relative));
            }
            if (cislo == 6)
            {
                obrazek.Source = new BitmapImage(new Uri(@"img/RCc.jpg", UriKind.Relative));
            }
          
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            MainWindow.otvorene--;
        }
    }
}
