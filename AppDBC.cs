using Microsoft.EntityFrameworkCore;
using ProniaAdmin.Models;

public class AppDBC : DbContext
{
    internal readonly object Sliders;

    public AppDBC(DbContextOptions<AppDBC> options) : base(options)
    {

    }

    public DbSet<Slider> sliders { get; set; }
}