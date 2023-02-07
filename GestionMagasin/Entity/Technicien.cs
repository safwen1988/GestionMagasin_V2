namespace GestionMagasin.Entity
{
    public class Technicien
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public int nombre_minutes_Travail { get; set; }

        public decimal total_tarif { get; set; }
       
        public Technicien() 
        { }
        public static List<Technicien> techniciens = new List<Technicien>
    {
        new Technicien {ID=1 ,Name="Debuchy",Prenom="Marcel",nombre_minutes_Travail=3000,total_tarif=4000},
        new Technicien {ID=2 ,Name="Camara",Prenom="Alain",nombre_minutes_Travail=5000,total_tarif=6000},
        new Technicien {ID=3 ,Name="Lemere",Prenom="Adel",nombre_minutes_Travail=8000,total_tarif=9000}
    };
    }
}
