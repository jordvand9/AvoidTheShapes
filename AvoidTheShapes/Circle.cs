using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace AvoidTheShapes
{
    public class Circle : Shapes
    {
        //Variabelen
        public Ellipse ellipse;
        
        public Circle (int initialX, int initialY,int initialHeight)
        {
            x = initialX;
            y = initialY;
            height = initialHeight;
            width = initialHeight;
        }
        public override void CreatePhysicalShape(Canvas canCanvas)
        {
            ellipse = new Ellipse();
            ellipse.Width = height;
            ellipse.Height = height;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Fill = new SolidColorBrush(Colors.Blue);
            canCanvas.Children.Add(ellipse);
            
        }
        public override void updatePhysicalShape()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }
    }
}
