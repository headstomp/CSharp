﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {

        /// <summary>
        /// Represents the id from the database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the team name
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Represents the members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

 

    }
}
