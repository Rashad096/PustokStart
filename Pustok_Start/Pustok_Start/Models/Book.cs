using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pustok_Start.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        [Column(TypeName ="money")]

        public decimal SalePrice { get; set; }
        [Column(TypeName = "money")]

        public decimal CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal DiscountPrice { get; set; }
        [Required]
        public bool StookStatus { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsNew { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Modified { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; } 
        public ICollection<BookTag> BookTags { get; set; }
        public ICollection<BookImage> BookImages { get; set; }

    }
}
