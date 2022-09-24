namespace Karma.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sneakers> Sneakers { get; set; }
    }
}
