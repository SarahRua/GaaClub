using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAAClubFront
{
    // this class also implements the IDataAcess interface
    // I use this for my unit tests, so I do not access the database
    // in my testing. Instead, I hardcode in these values.
    class TrialDataAccess : IDataAccess
    {
        public List<int> getPlayerAge()
        {
            // I create a list of integers and add members to the list
            List<int> agelist = new List<int>();
            agelist.Add(21);
            agelist.Add(25);
            agelist.Add(26);
            // this method returns the whole list
            return agelist;
        }

        public List<int> getPlayerHeight()
        {
            List<int> heightlist = new List<int>();
            heightlist.Add(170);
            heightlist.Add(175);
            heightlist.Add(165);
            return heightlist;
        }

        public List<double> getPlayerSpeed()
        {
            List<double> speedlist = new List<double>();
            speedlist.Add(3.3);
            speedlist.Add(3.1);
            speedlist.Add(3.8);
            return speedlist;
        }

        public List<int> getRunningDist()
        {
            List<int> distlist = new List<int>();
            distlist.Add(2000);
            distlist.Add(2000);
            distlist.Add(1700);
            return distlist;
        }
    }
}
