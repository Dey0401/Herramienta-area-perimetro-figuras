using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libParcial2
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
        public bool guardar(string tipoFigura , string tipoOpera, float valor)
        {
            
            try
            {
                using (StreamWriter escritor = new StreamWriter(tipoFigura+".txt", true)) // El parámetro "true" indica modo de anexar
                {
                    escritor.WriteLine(valor + "-" + tipoOpera);
                }
                return true;
            }
            catch (IOException e)
            {
                strError = "Error al escribir en el archivo: ";
                return false;
            }
        }

        #endregion


    }
}
