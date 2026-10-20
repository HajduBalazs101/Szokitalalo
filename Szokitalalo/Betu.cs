using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Szokitalalo
{
    class Betu :Button
    {
        private char megfejtes;
        public Betu(char megfejtes)
        {
            this.megfejtes = megfejtes;
            this.Content = "_";
            this.Background = Brushes.Gray;
            this.Margin = new System.Windows.Thickness(20);
            this.Width = 60;
            this.Height = 60;
            this.FontSize = 40;
        }
    }
}
