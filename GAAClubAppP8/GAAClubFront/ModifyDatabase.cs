using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GAAClubFront
{
    public class ModifyDatabase
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public string lastID { get; set; }
        public ModifyDatabase()
        {
            conn = new SqlConnection("Data Source=PETER-PC;Initial Catalog=GAAClub;Integrated Security=False;User Id=sa;Password=Pa55w0rd1234;MultipleActiveResultSets=True");

        }

        public void addPlayer(string n, int a, int h, int d, double s)
        {
            conn.Open();
            cmd = new SqlCommand(@"Insert into Player 
                (PlayerName, PlayerAge, PlayerHeight, RunningDistance, PlayerSpeed)
                values ('" + n + " ',' " + a + "','" + h + "','" + d + "','" + s + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void lastPlayerAdded()
        {
            conn.Open();

            cmd = new SqlCommand("select PlayerID from Player", conn);
            dr = cmd.ExecuteReader();
            // use exception handling
            try
            {
                int i = dr.FieldCount;
                lastID = dr[i].ToString();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public string showName(string id)
        {
            conn.Open();

            cmd = new SqlCommand("select PlayerName from Player where (PlayerID = '"+id+"')", conn);
            string dr = (string)cmd.ExecuteScalar();
            conn.Close();
            return dr;
        }

        public void removePlayer(string id)
        {
            conn.Open();
            cmd = new SqlCommand(@"Delete from Player 
                where(PlayerID = '" + id + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void updatePlayer(string id, string n, int a, int h, int d, double s)
        {
            conn.Open();
            cmd = new SqlCommand(@"Update Player 
                set PlayerName = '" + n + "', PlayerAge = '" + a + "', PlayerHeight = '" + h + "', RunningDistance='" + d + "', PlayerSpeed='" + s + "' where (PlayerID ='" + id + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
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
