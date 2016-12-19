using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AvoidTheShapes
{
    public abstract class Shapes
    {
        //Private variabelen
        #region Variabelen
        protected int x, y, height, width, speed;
        Random rnd = new Random();
        #endregion
        //Constructor
        //Properties
        #region Properties
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                updatePhysicalShape();
            }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion


        //Methods
        public abstract void CreatePhysicalShape(Canvas CanCanvas);
        public abstract void updatePhysicalShape();
        public abstract void endCanvasReached();
        //public abstract void CheckHit(Player user);
        public virtual void CheckHit(Player user)
        {
            if (((Y + Height) > (user.Y)) &&
                ((X > user.X) || ((X + Width) > user.X)) && //hier aangepast
                                                            //(Y < (user.Y + user.Height)) &&
                ((X < (user.X + user.Width)) || ((X + Width) < (user.X + user.Width))))
            {
                //Remove(rect);
                user.Dead = true;
                X = rnd.Next(0, 1000);
                Y = 0;
                
                
                if (this.GetType() == typeof(Circle))
                {
                    AvoidTheShapesGame.points += 1;
                }
                else if (this.GetType() == typeof(Square))
                {
                    AvoidTheShapesGame.points -= 2;
                    MainWindow.lives -= 1;
                }
            }
        }

    }
}
