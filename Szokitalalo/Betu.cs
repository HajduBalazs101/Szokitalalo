using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Szokitalalo
{
    class Betu :Button
    {
        private char megfejtes;
        List<char> Betuk = new List<char>
        {
            '_', 'A', 'Á', 'B', 'C', 'D', 'E', 'É', 'F', 'G', 'H', 'I', 'Í', 'J', 'K',
            'L', 'M', 'N', 'O', 'Ó', 'Ö', 'Ő', 'P', 'Q', 'R', 'S', 'T', 'U', 'Ú',
            'Ü', 'Ű', 'V', 'W', 'X', 'Y', 'Z'
        };
        int index = 0;
        public Betu(char megfejtes)
        {
            this.megfejtes = megfejtes;
            this.Content = Betuk[0];
            this.Background = Brushes.LightGray;
            this.Margin = new System.Windows.Thickness(20);
            this.Width = 60;
            this.Height = 60;
            this.FontSize = 40;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
        
            if (index >= Betuk.Count - 1)
            {
                index = 0;
            }
            else
                index++;
            this.Content = Betuk[index];
            base.OnMouseLeftButtonDown(e);
        }
        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            if (index <= 0)
            {
                index = Betuk.Count - 1;
            }
            else
                index--;
            this.Content = Betuk[index];
            base.OnMouseRightButtonDown(e);
        }
    }
}
