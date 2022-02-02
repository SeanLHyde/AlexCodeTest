using System.ComponentModel.DataAnnotations;

namespace CourseApi.Models{
    public class Users{
        [Key]
        public int Id {get; set;}

        public string? Name {get; set;}

        public DateTime DOB {get; set;}

        public int cost {get; set;}

    }
}