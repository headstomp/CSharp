﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournamnet
    /// </summary>
    public class MatchupModel
    {

        /// <summary>
        /// The unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that were involved in this match
        /// </summary>
        public List<MatchupModel> Entries { get; set; } = new List<MatchupModel>();

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
