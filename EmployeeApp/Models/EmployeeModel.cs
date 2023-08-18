using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Required]
        public string Division { get; set; }
        public bool Active { get; set; }
    }
}
