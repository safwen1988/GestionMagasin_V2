namespace GestionMagasin.Entity
{
    public class Clients
    {
        //public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string téléphone { get; set; }

        public Clients() { }


        public static List<Clients> clients = new List<Clients>
    {
        new Clients {nom="Cole",prenom="A",mail="Am@gmail.com",téléphone="0766768400"},
        new Clients {nom="AFFD",prenom="V",mail="V@gmail.com",téléphone="0766768400"},
        new Clients {nom="BBBBBB",prenom="H",mail="Hm@gmail.com",téléphone="0766768400"},
        new Clients {nom="DDDD",prenom="J",mail="N@gmail.com",téléphone="0766768400"},
        new Clients {nom="OOOO",prenom="K",mail="NJJJJJ@gmail.com",téléphone="0766768400"},
        new Clients {nom="OKJJJJ",prenom="D",mail="BNNm@gmail.com",téléphone="0766768400"},
        new Clients {nom="DTTTT",prenom="S",mail="Debym@gmail.com",téléphone="0766768400"},
        new Clients {nom="WAWAWAW",prenom="Y",mail="Duchym@gmail.com",téléphone="0766768400"},
        new Clients {nom="HHHHHH",prenom="K",mail="uchym@gmail.com",téléphone="0766768400"},
        new Clients {nom="VV",prenom="M",mail="DebGG@gmail.com",téléphone="0766768400"},
        new Clients {nom="YY",prenom="P",mail="DLLLLuchym@gmail.com",téléphone="0766768400"}
    };
    }
}
