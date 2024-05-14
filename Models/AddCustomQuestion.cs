using CapitalPlacementAPI.Models.Enums;
namespace CapitalPlacementAPI.Models;

    public class AddCustomQuestion
    {
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
    }
