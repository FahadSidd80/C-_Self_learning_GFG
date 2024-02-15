using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls._2_Control_Statements
{
    internal class JumpStatements
    {
        //static int Addition(int a)
        //{
        //    int add = a + a;
        //    return add;
        //}


        // taking null in the string
        static string sub = null;

        // method to display subject name    
        static void displaysubject(string sub1)
        {
            if (sub1 == null)
                throw new NullReferenceException("Exception Message");

        }


        static string x = null;

        static void display(string y)
        {
            if (y == null)
                throw new NullReferenceException("Exception message ");
        }
        public static void Main()
        {
            //Console.WriteLine("Jump Statements");
            try
            {
                display(x);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // using try catch block to 
            //// handle the Exception
            //try
            //{

            //    // calling the static method
            //    displaysubject(sub);
            //}

            //catch (Exception exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}

            //In C#, Jump statements are used to transfer control from one
            //point to another point in the program due to some specified code
            //while executing the program. There are five keywords in the Jump Statements:

            //break
            //continue
            //goto
            //return
            //throw

            // Break : 
            //for (int i=0; i< 10; i++) {
            //    if (i == 3)
            //        break;
            //    Console.WriteLine("Break statements");
            //}

            //Continue:

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 4)
            //        continue;
            //    Console.WriteLine("continue statements "+ i);
            //}

            //int num = 20;
            //switch (num) {
            //    case 10:
            //        Console.WriteLine("case 5");
            //        break;
            //    case 15:
            //        Console.WriteLine("case 5");
            //        break;
            //    case 20:
            //        Console.WriteLine("case 5");
            //        goto case 10;
            //        break;
            //    case 25:
            //        Console.WriteLine("case 5");
            //        break;
            //    default: 
            //        Console.WriteLine("No match found");
            //        break;

            //}


            //int num = 20;
            //switch (num)
            //{
            //    case 10:
            //        Console.WriteLine("case 10");
            //        break;
            //    case 15:
            //        Console.WriteLine("case 15");
            //        break;
            //    case 20:
            //        Console.WriteLine("case 20");
            //        goto case 10;
            //    case 25:
            //        Console.WriteLine("case 25");
            //        break;
            //    default:
            //        Console.WriteLine("No match found");
            //        //break;

            //}

            //int number = 20;  -- Need to R & D
            //switch (number)
            //{

            //    case 5:
            //        Console.WriteLine("case 5");
            //        break;
            //    case 10:
            //        Console.WriteLine("case 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("case 20");

            //        // goto statement transfer 
            //        // the control to case 5
            //        goto case 5;


            //    default:
            //        Console.WriteLine("No match found");

            //}

            //return Stement
            //This statement terminates the execution of the method
            //and returns the control to the calling method. It returns
            //an optional value.If the type of method is void, then
            //the return statement can be excluded.


            //int number = 2;
            //int result  = Addition(number);
            //Console.WriteLine("The sum is "+ result);//   The sum is 4
            //Console.WriteLine("The sum is ", result);//  The sum is
            //Console.WriteLine("The sum is {0}", result);// The sum is 4


            // throw : 
            //This is used to create an object of any valid exception class
            //with the help of new keyword manually.
            //The valid exception must be derived from the Exception class.

            //// using try catch block to 
            //// handle the Exception
            //try
            //{

            //    // calling the static method
            //    displaysubject(sub);
            //}

            //catch (Exception exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}





        }
    }
}
