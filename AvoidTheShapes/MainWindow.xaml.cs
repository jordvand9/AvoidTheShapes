using System;
using System.Collections.Generic;
using System.IO;
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
        public static double difficulty = 1;
        public static double lives = 3;
        public MainWindow()
        {

            InitializeComponent();
            //Give window a fixed size and make it start in the middle of the screen
            this.Height = 661;
            this.Width = 1045;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //Assign a backgroundimage to the window
            this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Resources/muur.png", UriKind.RelativeOrAbsolute)));
            //
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string newFile = System.IO.Path.Combine(destination, "myfile.txt");
            StreamWriter outputStream = File.CreateText(newFile);

            outputStream.Close();
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            difficulty = 1;
            lives = 3;
        }

        private void btnMedium_Click(object sender, RoutedEventArgs e)
        {
            difficulty = 1.5;
            lives = 2;
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            difficulty = 2;
            lives = 1;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //Show second form and hide the mainwindow
            AvoidTheShapesGame GameWindow = new AvoidTheShapesGame(this);
            GameWindow.Show();
            this.Hide();
            AvoidTheShapesGame.points = 0;
            lives = 3;
        }
    }
}
