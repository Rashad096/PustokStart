using System.ComponentModel.DataAnnotations;

namespace Pustok_Start.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public  ICollection<Book> Book  { get;set; }
    }
}
