namespace Karma.Models.Entities
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SneakersColor> SneakersColors { get; set; }
    }
}
