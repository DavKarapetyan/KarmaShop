namespace Karma.Models.Entities
{
    public class SneakersSize
    {
        public int Id { get; set; }
        [ForeignKey("Sneakers")]
        public int SneakersId { get; set; }
        public Sneakers Sneakers { get; set; }
        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
