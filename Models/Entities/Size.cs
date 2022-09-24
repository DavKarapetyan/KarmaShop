namespace Karma.Models.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public int SizeNumber { get; set; }
        public ICollection<SneakersSize> SneakersSizes { get; set; }
    }
}
