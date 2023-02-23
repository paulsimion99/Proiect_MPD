namespace Proiect_MPD.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string CategorieName { get; set; }
        public ICollection<Overview>? Overviews { get; set; }
    }
}
