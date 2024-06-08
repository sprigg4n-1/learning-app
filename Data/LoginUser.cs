using System.ComponentModel.DataAnnotations;

public class LoginUser
{

  [Required]
  [EmailAddress]
  public string email { get; set; }

  [Required]
  [MinLength(8)]
  public string password { get; set; }
}