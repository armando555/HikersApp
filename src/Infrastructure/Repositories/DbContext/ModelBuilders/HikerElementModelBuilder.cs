using Domain.HikerElement.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.DbContext.ModelBuilders;

public static class HikerElementModelBuilder
{
    public static void MapHikerElement(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HikerElement>(i =>
        {
            i.Property(o=> o.Id).ValueGeneratedOnAdd();
            i.Property(o => o.Calories).IsRequired();
            i.Property(o => o.Weight).IsRequired();
        });
    }
}