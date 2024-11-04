using System.ComponentModel.DataAnnotations;
namespace WebApplication2
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Range(0, 10000)]
        public double Price { get; set; }
    }
}
