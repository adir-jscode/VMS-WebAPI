using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTOs
{
    public class VoluenteerDTO
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]

        [StringLength(50, ErrorMessage = "Name must be less than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Please enter valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Please enter address")]
        public string Address { get; set; }
        public string Availability { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
