using Pustok_Start.Models;

namespace Pustok_Start.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Book> BestSellerBooks { get; set; }

        public List<Book> NewBooks { get; set; }
        public List<Book> DiscountBooks { get; set; }
    }
}