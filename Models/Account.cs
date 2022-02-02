using System.ComponentModel.DataAnnotations;

namespace  CourseApi.Models{
    public class Account{
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Test")]
        [MaxLength(30, ErrorMessage = "Field too long")]
        [MinLength(3, ErrorMessage = "Field not long enough")]
        
        public string? Title { get; set; }

        [Required(ErrorMessage = "Test")]
        [MaxLength(30, ErrorMessage = "Field too long")]
        [MinLength(3, ErrorMessage = "Field not long enough")]

        public string? AccountType {get; set;}
    }
}