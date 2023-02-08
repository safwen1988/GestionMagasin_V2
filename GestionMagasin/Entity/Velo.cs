namespace GestionMagasin.Entity
{
    public class Velo : Produit
    {
        public string id_velo { get; set; }
        public Velo() { }

        public override int Réparation(int dd)
        {
            return dd;
        }
        public int Revision_Annuelle(int s)
        {
            return (s * 45) / 50;
        }
       
        public static List<Velo> velos = new List<Velo>
    {
       new Velo{id_velo="S120"},new Velo{id_velo="S125"},new Velo{id_velo="S330"},new Velo{id_velo="S580"},new Velo{id_velo="S750"},
       new Velo{id_velo="S120"},new Velo{id_velo="S125"},new Velo{id_velo="S330"},new Velo{id_velo="S580"},new Velo{id_velo="S750"},
       new Velo{id_velo="S120"},new Velo{id_velo="S125"},new Velo{id_velo="S330"},new Velo{id_velo="S580"},new Velo{id_velo="S750"},
       new Velo{id_velo="S120"},new Velo{id_velo="S125"},new Velo{id_velo="S330"},new Velo{id_velo="S580"},new Velo{id_velo="S750"},
    };
    }
}
