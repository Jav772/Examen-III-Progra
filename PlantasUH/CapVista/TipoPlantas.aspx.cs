using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlantasUH.CapLogica;

namespace PlantasUH.CapVista
{
    public partial class CaracteristicasPlantas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTipo();
            }
        }


        private void CargarTipo()
        {
            var lista = Log_TipoPlantas.ObtenerTipo();
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }
    }
}