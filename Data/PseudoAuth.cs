

public class PseudoAuth
{
  public static string UserId { get; set; }
  public static string UserPass { get; set; }
  public static string UserMail { get; set; }
  public static bool IsLoggedIn { get; set; } = false;

  public static void Reset()
  {
    UserId = null;
    UserPass = null;
    UserMail = null;
    IsLoggedIn = false;
  }
}