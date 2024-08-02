using System.ComponentModel.DataAnnotations;

// use this class to verify the status of inputs
public class SignUpModel
{
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "The length of username should be between 3 to 50 characters.")]
    public required string Username {get; set;}

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(50, MinimumLength = 8, ErrorMessage = "The length of password should be between 8 to 50 characters.")]
    public required string Password {get; set; }
}