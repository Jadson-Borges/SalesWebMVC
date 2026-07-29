using Microsoft.EntityFrameworkCore;

public class SalesWebMVCContext(DbContextOptions<SalesWebMVCContext> options) : DbContext(options)
{
    public DbSet<SalesWebMVC.Models.Departament> Departament { get; set; } = default!;
    public DbSet<SalesWebMVC.Models.Seller> Seller { get; set; } = default!;
    public DbSet<SalesWebMVC.Models.SalesRecord> SalesRecords { get; set; } = default!;


}
