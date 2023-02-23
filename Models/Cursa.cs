namespace Proiect_MPD.Models
{
    public class Cursa
    {
        public int ID { get; set; }
        public string CursaName { get; set; }
        public ICollection<Overview>? Overviews { get; set; }
    }
}
