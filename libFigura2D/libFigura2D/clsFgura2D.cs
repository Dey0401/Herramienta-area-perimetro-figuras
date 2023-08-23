using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFigura2D
{
    public abstract class clsFgura2D
    {
        #region Atributes
        protected float fltArea;
        protected float fltPerimetro;
        protected string strError;
        #endregion

        #region Properties 
        public float Area
        {
            get { return fltArea; }
        }

        public float Perimetro
        {
            get { return fltPerimetro; }
        }

        public string Error
        {
            get { return strError; }
        }
        #endregion

        #region Methots public
        public abstract bool hallaArea();
        public abstract bool hallaPerimetro();
        
        #endregion


    }
}
