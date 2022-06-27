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
using System.Xml;

namespace zad4
{
    /// <summary>
    /// Logika interakcji dla klasy SzczegółyGrupy.xaml
    /// </summary>
    public partial class Podkategorie : Window
    {
        public Podkategorie(XmlNode grupa)
        {
            DataContext = grupa;
            InitializeComponent();
        }
        private void Szczegóły(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)this.FindName("ListaModeli");
            XmlNode grupa = (XmlNode)lista.SelectedItem;
            if (grupa != null)
                new SzczegółyGrupy(grupa).Show();
        }
    }
}