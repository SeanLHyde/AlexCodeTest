using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models{
    public class Customer{
        [Key]
        public string? id {get; set;}

        public string? name {get; set;}

    }
}