using System.Data.SqlClient;
using System;
using System.Data;

namespace GAAClubAppP7
{
    public class Program 
    {
        //this program is the initial code created in assignment 6
        //some edits have been made to include extra column values
        public static void Main(string[] args)
        {
            //connecting
            SqlConnection conn = new SqlConnection("Data Source=PETER-PC;Initial Catalog=GAAClub;Integrated Security=False;User Id=sa;Password=Pa55w0rd1234;MultipleActiveResultSets=True");

            try
            {
                //open connection
                conn.Open();
                
                // inserting data into database
                for(int i = 0; i < 1; i++)
                {
                    InputValidator validater = new InputValidator();
                    Console.Write("Enter player name: ");
                    string name = Console.ReadLine();

                    // before numerical data can be inserted into database
                    // it is run through a validate method
                    // which is in the inputvalidator class

                    // set age at random, so pass by ref out will work
                    int age = 1;
                    // set valid age to false initially
                    bool valida = false;
                    // the loop keeps running until valid input is entered
                    while (valida == false)
                    {
                        Console.Write("Enter player age: ");
                        // i call the validateAge method
                        // which will return a true or false
                        // dependant on the validity of the input.
                        valida = validater.validateAge(Console.ReadLine(), out age);
                        if (valida == false)
                        {
                            Console.WriteLine("Invalid Age");
                        }
                    }

                    int height = 1;
                    bool validh = false;
                    while(validh == false)
                    {
                        Console.Write("Enter player height: ");
                        validh = validater.validateHeight(Console.ReadLine(), out height);
                        if(validh == false)
                        {
                            Console.WriteLine("Invalid Height");
                        }
                    }


                    int distance = 1;
                    bool validd = false;
                    while (validd == false)
                    {
                        Console.Write("Enter player running distance: ");
                        validd = validater.validateDist(Console.ReadLine(), out distance);
                        if (validd == false)
                        {
                            Console.WriteLine("Invalid distance");
                        }
                    }

                    double speed = 1;
                    bool valids = false;
                    while (valids == false)
                    {
                        Console.Write("Enter player running speed: ");
                        valids = validater.validateSpeed(Console.ReadLine(), out speed);
                        if (valids == false)
                        {
                            Console.WriteLine("Invalid speed");
                        }
                    }



                    SqlCommand insertValues =
                        new SqlCommand(
                            "insert into Player(PlayerName, PlayerAge, PlayerHeight, RunningDistance, PlayerSpeed) values(@name, @age, @height, @dist, @speed);", conn);
                    insertValues.Parameters.Add("@name", SqlDbType.Text).Value = name;
                    insertValues.Parameters.Add("@age", SqlDbType.Int).Value = age;
                    insertValues.Parameters.Add("@height", SqlDbType.Int).Value = height;
                    insertValues.Parameters.Add("@dist", SqlDbType.Int).Value = distance;
                    insertValues.Parameters.Add("@speed", SqlDbType.Float).Value = speed;
                    insertValues.ExecuteNonQuery();
                } 
            }
            finally
            {
                // close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }


            // instantiate a reader
            SqlDataReader rdr = null;
            try
            {
                // open connection
                conn.Open();
                //read data query
                SqlCommand command = new SqlCommand("select * from Player",conn);

                rdr = command.ExecuteReader();
                
                // output readings for each player
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1] + "\t" + rdr[2] + "\t" + rdr[3] + "\t" + rdr[4] + "\t" + rdr[5]);
                }
                Console.ReadKey();

            }
            finally
            {
                // close reader
                if (rdr != null)
                {
                    rdr.Close();
                }
                //close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // print out explanation of what next part does
            // if a player's age is over 35, mark the age as 35
            Console.WriteLine("Amend age if age is over 35");
            try
            {
                conn.Open();
                string updateString = @"
                update Player
                set PlayerAge = 35
                where PlayerAge > 35";
                SqlCommand cmd = new SqlCommand(updateString);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // print out explanation of what next part does
            // this sets the first player in the database to be named John Hanbury
            Console.WriteLine("Be sure to include John Hanbury.");
            try
            {
                conn.Open();
                string updateName = @"
                update Player
                set PlayerName = 'John Hanbury'
                where PlayerID = 1";
                SqlCommand cmd = new SqlCommand(updateName);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            //instantiate another reader
            SqlDataReader rdr2 = null;
            try
            {
                //open connection
                conn.Open();
                // read data query
                SqlCommand command = new SqlCommand("select * from Player", conn);

                rdr2 = command.ExecuteReader();

                while (rdr2.Read())
                {
                    Console.WriteLine(rdr2[1] + "\t" + rdr2[2] + "\t" + rdr2[3] + "\t" + rdr2[4] + "\t" + rdr2[5]);
                }
                Console.ReadKey();

            }
            finally
            {
                //close reader
                if (rdr2 != null)
                {
                    rdr2.Close();
                }
                //close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            // create an instance of Stats
            Stats stat = new Stats(conn);
            // call the display method
            stat.Display();
        }
    }
}
