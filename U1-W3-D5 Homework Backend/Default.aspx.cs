using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_Homework_Backend
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Articolo.GetLista().Clear();
                Articolo.GetLista();
                RepeatLego.DataSource= Articolo.ListaArticoli;
                RepeatLego.DataBind();
            }
        }

        //protected void AggiungiAlCarrello(object sender, EventArgs e)
        //{
            
        //}
    }
}