using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GAAClubFront
{
    class DataAccess : IDataAccess
    {
        // declare a sqlconnection
        SqlConnection conn;

        // the constructor takes in a connection string
        public DataAccess(SqlConnection conn)
        {
            // the constructor string is set.
            this.conn = conn;
        }

        // the following method allows me to take in a query and
        // run this query in a sqlcommand. I can pass in a different string
        // for each query I want to call.
        private List<int> getListInts(String query)
        {
            // create a sqldatareader
            SqlDataReader reader;
            try
            {
                // open the connection
                conn.Open();
                // create a sql command and pass it the query argument
                SqlCommand command = new SqlCommand(query, conn);
                // create a list of integers
                List<int> integerlist = new List<int>();

                // use the sqldatareader to extract the values in the database
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //assign the current value in reader
                        int x = reader.GetInt32(0);
                        // put this value into the list
                        integerlist.Add(x);
                    }
                    //close reader
                    reader.Close();
                }
                // this method returns a list of integers
                return integerlist;
            }
            finally
            {
                // don't need to close reader as I have already done so.
                //close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // this method calls getListInts, passing in an "age" specific query.
        // it takes the returned list of ints and returns that in this method.
        public List<int> getPlayerAge()
        {
            return getListInts("select PlayerAge from Player");
        }


        // this method does the same for a "height" specific query.
        public List<int> getPlayerHeight()
        {
            return getListInts("Select PlayerHeight from Player");
        }
        // this method does the same for a "distance" specific query.
        public List<int> getRunningDist()
        {
            return getListInts("Select RunningDistance from Player");
        }
        // as speed is a double, there is a different method here.
        public List<double> getPlayerSpeed()
        {
            try
            {
                // open the connection
                conn.Open();
                // here the query is hardcoded in
                SqlCommand command = new SqlCommand("Select PlayerSpeed from Player", conn);
                // create a list of double values
                List<double> speedList = new List<double>();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // assign the next double to the list
                        double x = reader.GetDouble(0);
                        speedList.Add(x);
                    }
                    // close the reader
                    reader.Close();
                }
                // return the list of doubles
                return speedList;
            }
            finally
            {
                //close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
