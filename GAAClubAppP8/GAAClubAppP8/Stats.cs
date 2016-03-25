using System;
using System.Data.SqlClient;
using System.Linq;

namespace GAAClubAppP7
{
    // this stats class fetches the data from list set up in the data 
    // access layer. The stats class makes calculations based on lists
    // set up in this code, not on data retrieved directly from the db.
    public class Stats
    {
        //create variables
        private double meanAge { get; set; }
        private int minAge { get; set; }
        private int maxAge { get; set; }
        private double meanHeight { get; set; }
        private int minHeight { get; set; }
        private int maxHeight { get; set; }
        private double meanDist { get; set; }
        private int minDist { get; set; }
        private int maxDist { get; set; }
        private double meanSpeed { get; set; }
        private double minSpeed { get; set; }
        private double maxSpeed { get; set; }
        //an IDataAccess is created
        //this is an interface.
        //the type of instance will be decided later
        //in the constructor step.
        IDataAccess access;

        public Stats()
        {
            // this default constructor takes no parameter
            // there is no database connection
            // it creates a TrialDataAccess implementation of 
            // IDataAccess.
            // this is used for testing
            access = new TrialDataAccess();
        }

        public Stats(SqlConnection conn)
        {
            // this constructor takes a sqlconnection parameter
            // a DataAccess implementataion of IDataAccess is set up
            // this takes conn as a parameter
            access = new DataAccess(conn);
        }

        public double getMeanAge()
        {
            // this method calculates mean age using the average method of
            // the returned list.
            // the result is rounded to 2 decimal places
            meanAge = (Math.Round((access.getPlayerAge().Average()) * 100)) / 100;
            return meanAge;
        }
        public int getMinAge()
        {
            // this method calculates min age using the min method of
            // the returned list.
            minAge = access.getPlayerAge().Min();
            return minAge;
        }
        public int getMaxAge()
        {
            // this method calculates max age using the max method of
            // the returned list.
            maxAge = access.getPlayerAge().Max();
            return maxAge;
        }
        public double getMeanHeight()
        {
            meanHeight = (Math.Round((access.getPlayerHeight().Average()) * 100)) / 100;
            return meanHeight;
        }
        public int getMinHeight()
        {
            minHeight = access.getPlayerHeight().Min();
            return minHeight;
        }
        public int getMaxHeight()
        {
            maxHeight = access.getPlayerHeight().Max();
            return maxHeight;
        }

        public double getMeanDist()
        {
            meanDist = (Math.Round((access.getRunningDist().Average()) * 100)) / 100;
            return meanDist;
        }
        public int getMinDist()
        {
            minDist = access.getRunningDist().Min();
            return minDist;
        }
        public int getMaxDist()
        {
            maxDist = access.getRunningDist().Max();
            return maxDist;
        }

        public double getMeanSpeed()
        {
            meanSpeed = (Math.Round((access.getPlayerSpeed().Average()) * 100)) / 100;
            return meanSpeed;
        }
        public double getMinSpeed()
        {
            minSpeed = access.getPlayerSpeed().Min();
            return minSpeed;
        }
        public double getMaxSpeed()
        {
            maxSpeed = access.getPlayerSpeed().Max();
            return maxSpeed;
        }
        // this display method shows the results of the analysis in a print statement
        public void Display()
        {
            Console.WriteLine("Mean Age: " + getMeanAge() + "\t\tMax Age: " + getMaxAge() + "\tMin Age: " + getMinAge());
            Console.WriteLine("Mean Run: " + getMeanDist() + "\tMax Run: " + getMaxDist() + "\tMin Run: " + getMinDist());
            Console.WriteLine("Mean Height: " + getMeanHeight() + "\tMax Height: " + getMaxHeight() + "\tMin Height: " + getMinHeight());
            Console.WriteLine("Mean Speed: " + getMeanSpeed() + "\tMax Speed: " + getMaxSpeed() + "\tMin Speed: " + getMinSpeed());
            Console.ReadKey();
        }
    }
}
