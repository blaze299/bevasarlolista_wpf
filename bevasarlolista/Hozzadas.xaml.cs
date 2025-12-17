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

namespace bevasarlolista
{
    public partial class Hozzadas : Window
    {
        public ItemModel ujtermek;
        public Hozzadas()
        {
            InitializeComponent();
        }

        private void ok(object sender, RoutedEventArgs e)
        {


            ujtermek = new ItemModel(
                nev.Text,
                int.Parse(mennyiseg.Text),
                int.Parse(egysegar.Text),
                tipus.Text
            );
            DialogResult = true;
        }

        private void megse(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
