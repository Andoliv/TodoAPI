using System.ComponentModel.DataAnnotations;

namespace TodoAPI.ViewModels;

public class RegisterViewModel : LoginViewModel
{
    public string? Name { get; set; }
}
