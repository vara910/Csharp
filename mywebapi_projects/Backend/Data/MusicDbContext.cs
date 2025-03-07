using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options) { }
        public DbSet<FavoriteSong> FavoriteSongs { get; set; }
    }

    public class FavoriteSong
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
    }
}
