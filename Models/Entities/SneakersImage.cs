namespace Karma.Models.Entities
{
    public class SneakersImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }

        public int SneakersId { get; set; }

        [ForeignKey("SneakersId")]
        public Sneakers Sneakers { get; set; }
    }
}
