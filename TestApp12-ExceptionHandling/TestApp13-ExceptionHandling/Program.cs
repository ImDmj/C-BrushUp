using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp13_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any number");
                int no1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter any number");
                int no2 = Convert.ToInt32(Console.ReadLine());

                int result = no1 / no2;
                Console.WriteLine("Division ", +result);

                int[] x = new int[3];

                Console.WriteLine("Enter any number");
                x[0] = Convert.ToInt32(Console.ReadLine());

            }
           catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); // gives the line number where exception occured
            }

            // Least specific catch block and it can handle any exception so should be written at the bottom as it
            // makes other catch blocks unreachable if written at the top 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            // Optional. But can be used to release some object eg file handles, closing db connections
            finally
            {
                Console.WriteLine("You are in the FINALLY Blaock");
            }
            Console.ReadLine();
        }
    }
}
