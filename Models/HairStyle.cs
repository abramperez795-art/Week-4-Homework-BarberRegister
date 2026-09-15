namespace BarberRegister.Models;

public class HairStyle
{
public int Id { get; set; }

public string Name { get; set; } = "";
public string Description { get; set; } = "";
public string HairLength { get; set; } = "";
public int TypicalDurationMinutes { get; set; }
public decimal StartingPrice { get; set; }
public bool IncludesBeardService { get; set; }
}