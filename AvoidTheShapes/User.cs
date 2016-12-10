using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AvoidTheShapes
{
    public abstract class User
    {
        //Private variabelen
        #region Variabelen 
        protected int x, y, height, width;
        #endregion
        //Properties
        #region Properties
        public int X
        {
            get { return x; }
            set { x = value; UpdatePhysicalShape(); }
        }
        public int Y
        {
            get { return y; }
            set { y = value;  }
        }
        public int Height
        {
            get { return height; }
            set { height = value;  }
        }
        public int Width
        {
            get { return width; }
            set { width = value;  }
        }

        #endregion
        //Methods
        public abstract void CreatePhysicalShape(Canvas CanCanvas);
        protected abstract void UpdatePhysicalShape();
    }
}
