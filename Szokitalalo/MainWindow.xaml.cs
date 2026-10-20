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

namespace Szokitalalo
{
    public partial class MainWindow : Window
    {
        List<string> szavak = new List<string> { "ALMA", "KöRTE", "BARACK" };
        string veletlenSzo;
        public MainWindow()
        {
            InitializeComponent();
            Random r = new Random();
            string veletlenszo = szavak[r.Next(szavak.Count)];
            foreach(char s in veletlenszo)
            {
                kartyakhelye.Children.Add(new Betu(s, veletlenszo));
            }
        }

        private void UjSzo(object sender, RoutedEventArgs e)
        {
            kartyakhelye.Children.Clear();
            Random r = new Random();
            veletlenSzo = szavak[r.Next(szavak.Count)];
            foreach (char s in veletlenSzo)
            {
                kartyakhelye.Children.Add(new Betu(s, veletlenSzo));
            }
        }

        private void Ellenorzes(object sender, RoutedEventArgs e)
        {
            bool mindKitalalva = true;
            foreach (Betu b in kartyakhelye.Children)
            {

                if (!b.kitalalt())
                {
                    mindKitalalva = false;
                    break;
                }
            }

            if (mindKitalalva)
            {
                MessageBox.Show("Kitaláltad a szót");
            }
            else
            {
                MessageBox.Show("Még nem találtad ki a szót");
            }

        }
    }
}