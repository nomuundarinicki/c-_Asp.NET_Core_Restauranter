using System;
using System.ComponentModel.DataAnnotations;
 
namespace restauranter.Models
{
    public class Review : BaseEntity
    {
        public int ReviewId {get; set;}

        [Required]
        [Display(Name="Your Name")]
        public string Author {get; set;}
        [Required]
        [Display(Name="Restaurant Name")]
        public string RestName {get; set;}
        [Required]
        [Display(Name="Review")]
        [MinLength(10)]
        public string Context {get; set;}
        [Required]
        [Range(0,5)]
        [Display(Name="Stars")]
        public int Rating {get; set;}
        [Required]
        [Display(Name="Visit Date")]
        public DateTime VDate {get; set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get; set;}

    }
}