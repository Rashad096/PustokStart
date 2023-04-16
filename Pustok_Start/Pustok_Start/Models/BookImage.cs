namespace Pustok_Start.Models
{
    public class BookImage
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Iamge { get; set; }
        public bool? PosterStatus { get; set; }
        public Book Book { get; set; }


    }
}
