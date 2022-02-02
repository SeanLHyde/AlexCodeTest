using System.ComponentModel.DataAnnotations;

namespace  CourseApi.Models{
    public class Account{
        [Key]
        public string? id {get; set;}
        
        public string? fromAccount { get; set; }

        public string? toAccount {get; set;}

        public string? description { get; set; }

        public float amount { get; set;}


    }
}