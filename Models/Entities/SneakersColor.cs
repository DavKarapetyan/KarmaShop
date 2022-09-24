global using System.ComponentModel.DataAnnotations.Schema;
namespace Karma.Models.Entities
{
    public class SneakersColor
    {
        public int Id { get; set; }
        [ForeignKey("Sneakers")]
        public int SneakersId { get; set; }
        public Sneakers Sneakers { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
