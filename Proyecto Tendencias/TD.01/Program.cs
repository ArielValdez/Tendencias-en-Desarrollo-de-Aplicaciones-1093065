using System;
using System.Text.RegularExpressions;
namespace TD._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Separate by hyphen or spaces
            if (args[0] == null)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine(SSNRegex(args[0]));
                Console.WriteLine(SSNArray(args[0]));
            }
        }
        static string SSNArray(string ssn)
        {
            char[] separator = { '-', ' ' };
            string[] n = ssn.Split(separator);
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == null)
                {
                    return "Invalid";
                }
            }
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
        }
        static string SSNRegex(string ssn)
        {
            Regex regex = new Regex("^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$");
            //Regex regex = new Regex(@"^\d{3}\-?\d{2}\-?\d{4}$");
            if (ssn == null)
            {
                return "Invalid";
            }
            else
            {
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
