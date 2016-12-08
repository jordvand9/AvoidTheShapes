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
            set { y = value;
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
            get { return speed;  }
            set { speed = value; }
        }
        #endregion


        //Methods
        public abstract void CreatePhysicalShape(Canvas CanCanvas);
        public abstract void updatePhysicalShape();
        public abstract void endCanvasReached();
        
    }
}
