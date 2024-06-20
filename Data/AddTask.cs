using System.ComponentModel.DataAnnotations;

public class AddTask
{
  public DateTime date { get; set; } = DateTime.Now;

  [Required]
  [MinLength(3)]
  public string task { get; set; }
  public bool done { get; set; } = false;
  public bool important { get; set; }
}