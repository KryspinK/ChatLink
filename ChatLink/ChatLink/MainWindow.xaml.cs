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
        DBconnection databaseConnection;

        


        public MainWindow()
        {
            // How to convert Text Color
            /*BrushConverter converter = new BrushConverter();
            Brush brush = (Brush)converter.ConvertFromString("Black");
            welcome.Foreground = brush;*/

            InitializeComponent();
            databaseConnection = new DBconnection();

        }

        private void signIn(object sender, RoutedEventArgs e)
        {

            if (databaseConnection.getIsConnect() == false)
            {
                BrushConverter converter = new BrushConverter();
                Brush b = (Brush)converter.ConvertFromString("Red");
                loading.Foreground = b;
                loading.Content = "Not Connected to Server ...";

            }
            else
            {
                Console.WriteLine("Signing in ...");
                loading.Content = "Signing in ...";
                loading.Cursor = Cursors.No;
                databaseConnection.getUsers();

            }

       
            
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

        private void tbox3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            clearBox(tbox3);
        }

        private void tbox1_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("LightGray");

            if (tbox1.Text == "" && tbox1.IsFocused == false)
            {
                tbox1.Text = "Username";
                tbox1.Foreground = b;
     
            }
            



        }

        private void tbox2_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("LightGray");

            if (tbox2.Text == ""  && tbox2.IsFocused == false)
            {
                tbox2.Text = "Password";
                tbox2.Foreground = b;
                
            }
        }

        private void checkBox(TextBox tb)
        {
            if (tb.Text == "Username")
            {
                tb.Text = "";
            }
            else if (tb.Text == "Password")
            {
                tb.Text = "";
            }else if (tb.Text == "First Name")
            {
                tb.Text = "";
            }

        }

        private void clearBox(TextBox tb)
        {
            tb.Text = "";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            databaseConnection.CloseConnection();
            firstName.Visibility = Visibility.Visible;
            tbox3.Visibility = Visibility.Visible;
            welcome.Content = "Register Page";

        }

        private void tbox3_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("Black");

            checkBox(tbox3);
            tbox3.Foreground = b;
        }

        private void tbox3_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter converter = new BrushConverter();
            Brush b = (Brush)converter.ConvertFromString("LightGray");

            if (tbox3.Text == "" && tbox3.IsFocused == false)
            {
                tbox3.Text = "First Name";
                tbox3.Foreground = b;

            }
        }




    }
}
