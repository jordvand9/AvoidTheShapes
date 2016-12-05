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
//Using for timer
using System.Windows.Threading;

namespace AvoidTheShapes
{
    /// <summary>
    /// Interaction logic for AvoidTheShapesGame.xaml
    /// </summary>
    public partial class AvoidTheShapesGame : Window
    {
        private MainWindow otherWindow;
        private DispatcherTimer timer;
        private Shapes figuur1;
        private int x, y;
        
        public AvoidTheShapesGame(MainWindow Menu)
        {
            InitializeComponent();
            //Give window a fixed size and make it start in the middle of the screen
            this.Height = 720;
            this.Width = 1280;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            //Assign Closing to this window its closing event handler.
            Closing += AvoidTheShapesGame_Closing;
            //Assign mainwindow 
            otherWindow = Menu;
            //Show difficulty chosen in the mainwindow.
            label.Content = Menu.difficulty;
            //Initializing timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(40);
            timer.Tick += Timer_Tick;
            //Test
            startBalloonTimer();
            figuur1 = new Circle(100,100,50);
            figuur1.CreatePhysicalShape(GameCanvas);
            

        }
        private void startBalloonTimer()
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            y += 10;
            figuur1.Y = y;
        }
        //Costum closing event handler.
        void AvoidTheShapesGame_Closing(object sender, CancelEventArgs e)
        {
            otherWindow.Show();
        }



    }
}
