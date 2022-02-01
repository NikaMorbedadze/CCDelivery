using CCDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CCDelivery.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<BasePerson> Persons { get; set; }
}
