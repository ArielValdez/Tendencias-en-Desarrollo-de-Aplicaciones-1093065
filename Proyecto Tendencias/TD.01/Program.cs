using System;
using System.Text.RegularExpressions;

namespace TD._01
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region manual tests
            //SSNArray(" ");
            //SSNArray("000-00-0000");
            //SSNArray("333-01-0001");
            //SSNArray("666-01-0001");
            //SSNArray("952-01-0001");
            //SSNArray("99-01-0001");
            //SSNArray("333-00-0001");
            //SSNArray("333-99-0001");
            //SSNArray("333-99-0000");
            //SSNArray("333-99-100");
            //SSNArray("333-99-3333");
            #endregion
            try
            {
                //Prints the message Valid or Invalid
                //Console.WriteLine(SSNRegex(args[0]));
                Console.WriteLine("Introduced SSN is: {0}", SSNArray(args[0]));
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
                Console.WriteLine("\nPlease Introduce an SSN");
            }
        }
        public static string SSNArray(string ssn)
        {
            //These arrays are used to separate the sections of the SSN into different indexes
            char[] separator = { '-', ' ' };
            string[] n = ssn.Split(separator);
            //This loop checks if the SSN is not empty, or if it has more than three sections
            for (int i = 0; i < n.Length; i++)
            {
                if (i > 2)
                {
                    return "Invalid";
                }
                if (n[i] == null)
                {
                    return "Invalid";
                }
            }
            //This regions validates an SSN, given the requirements
            #region SSN Validation
            if (n[0].Length != 3 || int.Parse(n[0]) == 666 || int.Parse(n[0]) == 0 || (int.Parse(n[0]) > 899 && int.Parse(n[0]) < 1000))
            {
                return "Invalid";
            }
            else if (n[1].Length != 2 || int.Parse(n[1]) == 0)
            {
                return "Invalid";
            }
            else if (n[2].Length != 4 || int.Parse(n[2]) == 0)
            {
                return "Invalid";
            }
            else return "Valid";
            #endregion
        }
        public static string SSNRegex(string ssn) //Alternative
        {
            //Regular expression, used to check to match the SSN and the regex used
            Regex regex = new Regex("^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$");
            //Regex regex = new Regex(@"^\d{3}\-?\d{2}\-?\d{4}$");
            if (ssn == null)
            {
                return "Invalid";
            }
            else
            {
                //Checks for a matching result
                bool matching = regex.IsMatch(ssn);

                if (matching)
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }
        }
    }
}
