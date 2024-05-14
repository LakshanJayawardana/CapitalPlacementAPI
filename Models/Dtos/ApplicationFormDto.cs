namespace CapitalPlacementAPI.Models.Dtos;

    public class ApplicationFormDto
    {
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public PersonalInformation personalInformation { get; set; }
        public AddCustomQuestion AddCustomQuestion { get; set; }


    }