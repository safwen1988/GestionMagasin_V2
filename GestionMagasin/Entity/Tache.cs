using GestionMagasin.Pages;
using System.ComponentModel.DataAnnotations;

namespace GestionMagasin.Entity
{
    public class Tache
    {
        
        [Required(ErrorMessage = "Veuillez Choisir l'ID du Tachnicien")]
        public string Id_Technicien { get; set; }
        [Required(ErrorMessage = "Veuillez Choisir le numéro de série du produit")]
        public string Id_Produit { get; set; }
        [Required(ErrorMessage ="Veuillez introduire le nom du Client")]
        public string Nom_Client { get; set; }
        [Required(ErrorMessage = "Veuillez introduire le prénom du Client")]
        public string Prenom_Client { get; set; }
        [Required(ErrorMessage = "Veuillez choisir la Tache à saisir")]
        public string Type_Tache { get; set; }
       


        public int Reparation(int dd)
        {
            return dd;
        }
        public int Affutage_Fartage(int s)
        {
            return (s * 20) / 15;
        }
        public int Revision_Annuelle(int v)
        {
            return (v * 50) / 45;
        }

    }
}
