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
        readonly Uri uriBomba = new Uri("bomb.png", UriKind.Relative);
        readonly Uri uriBandiera = new Uri("flag.png", UriKind.Relative);

        Campo campo;
        Image immBomba;
        Image immFlag;

        public MainWindow()
        {
            InitializeComponent();
            
            immBomba = new Image();
            immBomba.Source = new BitmapImage(uriBomba);

            immFlag = new Image();
            immFlag.Source = new BitmapImage(uriBandiera);

            Start();
        }

        public void Start()
        {
            btn00.Content = "";
            btn01.Content = "";
            btn02.Content = "";
            btn03.Content = "";
            btn04.Content = "";
            btn05.Content = "";
            btn06.Content = "";
            btn07.Content = "";

            btn10.Content = "";
            btn11.Content = "";
            btn12.Content = "";
            btn13.Content = "";
            btn14.Content = "";
            btn15.Content = "";
            btn16.Content = "";
            btn17.Content = "";

            btn20.Content = "";
            btn21.Content = "";
            btn22.Content = "";
            btn23.Content = "";
            btn24.Content = "";
            btn25.Content = "";
            btn26.Content = "";
            btn27.Content = "";

            btn30.Content = "";
            btn31.Content = "";
            btn32.Content = "";
            btn33.Content = "";
            btn34.Content = "";
            btn35.Content = "";
            btn36.Content = "";
            btn37.Content = "";

            btn40.Content = "";
            btn41.Content = "";
            btn42.Content = "";
            btn43.Content = "";
            btn44.Content = "";
            btn45.Content = "";
            btn46.Content = "";
            btn47.Content = "";

            btn50.Content = "";
            btn51.Content = "";
            btn52.Content = "";
            btn53.Content = "";
            btn54.Content = "";
            btn55.Content = "";
            btn56.Content = "";
            btn57.Content = "";

            btn60.Content = "";
            btn61.Content = "";
            btn62.Content = "";
            btn63.Content = "";
            btn64.Content = "";
            btn65.Content = "";
            btn66.Content = "";
            btn67.Content = "";

            btn70.Content = "";
            btn71.Content = "";
            btn72.Content = "";
            btn73.Content = "";
            btn74.Content = "";
            btn75.Content = "";
            btn76.Content = "";
            btn77.Content = "";

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
            if(cmbChose.SelectedIndex >= 0 && cmbChose.SelectedItem.ToString() == "Indicatore")
            {
                if (campo.griglia[c, z] != -1)
                {
                    b.Content = campo.griglia[c, z];
                }
                else
                {
                    b.Background = Brushes.Red;
                    b.Content = immBomba;
                }
            }
            else if(cmbChose.SelectedIndex >= 0 && cmbChose.SelectedItem.ToString() == "Bandierina")
            {
                b.Content = immFlag;
            }
        }
    }
}
