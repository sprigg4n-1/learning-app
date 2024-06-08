using System.ComponentModel.DataAnnotations;

public class RegisterUser : LoginUser
{
  [Required]
  [MinLength(6)]
  public string nickname { get; set; }

  [Required]
  [Compare(nameof(password))]
  public string confirmPassword { get; set; }
}