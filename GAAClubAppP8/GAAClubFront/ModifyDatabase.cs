using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GAAClubFront
{
    // this class does most of the data accessing from the database.
    // While I use IDataAccess implementations for the statistics summary,
    // here I use modifydatabase to do my adding, updating, deleting, etc.
    public class ModifyDatabase
    {
        SqlConnection conn;
        SqlCommand cmd;
        // this lastID field is used to get the last record entered
        public int lastID { get; set; }
        public ModifyDatabase()
        {
            //this connection allows me to connect to my database
            conn = new SqlConnection("Data Source=PETER-PC;Initial Catalog=GAAClub;Integrated Security=False;User Id=sa;Password=Pa55w0rd1234;MultipleActiveResultSets=True");

        }
        // addPlayer accesses the database and inserts the new record
        public void addPlayer(string n, int a, int h, int d, double s)
        {
            conn.Open();
            cmd = new SqlCommand(@"Insert into Player 
                (PlayerName, PlayerAge, PlayerHeight, RunningDistance, PlayerSpeed)
                values ('" + n + " ',' " + a + "','" + h + "','" + d + "','" + s + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // lastPlayerAdded gets the id of the last record entered
        public void lastPlayerAdded()
        {
            conn.Open();

            cmd = new SqlCommand("select MAX(PlayerID) from Player", conn);

            // use exception handling for the case that there are no records
            try
            {
                lastID = (int)cmd.ExecuteScalar();

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        // showName connects to the database and extracts the name value from a 
        // particular record
        public string showName(int id)
        {
            conn.Open();

            cmd = new SqlCommand("select PlayerName from Player where (PlayerID = '" + id + "')", conn);
            string dr = (string)cmd.ExecuteScalar();
            conn.Close();
            return dr;
        }

        // removePlayer connects to the database and deletes a particular record
        public void removePlayer(int id)
        {
            conn.Open();
            cmd = new SqlCommand(@"Delete from Player 
                where(PlayerID = '" + id + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        // updatePlayer connects to the database and changes a particular record
        public void updatePlayer(int id, string n, int a, int h, int d, double s)
        {
            conn.Open();
            cmd = new SqlCommand(@"Update Player 
                set PlayerName = '" + n + "', PlayerAge = '" + a + "', PlayerHeight = '" + h + "', RunningDistance='" + d + "', PlayerSpeed='" + s + "' where (PlayerID ='" + id + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //countRows tells me how many rows are in the database.
        //I use this for testing
        public int countRows()
        {
            conn.Open();
            cmd = new SqlCommand(@"Select count(*) from Player", conn);
            int c = (int)cmd.ExecuteScalar();
            conn.Close();
            return c;
        }


    }
}
