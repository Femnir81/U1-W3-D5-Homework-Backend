using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U1_W3_D5_Homework_Backend
{
    public partial class Articolo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["idarticolo"];
            foreach (Articolo item in Articolo.ListaArticoli)
            {
                if (item.IdArticolo == Convert.ToInt32(id))
                {
                    ImmagineArticolo.ImageUrl = item.UrlImmagine;
                    titoloArticolo.InnerHtml = item.Nome;
                    descrizioneArticolo.InnerHtml = item.Descrizione;
                    prezzoArticolo.InnerHtml = $"{item.Prezzo.ToString("c2")}";                   
                }
            }
        }

        protected void AggiungiAlCarrello(object sender, EventArgs e)
        {
            string id = Request.QueryString["idarticolo"];
            foreach (Articolo item in Articolo.ListaArticoli)
            {
                if (item.IdArticolo == Convert.ToInt32(id))
                {
                    Articolo.Carrello.Add(item);
                }
            }
        }
    }
}