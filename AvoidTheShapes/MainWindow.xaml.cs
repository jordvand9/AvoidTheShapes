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

namespace AvoidTheShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int difficulty;
        public MainWindow()
        {
          
            InitializeComponent();
            //Geef window een fixed size en start in het midden van het scherm
            this.Height = 661;
            this.Width = 1045;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //Geef window een backgroundimage
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"../../Resources/muur.png", UriKind.RelativeOrAbsolute)));
            
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            difficulty = 1;
        }

        private void btnMedium_Click(object sender, RoutedEventArgs e)
        {
            difficulty = 2;
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            difficulty = 3;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
