using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
        public int TeamName { get; set; }

        //TeamModel()
        //{
        //    TeamMember = new List<Person>();
        //}
    }
}
