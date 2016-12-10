using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AvoidTheShapes
{
    
    public class Player : User
    {
        //Variabelen
        public Rectangle play;

        //Constructor
        public Player(int initialX, int initialY, int initialHeight, int initialWidth)
        {
            x = initialX;
            y = initialY;
            height = initialHeight;
            width = initialWidth;
        }
        
        public override void CreatePhysicalShape(Canvas canCanvas)
        {
            play = new Rectangle();
            play.Height = 20;
            play.Width = 100;
            play.Margin = new Thickness(x, y, 0, 0);
            play.Fill = new SolidColorBrush(Colors.Red);
            canCanvas.Children.Add(play);
        }
        public void Move(int x)
        {
            X = x;
        }
        protected override void UpdatePhysicalShape()
        {
            play.Margin = new System.Windows.Thickness(X, Y, 0, 0);
            play.Width = Width;
            play.Height = Height;
        }






    }
}
