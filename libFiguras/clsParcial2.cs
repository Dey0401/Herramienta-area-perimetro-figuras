using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using libClasifFiguras;
namespace libParcial2
    
{
    public abstract class Construcción
    {
        #region Atributes
        private int codConst;
        private string nombre;
        private string strError;
        #endregion

        #region Properties 
        protected int CodConst 
        {
            set => codConst = value;
            get => codConst;
        }
        protected string Nombre 
        {
            set => nombre = value;
            get => nombre; 
        }
        protected string StrError 
        {
            set => strError = value;
            get => strError; 
        }
        #endregion

        #region Methots public
        public abstract bool guardar();
        //{
            //try
            //{
            //    using (StreamWriter escritor = new StreamWriter(tipoFigura + ".txt", true)) // El parámetro "true" indica modo de anexar
            //    {
            //        escritor.WriteLine(valor + "-" + tipoOpera);
            //    }
            //    return true;
            //}
            //catch (IOException e)
            //{
            //    strError = "Error al escribir en el archivo: ";
            //    return false;
            //}
        //}
        #endregion


    }
    public abstract class Multiple : Construcción
    {
        #region Atribues
        private string tipo;
        private string zonaComun;
        #endregion

        #region Properties
        public string Tipo 
        { 
            get => tipo; 
        }
        public string ZonaComun 
        { 
            get => zonaComun;
        }
        #endregion

        #region Privates Methots 
        #endregion

        #region Public Methots
        #endregion
    }

    public class casa : Construcción
    {
        #region Atribues
        private int nroAlcobas;
        private string propietario;
        #endregion

        #region Constructor
        public casa()
        {
            CodConst = 0;
            Nombre = string.Empty;
            nroAlcobas = 0;
            propietario = string.Empty;
            StrError = string.Empty;
        }

        public casa(int numAlcobas, string nomPropietario)
        {
            CodConst = 0;
            Nombre = string.Empty;
            nroAlcobas = numAlcobas;
            propietario = nomPropietario;
            StrError = string.Empty;
        }
        #endregion

        #region Properties
        public int NroAlcobas 
        { 
            set => nroAlcobas = value; 
        }
        public string Propietario 
        { 
            set => propietario = value; 
        }
    

        #endregion

        #region Privates Methots 
        private bool validar()
        {
            if (nroAlcobas <= 0)
            {
                StrError = "Error, numero del alcobas no valido";
                return false;
            }

            if (propietario.Equals(string.Empty))
            {
                StrError = "Error, Propietario null";
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion

        #region Public Methots
        public override bool guardar()
        {
                try
                {
                    using (StreamWriter escritor = new StreamWriter("Construccion.txt", true)) // El parámetro "true" indica modo de anexar
                    {
                        escritor.WriteLine(CodConst + "#" + Nombre +"#"+nroAlcobas + "#" + propietario);
                    }
                    return true;
                }
                catch (IOException e)
                {
                    StrError = "Error al escribir en el archivo: ";
                    return false;
                }
        }
        #endregion
    }

    public class Residencial : Multiple
    {
        #region Atribues
        private int nroBloques;
        private bool enCerrada;
        #endregion

        #region Constructor
        public Residencial()
        {
            CodConst = 0;
            Nombre = string.Empty;
            nroBloques = 0;
            enCerrada = false;
            StrError = string.Empty;
        }

        public Residencial(bool ftCerrada, int numBloques)
        {
            CodConst = 0;
            Nombre = string.Empty;
            nroBloques = numBloques;
            enCerrada = ftCerrada;
            StrError = string.Empty;
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
                StrError = "Error, lado no valido";
                return false;
            }

            else if (fltDDiagonalMenor <= 0)
            {
                StrError = "Error, diagonal menor no valida";
                return false;
            }
            else if (fltDiagonalMayor <= 0)
            {
                StrError = "Error, diagonal mayor no valida";
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
                StrError = ex.Message;
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
                StrError = ex.Message;
                return false;
            }
        }
        #endregion
    }
    public class Edificio : Multiple
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
            StrError = string.Empty;
        }

        public ClsRombo(float DiagonalMenor, float DiagonalMayor, float Lado1)
        {
            FltDDiagonalMenor = DiagonalMenor;
            FltDiagonalMayor = DiagonalMayor;
            fltLado1 = Lado1;
            fltArea = 0;
            fltPerimetro = 0;
            StrError = string.Empty;
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
                StrError = "Error, lado no valido";
                return false;
            }

            else if (fltDDiagonalMenor <= 0)
            {
                StrError = "Error, diagonal menor no valida";
                return false;
            }
            else if (fltDiagonalMayor <= 0)
            {
                StrError = "Error, diagonal mayor no valida";
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
                fltArea = (fltDiagonalMayor * fltDDiagonalMenor) / 2;
                return true;
            }
            catch (Exception ex)
            {
                StrError = ex.Message;
                return false;
            }
        }

        public override bool hallaPerimetro()
        {

            if (!validar())
                return false;
            try
            {
                fltPerimetro = 4 * fltLado1;
                return true;
            }
            catch (Exception ex)
            {
                StrError = ex.Message;
                return false;
            }
        }
        #endregion
    }
}
