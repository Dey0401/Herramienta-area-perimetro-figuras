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
                float h = fltLado2 * (float)Math.Sin((fltAngulo) * 180f / Math.PI);
                fltArea = fltLado2 * h / 2f;
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
            float vrA = 0;
            if (!validar())
                return false;
            try
            {
                vrA = (float)(Math.Sqrt(Math.Pow(fltLado1,2)+ Math.Pow(fltLado2, 2)-
                    2f * fltLado1 * fltLado2 * Math.Cos(fltAngulo)*180f / Math.PI));
                fltPerimetro = fltLado1 + fltLado2 + vrA;
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

    public class ClsRectangulo : clsPoligono
    {
        #region Atribues
        private float fltLado2;
        #endregion

        #region Constructor
        public ClsRectangulo()
        {
            fltLado1 = 0;
            fltLado2 = 0;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }

        public ClsRectangulo(float Lado1, float Lado2)
        {
            fltLado1 = Lado1;
            fltLado2 = Lado2;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        #endregion

        #region Properties
        public float Lado2
        { set => fltLado2 = value; }

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
                fltArea = fltLado1  * fltLado2;
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
                fltPerimetro = 2f * fltLado1 + 2f * fltLado2;
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

    public class ClsRombo : clsPoligono
    {
        #region Atribues
        private float fltDDiagonalMenor;
        private float fltDiagonalMayor;
        #endregion

        #region Constructor
        public ClsRombo()
        {
            FltDDiagonalMenor = 0;
            FltDiagonalMayor = 0;
            fltLado1 = 0;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }

        public ClsRombo(float DiagonalMenor, float DiagonalMayor, float Lado1)
        {
            FltDDiagonalMenor = DiagonalMenor;
            FltDiagonalMayor = DiagonalMayor;
            fltLado1 = Lado1;
            fltArea = 0;
            fltPerimetro = 0;
            strError = string.Empty;
        }
        #endregion

        #region Properties
        public float FltDDiagonalMenor 
        { set => fltDDiagonalMenor = value; }
        public float FltDiagonalMayor 
        { set => fltDiagonalMayor = value; }
        #endregion

        #region Privates Methots 
        private bool validar()
        {
            if (fltLado1 <= 0)
            {
                strError = "Error, lado no valido";
                return false;
            }

            else if (fltDDiagonalMenor <= 0)
            {
                strError = "Error, diagonal menor no valida";
                return false;
            }
            else if (fltDiagonalMayor <= 0)
            {
                strError = "Error, diagonal mayor no valida";
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
                fltArea = (fltDiagonalMayor* fltDDiagonalMenor) / 2;
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
                fltPerimetro = 4*fltLado1;
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
