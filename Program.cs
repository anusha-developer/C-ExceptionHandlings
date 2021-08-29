using System;

namespace Exception_Handlings
{
    class Program
    {

        /*Exception  Handlings---->distrabunce occured when we run the program
                              ----> that's why we use  try & catch blocks
        try---->if it may raise a exception we should put inside a try block 
             -->if exception occurs that flow of  control jumps into the catch block

        catch--->It is a  Exception Handler where we can perform an action
              -->it can take the parameter of the exception type we get  the details of the exception

        Finally--> It is always  will be excuted either the excution is raised or not

        throw
        throws*/

    public static void displayException( int number1, int number2)
        {
            try
            {
                number1 = 5;
                number2 = 0;
                int result = number1 / number2;
            }
            catch(Exception e)
            {
                Console.WriteLine("Please should not divide with Zero ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  First number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  Second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1 / number2;
            Console.WriteLine(result);

            Program.displayException(5,0);
            Console.WriteLine("Hello World!");
        }
    }
}
