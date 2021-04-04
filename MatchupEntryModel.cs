using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in matchup.
        /// Reprezentuje wybraną drużynę w pojedynku
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// Reprezentuje wynik dla tej konkretnej drużyny
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner.
        /// Reprezentuje pojedynek z którego zespół wyszedł jako zwycięzca .
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

 
    }
}
