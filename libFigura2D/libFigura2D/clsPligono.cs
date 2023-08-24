using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFigura2D
{
    abstract class clsPligono : clsFgura2D
    {
        #region Atributes
        protected float fltLado1;
        #endregion
        public float Lado1 
        {
            set { fltLado1 = value; }
        }
    }
}
