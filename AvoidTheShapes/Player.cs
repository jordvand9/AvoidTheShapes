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
    
    public class Player
    {
        //vars
        public Rectangle play;
        private int x=580, y=615;
        private int p;

        //
        
        public void CreatePhysicalShape(Canvas canCanvas)
        {
            play = new Rectangle();
            play.Height = 20;
            play.Width = 100;
            play.Margin = new Thickness(x, y, 0, 0);
            play.Fill = new SolidColorBrush(Colors.Red);
            canCanvas.Children.Add(play);
        }
        





    }
}
