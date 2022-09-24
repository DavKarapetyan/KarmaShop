namespace Karma.Models.Entities
{
    public class Sneakers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? PreviousPrice { get; set; }
        public string Description { get; set; }
        public int ProductCount { get; set; }
        public bool isLiked { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<SneakersColor> SneakersColors { get; set; }
        public ICollection<SneakersSize> SneakersSizes { get; set; }
        public ICollection<SneakersImage> SneakersImages { get; set; }
    }
}
