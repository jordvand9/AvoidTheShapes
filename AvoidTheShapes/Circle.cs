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
        public Random rnd = new Random();




        public Circle(int initialX, int initialY, int initialHeight, int initialSpeed)
        {
            x = initialX;
            y = initialY;
            height = initialHeight;
            width = initialHeight;
            speed = initialSpeed;


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
            y += speed * (Convert.ToInt32(MainWindow.difficulty));

            ellipse.Margin = new Thickness(x, y, 0, 0);
            endCanvasReached();

        }
        //public override void CheckHit(Player user)
        //{
        //    if (((Y + Height) > (user.Y)) &&
        //        ((X > user.X) || ((X + Width) > user.X)) && //hier aangepast
        //                                                    //(Y < (user.Y + user.Height)) &&
        //        ((X < (user.X + user.Width)) || ((X + Width) < (user.X + user.Width))))
        //    {
        //        user.Dead = true;
        //        MessageBox.Show("BOOM!");
        //    }
        //}
        public override void endCanvasReached()
        {
            if (Y + (Height * 2) >= 750)
            {
                x = rnd.Next(0, 1000);
                y = 0;
                updatePhysicalShape();
                int randomHoogte = rnd.Next(20, 95);
                int randomBreedte = rnd.Next(20, 95);
                
                ellipse.Height = randomHoogte;
                ellipse.Width = randomHoogte;
                Height = randomHoogte;
                Width = randomHoogte;
            }

        }

    }
}
