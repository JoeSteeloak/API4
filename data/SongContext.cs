using Microsoft.EntityFrameworkCore;
using API4.Models;

namespace API4.Data {

    public class SongContext : DbContext {
        public SongContext(DbContextOptions<SongContext> options) : base(options) 
        {

        }

        public DbSet<Song> Songs { get; set; }
    }
}