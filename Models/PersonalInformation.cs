using CapitalPlacementAPI.Models.Enums;

namespace CapitalPlacementAPI.Models;

public class PersonalInformation
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Nationality { get; set; }
    public string CurrentResidence { get; set; }
    public string IDNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
}
