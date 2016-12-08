using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
//
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
namespace AvoidTheShapes
{
    public class Square : Shapes
    {
        //Variabelen
        public Rectangle rect;
        public Square(int initialX, int initialY,int initialWidth, int initialHeight, int initialSpeed)
        {
            x = initialX;
            y = initialY;
            height = initialHeight;
            width = initialWidth;
            speed = initialSpeed;
            
        }
        public override void CreatePhysicalShape(Canvas canCanvas)
        {
            rect = new Rectangle();
            rect.Height = height;
            rect.Width = width;
            rect.Margin = new Thickness(x, y, 0, 0);
            rect.Fill = new SolidColorBrush(Colors.Yellow);
            canCanvas.Children.Add(rect);
        }

        public override void updatePhysicalShape()
        {
            rect.Margin = new Thickness(x, y, 0, 0);
        }
    }
}
