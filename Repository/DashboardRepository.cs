using RunGroopWebApp.Data;
using RunGroopWebApp.Interface;
using RunGroopWebApp.Models;
using System.Security.Claims;

namespace RunGroopWebApp.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpcontextAccessor;
        public DashboardRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpcontextAccessor = httpContextAccessor;
        }
        public async Task<List<Club>> GetAllUserClubs()
        {
            var curUser = _httpcontextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userClubs =  _context.Clubs.Where(r => r.AppUser.Id == curUser.ToString());
            return userClubs.ToList();


        }

        public async Task<List<Race>> GetAllUserRaces()
        {
            var curUser = _httpcontextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var userRaces = _context.Races.Where(r => r.AppUser.Id == curUser.ToString());
            return userRaces.ToList();
        }

        public async Task<AppUser> GetUserById(string id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
