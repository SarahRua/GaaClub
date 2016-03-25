using System.Collections.Generic;

namespace GAAClubAppP7
{
    // this separates the data layer from the stats class.
    // data is retrieved from either the dataaccess concrete class
    // or the trialdataaccess concrete class (both of which implement
    // this interface). The stats class then fetches the data 
    // from here. The stats class makes calculations based on lists
    // set up in this code, not on data retrieved directly from the db.
    interface IDataAccess
    {
        // this interface declares the methods its concrete classes
        // will have to implement
        List<int> getPlayerAge();
        List<int> getPlayerHeight();
        List<int> getRunningDist();
        List<double> getPlayerSpeed();
    }
}
