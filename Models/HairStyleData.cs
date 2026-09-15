using System.Collections.Generic;

namespace BarberRegister.Models;

public static class HairStyleData
{
public static List<HairStyle> All { get; } = new()
{
new HairStyle { Id = 1, Name = "Low Taper Fade", Description = "A clean taper around the ears and neckline with length left on top.", HairLength = "Short to medium", TypicalDurationMinutes = 45, StartingPrice = 35.00m, IncludesBeardService = false },
new HairStyle { Id = 2, Name = "Textured Crop", Description = "A short, textured top with a faded or tapered finish on the sides.", HairLength = "Short", TypicalDurationMinutes = 40, StartingPrice = 32.00m, IncludesBeardService = false },
new HairStyle { Id = 3, Name = "Burst Fade Mohawk", Description = "A burst fade around the ears with longer hair through the center.", HairLength = "Medium", TypicalDurationMinutes = 55, StartingPrice = 40.00m, IncludesBeardService = false },
new HairStyle { Id = 4, Name = "Classic Scissor Cut", Description = "A traditional haircut using scissors and light clipper work.", HairLength = "Short to medium", TypicalDurationMinutes = 50, StartingPrice = 38.00m, IncludesBeardService = false },
new HairStyle { Id = 5, Name = "Skin Fade with Beard Trim", Description = "Close skin fade with beard trim and lineup.", HairLength = "Short", TypicalDurationMinutes = 60, StartingPrice = 50.00m, IncludesBeardService = true },
new HairStyle { Id = 6, Name = "Curly Top Taper", Description = "Tapered cut that preserves natural curls and volume on top.", HairLength = "Medium to long", TypicalDurationMinutes = 50, StartingPrice = 42.00m, IncludesBeardService = false },
};
}