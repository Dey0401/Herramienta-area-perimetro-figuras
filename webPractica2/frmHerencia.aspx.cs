using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libClasifFiguras;
using libFigura2D;
using libFiguras;



namespace webPractica2
{
    public partial class frmHerencia : System.Web.UI.Page
    {
        #region Variables Globales
        static int intFig;
        static string strDir = "~/Imagenes/";
        static string strImagen;
        #endregion

        #region Metodos propios
        private void Mensaje(string texto)
        {
            this.lblMsj.Text = texto;
        }

        private void cargarImagen(string name)
        {
            strImagen = strDir + name + ".jpg";
            this.imgFiguras.ImageUrl = strImagen;
        }
        private void limpiarDatos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                  //  c.Text = string.Empty;
                }
            }
        }


        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Metoths propios
            if (!IsPostBack) //La primera vez que cargue la pagina 
            {
                
            }
            #endregion
        }

        protected void rblFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDatos();
            this.pnlTriangulo.Visible = false;
            this.pnlRectangulo.Visible = false;
            this.pnlRombo.Visible = false;
            intFig = this.rblFiguras.SelectedIndex + 1;

            switch (intFig)
            {
                case 1:
                    cargarImagen("triangulo");
                    this.pnlTriangulo.Visible = true;
                    this.txtLadoA.Focus();
                    break;
                case 2:
                    cargarImagen("rectangulo");
                    this.pnlRectangulo.Visible = true;
                    this.txtLado1.Focus();
                    break;

                default:
                    cargarImagen("rombo");
                    this.pnlRombo.Visible = true;
                    this.txtDiagMy.Focus();
                    break;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            float vr1, vr2, vr3, vrArea = 0, vrPerim = 0;
            Mensaje(string.Empty);
            try
            {
                switch (intFig)
                {
                    case 1:
                      vr1 = Convert.ToSingle(this.txtLadoA.Text);
                      vr2 = Convert.ToSingle(this.txtLadoB.Text);
                      vr3 = Convert.ToSingle(this.txtAngulo.Text);
                      ClsTriangulo oT = new ClsTriangulo(vr1, vr2, vr3);
                        if (! oT.hallaArea() || ! oT.hallaPerimetro())
                        {
                            Mensaje(oT.Error);
                            oT = null;
                            return;
                        }
                        vrArea = oT.Area;
                        vrPerim = oT.Perimetro;
                        oT = null;
                        break;
                    case 2:
                        vr1 = Convert.ToSingle(this.txtLado1.Text);

                        break;

                    default:
                  
                        this.txtDiagMy.Focus();
                        break;
                }
                this.lblArea.Text = vrArea.ToString();
                this.lblPerim.Text = vrPerim.ToString();
                this.pnlRpta.Visible = true;

            }
            catch (Exception ex)
            {
                Mensaje (ex.Message);
                throw;
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            rblFiguras_SelectedIndexChanged(null, null);
        }
    }
    
}