using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libClasifFiguras;
namespace libFiguras
{
    public class ClsTriangulo : clsPoligono
    {
        #region Atribues
        private float fltLado2;
        private float fltAngulo;
        #endregion

        #region Constructor
        public ClsTriangulo()
        {
            fltLado1 = 0;
            fltLado2 = 0;
            fltAngulo = 0;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }

        public ClsTriangulo(float Lado1, float Lado2, float Angulo)
        {
            fltLado1 = Lado1;
            fltLado2 = Lado2;
            fltAngulo = Angulo;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        #endregion

        #region Properties
        public float Lado2 
        {  set => fltLado2 = value; }

        public float Angulo
        { set => fltAngulo = value; }
        #endregion

        #region Privates Methots 
        private bool validar()
        {
            if (fltLado1 <= 0)
            {
                strError = "Error, lado uno no valido";
                return false;
            }

            else if (fltLado2 <= 0)
            {
                strError = "Error, lado dos no valido";
                return false;
            }
            else if (fltAngulo <= 0)
            {
                strError = "Error, angulo no valido";
                return false;
            }
            else
            {
                return true;
            }
            
        }
        #endregion

        #region Public Methots
        public override bool hallaArea()
        {
            if (!validar())
             return false; 
            try
            {
                float h = fltLado1 * (float)Math.Sin((fltAngulo));

                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        public override bool hallaPerimetro()
        {
            if (!validar())
                return false;
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
