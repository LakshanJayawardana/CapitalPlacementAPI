using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacementAPI.Models.Entities;

public class ApplicationForm : BaseEntity
{
    public string ProgramTitle { get; set; }
    public string ProgramDescription { get; set; }
    public PersonalInformation PersonalInformation { get; set; }
    public AddCustomQuestion AddCustomQuestion { get; set; }
}