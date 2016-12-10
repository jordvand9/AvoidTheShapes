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
        private Shapes figuur1, figuur2, figuur3, figuur4,figuur5;
        private Player test;
        
        
        
        

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
            
            //Initializing timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(40);
            timer.Tick += Timer_Tick;
            maakShape();
            
                       
            

        }
        private void maakShape()
        {
            
            //Stop the timer
            timer.Stop();
            GameCanvas.Children.Clear();
            //Testshape
            figuur2 = new Square(200, 200, 50, 50,10);
            figuur2.CreatePhysicalShape(GameCanvas);
            
            figuur1 = new Circle(100, 100, 50,5);
            figuur1.CreatePhysicalShape(GameCanvas);

            figuur3 = new Square(400, 200, 20, 60, 8);
            figuur3.CreatePhysicalShape(GameCanvas);

            figuur4 = new Circle(600, 100, 80, 12);
            figuur4.CreatePhysicalShape(GameCanvas);

            figuur5 = new Square(800, 100, 100, 40, 2);
            figuur5.CreatePhysicalShape(GameCanvas);

            test = new Player(580,600,20,50);
            test.CreatePhysicalShape(GameCanvas);


            //Start timer function
            startShapeTimer();
            

        }
        private void startShapeTimer()
        {
            //Start the timer
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Move the shape 10 pixels and update this to the Y value.
            
            figuur1.updatePhysicalShape();
            figuur2.updatePhysicalShape();
            figuur3.updatePhysicalShape();
            figuur4.updatePhysicalShape();
            figuur5.updatePhysicalShape();
            
            

            label.Content = figuur1.Y + " " + figuur2.Y + " " + figuur3.Y + " " + figuur4.Y + " "+ figuur5.Y + " Difficulty " + MainWindow.difficulty;
            
           
            
        }
        //Costum closing event handler.
        void AvoidTheShapesGame_Closing(object sender, CancelEventArgs e)
        {
            otherWindow.Show();
        }
        





    }
}
