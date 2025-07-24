using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2OOP
{
    internal struct Point
    {
        #region Atributes   
        public int x;
        public int y;
        #endregion
        #region Constructor
        //empty parameterless constructor C#9
        public Point()
        {
            x = default;
            y = default;
        }
        //C#10 copmiler will generate a constructor for us
        public Point(int _x, int _y)
        {
           x = _x;
           y = _y;
        }


        #endregion
        #region Methods

        public override string ToString()
        {
           return $"Point: ({x}, {y})";
        }

        #endregion
    }
}
