using Domain.HikerElement.Entities;
using Domain.Hiker.Entities;
using Infrastructure.Repositories.DbContext.ModelBuilders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Repositories.DbContext;

public class HikerElementContext: Microsoft.EntityFrameworkCore.DbContext
{
    public HikerElementContext(DbContextOptions<HikerElementContext> options)
        : base(options)
    {
    }

    public DbSet<HikerElement> HikerElements { get;set; }
    public DbSet<Hiker> Hiker{ get;set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.MapHikerElement();
        modelBuilder.MapHiker();
    }


}