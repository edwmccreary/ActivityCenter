using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class RSVP
    {
        [Key]
        public int RSVP_Id {get;set;}

        public int UserId {get;set;}
        public int MeetupId {get;set;}
        public User User {get;set;}
        public Meetup Meetup {get;set;}
    }
}