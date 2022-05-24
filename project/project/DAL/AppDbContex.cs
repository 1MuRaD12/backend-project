using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.DAL
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Slider2> sliders2 { get; set; }
    }
}
