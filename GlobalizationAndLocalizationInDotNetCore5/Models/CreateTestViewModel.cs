using System.ComponentModel.DataAnnotations;

namespace GlobalizationAndLocalizationInDotNetCore5.Models
{
    public class CreateTestViewModel
    {
        [Display(Name = "Name"), Required(ErrorMessage = "Required")]
        public string Name { get; set; }
    }
}