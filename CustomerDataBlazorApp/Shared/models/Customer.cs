using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string Surname { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }
}
