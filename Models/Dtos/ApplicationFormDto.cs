using CapitalPlacementAPI.Models;
namespace CapitalPlacementAPI.Models.Dtos;

    public class ApplicationFormDto
    {
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public AddCustomQuestion AddCustomQuestion { get; set; }


    }