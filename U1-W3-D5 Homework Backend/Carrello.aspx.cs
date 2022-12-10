using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_Homework_Backend
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Articolo.Carrello.Count != 0)
                {
                    ContenitoreGriglia.Visible = true;
                    MessaggioCarrelloVuoto.Visible = false;
                    double totale = 0;
                    foreach (Articolo item in Articolo.Carrello)
                    {
                        totale += item.Prezzo;
                    } 
                    SommaArticoli.Text = $"Totale acquisti: {totale.ToString("c2")}";
                }
                else
                {
                    ContenitoreGriglia.Visible = false;
                    MessaggioCarrelloVuoto.Visible = true;
                    MessaggioCarrelloVuoto.Text = "Il carrello è vuoto, riempilo con qualche acquisto!";
                }
                GrigliaCarrello.DataSource = Articolo.Carrello;
                GrigliaCarrello.DataBind();
            }
        }

        protected void SvuotaCarrello(object sender, EventArgs e)
        {
            Articolo.Carrello.Clear();
            ContenitoreGriglia.Visible = false;
            MessaggioCarrelloVuoto.Visible = true;
            MessaggioCarrelloVuoto.Text = "Il carrello è vuoto, riempilo con qualche acquisto!";
        }
    }
}