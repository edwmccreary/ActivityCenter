using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class Meetup
    {
        [Key]
        public int MeetupId {get;set;}

        [Required]
        public string title {get;set;}

        [Required]
        [NoPastDateTime]
        public DateTime MeetupStart {get;set;}

        public TimeSpan Duration {get;set;}
        
        [Required]
        public string Description {get;set;}

        [Required(ErrorMessage = "The User ID of this meetup is missing")]
        public int UserId {get;set;}

        public User user {get;set;}

        public List<RSVP> Guests {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [NotMapped]
        [Required]
        public double MinuteHourDay_Option {get;set;}
        [NotMapped]
        [Required]
        public double MinuteHourDay_Value {get;set;}

        [NotMapped]
        public DateTime MeetupEnd {get;set;}

        [NotMapped]
        public TimeSpan MeetupTime {get;set;}
        
    }

    public class NoPastDateTime : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime)
            {
                DateTime checkMe = (DateTime)value;

                if(checkMe < DateTime.Now)
                {
                    return new ValidationResult("date must not be in the past");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("entered value is not a date");
            }
        }
    }
}