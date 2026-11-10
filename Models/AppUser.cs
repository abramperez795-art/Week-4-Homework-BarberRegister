using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BarberRegister.Models;

public class AppUser : IdentityUser
{
    [StringLength(40)]
    public string DisplayName { get; set; } = "";
}