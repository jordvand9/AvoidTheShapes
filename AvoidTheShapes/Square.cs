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
        private Random rnd = new Random();

        public Square(int initialX, int initialY, int initialWidth, int initialHeight, int initialSpeed)
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
            y += speed * (Convert.ToInt32(MainWindow.difficulty));
            rect.Margin = new Thickness(x, y, 0, 0);

            endCanvasReached();
        }
        //public override void CheckHit(Player user)
        //{
        //    if (((Y + Height) > (user.Y)) &&
        //        ((X > user.X) || ((X + Width) > user.X)) && //hier aangepast
        //        //(Y < (user.Y + user.Height)) &&
        //        ((X < (user.X + user.Width)) || ((X + Width) < (user.X + user.Width))))

        //    {
        //        MessageBox.Show("Hit!");
        //        //Remove(rect);
        //        user.Dead = true;


        //    }
        //}
        public override void endCanvasReached()
        {
            if (Y + (Height) >= 750)
            {
                y = 0;
                updatePhysicalShape();
                int randomHoogte = rnd.Next(20, 95);
                int randomBreedte = rnd.Next(20, 95);

                rect.Height = randomHoogte;
                rect.Width = randomBreedte;
                Height = randomHoogte;
                Width = randomBreedte;
                AvoidTheShapesGame.points += 1;


            }
        }
        public void Remove(Rectangle rect)
        {
            //Remove(rect);
        }
    }
}
