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
        public int Affutage_Fartage(int v)
        {
            return (v * 15) / 20;
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
