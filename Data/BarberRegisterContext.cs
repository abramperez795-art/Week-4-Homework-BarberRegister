using BarberRegister.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BarberRegister.Data;

public class BarberRegisterContext : IdentityDbContext<AppUser>
{    public BarberRegisterContext(
        DbContextOptions<BarberRegisterContext> options)
        : base(options)
    {
    }

    public DbSet<HairStyle> HairStyles => Set<HairStyle>();

    public DbSet<HairStyleReview> HairStyleReviews =>
        Set<HairStyleReview>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<HairStyle>().HasData(
            new HairStyle
            {
                Id = 1,
                Name = "Low Fade",
                Description = "A clean tapered haircut.",
                HairLength = "Short",
                TypicalDurationMinutes = 45,
                StartingPrice = 35m,
                IncludesBeardService = false
            },
            new HairStyle
            {
                Id = 2,
                Name = "Box Braids",
                Description = "A protective braided hairstyle.",
                HairLength = "Medium to long",
                TypicalDurationMinutes = 180,
                StartingPrice = 120m,
                IncludesBeardService = false
            }
        );

        modelBuilder.Entity<HairStyleReview>().HasData(
            new HairStyleReview
            {
                Id = 1,
                HairStyleId = 1,
                ReviewerName = "Alex",
                Rating = 5,
                Comments = "Clean fade and a sharp finish. Exactly what I wanted.",
                ReviewedOn = new DateTime(2026, 10, 1)
            },
            new HairStyleReview
            {
                Id = 2,
                HairStyleId = 1,
                ReviewerName = "Jordan",
                Rating = 4,
                Comments = "Easy to maintain and a great everyday style.",
                ReviewedOn = new DateTime(2026, 10, 2)
            },
            new HairStyleReview
            {
                Id = 3,
                HairStyleId = 2,
                ReviewerName = "Taylor",
                Rating = 5,
                Comments = "Neat braids and a comfortable protective style.",
                ReviewedOn = new DateTime(2026, 10, 3)
            }
        );
    }
}