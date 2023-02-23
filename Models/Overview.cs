using System.ComponentModel.DataAnnotations;

namespace Proiect_MPD.Models
{
    public class Overview
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Data nasterii")]
        public DateTime Varsta { get; set; }

        public int? CategorieID { get; set; }
        public Categorie? Categorie { get; set; }
        public int? CursaID { get; set; }
        public Cursa? Cursa { get; set; }
        public int? LocatieID { get; set; }
        public Locatie? Locatie { get; set; }

    }
}
