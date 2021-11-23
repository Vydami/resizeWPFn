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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listcollection.Clear();
            foreach (string str in idBox.Items)
            {
                listcollection.Add(str);
            }


            bindLB();
            opravy();
            a++;
            menoZadavatela();
        }



//-------------------------PREMENNÉ----------------------------------------------------------//


        private readonly string[] ids = { "3314", "1221", "4845", "9766", "7777" };
        string[] fids = { "" };
        string datum = "19.12.1996";
        string meno = "Jozef Kurdiš";
        int a = 1;

//-------------------------PREMENNÉ----------------------------------------------------------//

        private void bindLB()
        {
            idBox.ItemsSource = ids;
            
        }


        private void menoZadavatela()
        { 
        lblName.Content = "Zadávateľ opravy: " + meno +"\n"+ "Dátum zadania: " + datum;

        }




//-------------------------PREMENNÉ----------------------------------------------------------//

        private void opravy()
        {
            if (a == 10)
            { 
                OJO.IsEnabled = true;
                OJO.IsChecked = true;
            }
            else
            {
                OJO.IsChecked = false;

            }
            
        }
        public static int fotkanumb = 0;
         public static int otvorene;

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (otvorene < 6)
            {
                fotkanumb = 1;
                Fotky nW = new Fotky();
                nW.Show();
                fotkanumb = 0;
                otvorene++;
            }
            else
            {
                MessageBox.Show("Pozatváraj si predošlé okná s fotkami!");
            }
        }
        
        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (otvorene < 6)
            {
                fotkanumb = 2;
                Fotky nW = new Fotky();
                nW.Show();
                fotkanumb = 0;
                otvorene++;
            }
            else
            {
                MessageBox.Show("Pozatváraj si predošlé okná s fotkami!");
            }
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            if (otvorene < 6)
            {
                fotkanumb = 3;
                Fotky nW = new Fotky();
                nW.Show();
                fotkanumb = 0;
                otvorene++;
            }
            else
            {
                MessageBox.Show("Pozatváraj si predošlé okná s fotkami!");
            }
        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            if (otvorene < 6)
            {
                fotkanumb = 4;
                Fotky nW = new Fotky();
                nW.Show();
                fotkanumb = 0;
                otvorene++;
            }
            else
            {
                MessageBox.Show("Pozatváraj si predošlé okná s fotkami!");
            }
        }

        private void Image_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            if (otvorene < 6)
            {
                fotkanumb = 5;
                Fotky nW = new Fotky();
                nW.Show();
                fotkanumb = 0;
                otvorene++;
            }
            else
            {
                MessageBox.Show("Pozatváraj si predošlé okná s fotkami!");
            }
        }

        private void Image_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            if (otvorene < 6)
            {
                fotkanumb = 6;
                Fotky nW = new Fotky();
                nW.Show();
                fotkanumb = 0;
                otvorene++;
            }
            else
            {
                MessageBox.Show("Pozatváraj si predošlé okná s fotkami!");
            }
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        List<string> listcollection = new List<string>();

        private void txtbx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbx.Text) == false)
            {
                idBox.ItemsSource = fids;
                //idBox.Items.clear();
                foreach (string str in listcollection)
                {
                    if (str.StartsWith(txtbx.Text))
                    {
                        idBox.Items.Add(str);
                    }
                }
            }
            else if (txtbx.Text == "")
            {
                idBox.Items.Clear();
                foreach (string str in listcollection)
                {
                    idBox.Items.Add(str);
                }
            }
        }
    }
}
