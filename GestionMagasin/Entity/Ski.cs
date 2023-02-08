using System.Security.Cryptography;

namespace GestionMagasin.Entity
    
{
    public class Ski : Produit
    {
        public string id_ski { get; set; }
        public Ski() { }

        public override int Réparation(int dd)
        {
            return dd;
        }
        public int Affutage_Fartage(int v)
        {
            return (v * 15) / 20;
        }
        public static List<Ski> skis = new List<Ski>
    {
        new Ski{id_ski="S120"},new Ski{id_ski="S125"},new Ski{id_ski="S330"},new Ski{id_ski="S580"},new Ski{id_ski="S750"},
        new Ski{id_ski="S1120"},new Ski{id_ski="S125"},new Ski{id_ski="S1330"},new Ski{id_ski="S1580"},new Ski{id_ski="S1750"},
        new Ski{id_ski="S2120"},new Ski{id_ski="S125"},new Ski{id_ski="S2330"},new Ski{id_ski="S2580"},new Ski{id_ski="S2750"},
        new Ski{id_ski="S3120"},new Ski{id_ski="S3125"},new Ski{id_ski="S3330"},new Ski{id_ski="S3580"},new Ski{id_ski="S3750"}
    };
    }
}
