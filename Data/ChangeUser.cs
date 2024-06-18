using System.ComponentModel.DataAnnotations;

public class ChangeUser
{
  [Required]
  [MinLength(6)]
  public string nickname { get; set; }

  [Required]
  [EmailAddress]
  public string email { get; set; }

  [Required]
  [MinLength(8)]
  public string password { get; set; }
}