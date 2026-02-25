using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kurs4
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

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
       
            Otgruzka otgruzka = new Otgruzka();
            otgruzka.Owner = this;
            otgruzka.ShowDialog(); 
                                         
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Towar towar = new Towar();
            towar.Owner = this;
            towar.ShowDialog();
        }

        private void btnPriem(object sender, RoutedEventArgs e)
        {
            Priemka priemka = new Priemka();
            priemka.Owner = this;
            priemka.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Spravochniki spravochniki = new Spravochniki();
            spravochniki.Owner = this;
            spravochniki.ShowDialog();
        }

      
    }
    
}