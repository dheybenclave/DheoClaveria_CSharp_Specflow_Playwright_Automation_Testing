namespace DheoClaveria_Specflow.Utils;

public record UserDetails(string FirstName, string LastName, string Email, int Phone)
{
    public string FirstName { get; set; } = FirstName;
    public string LastName { get; set; } = LastName;
    public string Email { get; set; } = Email;
    public int Phone { get; set; } = Phone;
}