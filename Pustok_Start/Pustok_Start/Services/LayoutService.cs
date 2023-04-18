using Pustok_Start.DAL;
using Pustok_Start.Models;

namespace Pustok_Start.Services
{
    public class LayoutService
    {
        private readonly PustokDbContext _context;

        public LayoutService(PustokDbContext context)
        {
            _context = context;
        }
        public List<Genre>GetGenres()
        {
            return _context.Genres.ToList();
        }

        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
