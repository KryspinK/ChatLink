using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ChatLink
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public MainWindow()
        {
            // How to convert Text Color
            /*BrushConverter converter = new BrushConverter();
            Brush brush = (Brush)converter.ConvertFromString("Black");
            welcome.Foreground = brush;*/

            InitializeComponent();
            
        }

        private void signIn(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Signing in ...");
            loading.Content = "Signing in ...";
            loading.Cursor = Cursors.No;
        }

      
        private void tbox1_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("Black");

            checkBox(tbox1);

            tbox1.Foreground = b;
           
    
            
        }

       


        private void tbox2_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("Black");

            checkBox(tbox2);

            tbox2.Foreground = b;
        }

        private void tbox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            clearBox(tbox1);
        }

        private void tbox2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            clearBox(tbox2);
        }

        private void tbox1_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("LightGray");

            if (tbox1.Text == "")
            {
                tbox1.Text = "Example";
                tbox1.Foreground = b;
            }

            
        }

        private void tbox2_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("LightGray");

            if (tbox2.Text == "")
            {
                tbox2.Text = "Example";
                tbox2.Foreground = b;
            }
        }

        private void checkBox(TextBox tb)
        {
            if (tb.Text == "Example")
            {
                tb.Text = "";
            }
            else
            {


            }
        }

        private void clearBox(TextBox tb)
        {
            tb.Text = "";

        }

    }
}
