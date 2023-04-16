using System.ComponentModel.DataAnnotations;

namespace Pustok_Start.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string FullName { get; set; }
    }
}
