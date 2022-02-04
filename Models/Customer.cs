using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models{
    public class Customer{
       [Key]
        public Guid id {get; set; }

        public string? name {get; set; }

    }
}