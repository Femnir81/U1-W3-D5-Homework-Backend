using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U1_W3_D5_Homework_Backend
{
    public partial class Articolo
    {
        public int IdArticolo { get; set; }
        public string Nome { get; set; }
        public string UrlImmagine { get; set; }
        public string Descrizione { get; set;}
        public double Prezzo { get; set; }

        public static List<Articolo> ListaArticoli { get; set;} = new List<Articolo>();

        public static List<Articolo> Carrello { get; set; } = new List<Articolo>();

        public static List<Articolo> GetLista()
        {
            Articolo articolo1 = new Articolo { IdArticolo = 1, Nome = "La slitta di Babbo Natale", UrlImmagine = "~/Assets/SlittaBabboNatale.png", Descrizione = "Ricevi una visita garantita da Babbo Natale! La slitta di Babbo Natale LEGO® è il regalo pre-natalizio perfetto per portare allegria natalizia in tutte le case. Grandi e piccini adoreranno costruire ed esporre la slitta decorata, che viene fornita con 4 renne.", Prezzo = 39.99 };
            Articolo articolo2 = new Articolo { IdArticolo = 2, Nome = "Ognuno è meraviglioso", UrlImmagine = "~/Assets/PoliticallyCorrect.png", Descrizione = "Costruisci il tuo tributo alla positività e alla gentilezza con questo kit di costruzione Ognuno è meraviglioso LEGO®. Questo display costruibile dai colori sgargianti include 11 minifigure monocromatiche su uno sfondo arcobaleno.", Prezzo = 34.99 };
            Articolo articolo3 = new Articolo { IdArticolo = 3, Nome = "Macchina del tempo Ritorno al futuro", UrlImmagine = "~/Assets/DeLorean.png", Descrizione = "Fan di Ritorno al futuro, è arrivato un fantastico progetto: il kit di costruzione per adulti del modello della Macchina del tempo Ritorno al futuro LEGO®. Soddisfa la tua passione per una delle trilogie cinematografiche più amate al mondo costruendo una delle 3 versioni di macchina del tempo.", Prezzo = 199.99 };
            Articolo articolo4 = new Articolo { IdArticolo = 4, Nome = "Titanic LEGO®", UrlImmagine = "~/Assets/Titanic.png", Descrizione = "Sin da quando il Titanic salpò per il suo fatidico viaggio inaugurale nel 1912, la famosa nave ha catturato l'immaginazione di tutto il mondo. Adesso puoi renderle omaggio con questo colossale progetto di costruzione del modello costruibile del Titanic LEGO®.", Prezzo = 679.99 };
            Articolo articolo5 = new Articolo { IdArticolo = 5, Nome = "Hogwarts Express™ - Edizione del collezionista", UrlImmagine = "~/Assets/StazioneHarryPotter.png", Descrizione = "Cattura la magia delle storie di Harry Potter™ con una replica costruibile, in scala 1:32 del veicolo più rappresentativo del Mondo Magico. Hogwarts Express™ - Edizione del collezionista LEGO® Harry Potter è un progetto di costruzione ed esposizione spettacolare per gli appassionati adulti di Harry Potter, che lascerà incantati tutti coloro che lo vedono.", Prezzo = 499.99 };
            Articolo articolo6 = new Articolo { IdArticolo = 6, Nome = "Robot Inventor", UrlImmagine = "~/Assets/Robots.png", Descrizione = "Entra nello straordinario mondo fisico e digitale dei robot programmabili e telecomandati e delle creazioni intelligenti. Con LEGO® MINDSTORMS® Robot Inventor, i giovani appassionati di robot possono utilizzare l'app LEGO® MINDSTORMS® Robot Inventor gratuita per costruire 5 esclusivi veicoli e robot motorizzati e animarli uno alla volta", Prezzo = 359.99 };
            ListaArticoli.Add(articolo1);
            ListaArticoli.Add(articolo2);
            ListaArticoli.Add(articolo3);
            ListaArticoli.Add(articolo4);
            ListaArticoli.Add(articolo5);
            ListaArticoli.Add(articolo6);
            return ListaArticoli;
        } 
    }
}