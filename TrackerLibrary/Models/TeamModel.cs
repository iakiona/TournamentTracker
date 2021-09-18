using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public string TeamName { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public int Id { get; set; }
    }
}
