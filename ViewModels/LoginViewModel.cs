using System.ComponentModel.DataAnnotations;

namespace TodoAPI.ViewModels;

public class LoginViewModel
{
    [Required]
    [MinLength(4, ErrorMessage = "Password must be at least 4 characters long")]
    public required string Username { get; set; }

    [Required]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    public required string Password { get; set; }

}
