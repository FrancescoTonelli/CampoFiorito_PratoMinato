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
using System.IO;

namespace PratoFiorito
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Campo campo;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Start()
        {
            btn00.Content = "";

            campo = new Campo();
            cmbChose.Items.Clear();
            cmbChose.Items.Add("Indicatore");
            cmbChose.Items.Add("Bandierina");
        }

        private void btn00_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            char[] x = b.Name.ToCharArray();
            int c = int.Parse(x[3].ToString());
            int z = int.Parse(x[4].ToString());
            if(campo.griglia[c, z] != -1)
            {
                b.Content = campo.griglia[c, z];
            }
            else
            {
                b.Background = Brushes.Red;
            }
        }
    }
}
