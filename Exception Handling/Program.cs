using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            StringToDouble("12");
            StringToDouble("hello");
            StringToDouble("1.29e325");
            Console.ReadKey();
        }
        static void StringToDouble(string s)
        {
            bool valid = true;
            Double result;
            try
            {
                result = Convert.ToDouble(s);
            }
            catch(FormatException e)
            {
                Console.WriteLine("(FormatException) Cannot convert to double, probably because your entry is not a number");
                valid = false;
            }
            catch(OverflowException)
            {
                Console.WriteLine("(OverflowException) Your entry is too large");
                valid = false;
            }
            finally
            {
                if(valid)
                    Console.WriteLine($"Result for {s} is valid");
            }
            throw new FormatException(e);
        }
    }
}
