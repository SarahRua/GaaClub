using System;

namespace GAAClubFront
{
    public class InputValidator
    {
        public int h;
        public int a;
        public int d;
        public double s; 
        // this method takes input from the console
        // (passed from the program class)
        // it tries to parse this value and checks if
        // it is in a standard format
        // before allowing data to be stored in the database.
        public bool validateHeight(String input)
        {
            // if it is possible to parse this input as an int
            // this will return true.
            // h refers to the solution after parsing of the string
            // is executed.
            // out means that h is now set to this value
            // if it is not possible to parse this input,
            // result will return false
            bool result = Int32.TryParse(input, out h);

            // after the input has been parsed,
            // i check to see that it has returned true,
            // AND h is between certain values
            // If all these constraints are fulfilled,
            // then this validateHeight method returns true
            // otherwise it returns false.
            if (result = true && h > 100 && h < 250)
            {
                return true;
                
            }
            else
            {
                return false;
            }

        }

        public bool validateAge(string input)
        {
            bool result = Int32.TryParse(input, out a);

            if (result = true && a > 14 && a < 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validateDist(string input)
        {
            bool result = Int32.TryParse(input, out d);

            if (result = true && d > 0 && d < 8000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validateSpeed(string input)
        {
            bool result = Double.TryParse(input, out s);

            if (result = true && s > 0.5 && s < 8.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
