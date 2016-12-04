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
//Use for the CanceledEventArgs
using System.ComponentModel;

namespace AvoidTheShapes
{
    /// <summary>
    /// Interaction logic for AvoidTheShapesGame.xaml
    /// </summary>
    public partial class AvoidTheShapesGame : Window
    {
        private MainWindow otherWindow;
        public AvoidTheShapesGame(MainWindow Menu)
        {
            InitializeComponent();
            //Assign Closing to this window its closing event handler.
            Closing += AvoidTheShapesGame_Closing;
            //Assign mainwindow 
            otherWindow = Menu;
            //Show difficulty chosen in the mainwindow.
            label.Content = Menu.difficulty;
        }
        //Costum closing event handler.
        void AvoidTheShapesGame_Closing(object sender, CancelEventArgs e)
        {
            otherWindow.Show();
        }



    }
}
