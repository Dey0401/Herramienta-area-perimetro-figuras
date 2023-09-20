using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libFigura2D;

namespace libClasifFiguras
{
    public abstract class clsPoligono : clsFgura2D
    {
        #region Atributes
        protected float fltLado1;
        #endregion

        #region Properties
        public float Lado1 
        {
            set => fltLado1 = value;
        }
        #endregion
    }
    public abstract class clsCuadrilatero : clsPoligono
    {
    }

}
