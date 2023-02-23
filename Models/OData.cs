namespace Proiect_MPD.Models
{
    public class OData
    {
        public IEnumerable<Overview> Overviews { get; set; }
        public IEnumerable<Cursa> Curse { get; set; }
        public IEnumerable<Locatie> Locatii { get; set; }
        public IEnumerable<Categorie> Categorii { get; set; }

    }
}
