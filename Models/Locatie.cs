namespace Proiect_MPD.Models
{
    public class Locatie
    {
        public int ID { get; set; }
        public string LocatieName { get; set; }
        public ICollection <Overview>? Overviews { get; set; }
    }
}
