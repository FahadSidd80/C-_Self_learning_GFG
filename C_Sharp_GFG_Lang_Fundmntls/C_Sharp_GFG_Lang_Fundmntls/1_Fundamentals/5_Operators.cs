using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls.Fundamentals
{
    internal class Operators
    {
        public static void Main(String[] args)
        {
            //    Console.WriteLine("Operators");

            //    int result;
            //    int x = 10, y = 5;

            //    // Addition
            //    result = (x + y);
            //    Console.WriteLine("Addition Operator: " + result);

            //    // Subtraction
            //    result = (x - y);
            //    Console.WriteLine("Subtraction Operator: " + result);

            //    // Multiplication
            //    result = (x * y);
            //    Console.WriteLine("Multiplication Operator: " + result);

            //    // Division
            //    result = (x / y);
            //    Console.WriteLine("Division Operator: " + result);

            //    // Modulo
            //    result = (x % y);
            //    Console.WriteLine("Modulo Operator: " + result);


            //int a = 10, res;
            //res = a++;
            //res = a;

            //Console.WriteLine("a is {0} and res is {1} : " , a, res );

            //res = ++a;
            //Console.WriteLine("a is {0} and res is {1} : ", a, res);

            //res = --a;
            //Console.WriteLine("a is {0} and res is {1} : ", a, res);

            //res = a--;
            //Console.WriteLine("a is {0} and res is {1} : ", a, res);


            // Relational Operator

            //int x = 5, y = 10;
            //bool result;

            //result = (x==y);
            //Console.WriteLine("Equal to operator :" + result);

            //result = (x != y);
            //Console.WriteLine("Not Equal to operator :" + result);

            //result = (x > y);
            //Console.WriteLine("Greater than operator :" + result);

            //result = (x < y);
            //Console.WriteLine("Less than  operator :" + result);

            //result = (x >= y);
            //Console.WriteLine("Greater than or Equal to operator :" + result);

            //result = (x <= y);
            //Console.WriteLine("less than or  Equal to operator :" + result);

            //Logical Operators

            //bool a = false, b = false, result;

            //result = a && b;
            //Console.WriteLine("Logical  AND " + result);

            //result = a || b;
            //Console.WriteLine("Logical  OR " + result);

            //result = !a;
            //Console.WriteLine("Logical  NOT " + result);


            //int x = 10, y= 20 , z = 10, m = 30;
            //bool res;
            //res = (x > y && z > m);
            //Console.WriteLine(res); // false

            //Bitwise Operators

            //int x = 5, y = 10, result;

            // Bitwise AND Operator
            //result = x & y;
            //Console.WriteLine("Bitwise AND: " + result);

            // Bitwise OR Operator
            //result = x | y;
            //Console.WriteLine("Bitwise OR: " + result);

            // Bitwise XOR Operator
            //result = x ^ y;
            //Console.WriteLine("Bitwise XOR: " + result);

            // Bitwise Compliment operator
            //result = ~x;
            //Console.WriteLine("Bitwise Complement: " + result);
            //For any integer n, 2's complement of n will be -(n+1).
            //working 
            //x=5, in binary - 101
            //    then aplly ~ operaotr on binary of 5. i.e 8 bit binay - 00000, 101
            //then it becomes  -- 11111,010 due int is 8 bit
            //1 represent -ve and if value is -ve then we must do 2's compliment
            //because  Negative numbers in computer are represented in 2's complement representation.
            // step 1st = -(101)
            //step 2 nd = -(101 +1) = 110  -> 6
            //sot final ans is -6


            // Bitwise LEFT SHIFT Operator
            //result = x << 2;
            //Console.WriteLine("Bitwise Left Shift: " + result);
            //working
            //num * 2bits -- 5 * 2(2) - 20

            // Bitwise RIGHT SHIFT Operator
            //result = x >> 2;
            //Console.WriteLine("Bitwise Right Shift: " + result);


            //Assignment Operators


            // initialize variable x
            // using Simple Assignment 
            // Operator "="
            //int x = 15;

            //// it means x = x + 10
            //x += 10;
            //Console.WriteLine("Add Assignment Operator: " + x);

            //// initialize variable x again
            //x = 20;

            //// it means x = x - 5
            //x -= 5;
            //Console.WriteLine("Subtract Assignment Operator: " + x);

            //// initialize variable x again
            //x = 15;

            //// it means x = x * 5
            //x *= 5;
            //Console.WriteLine("Multiply Assignment Operator: " + x);

            //// initialize variable x again
            //x = 25;

            //// it means x = x / 5
            //x /= 5;
            //Console.WriteLine("Division Assignment Operator: " + x);

            //// initialize variable x again
            //x = 25;

            //// it means x = x % 5
            //x %= 5;
            //Console.WriteLine("Modulo Assignment Operator: " + x);

            //// initialize variable x again
            //x = 8;

            //// it means x = x << 2
            //x <<= 2;
            //Console.WriteLine("Left Shift Assignment Operator: " + x);

            //// initialize variable x again
            //x = 8;

            //// it means x = x >> 2
            //x >>= 2;
            //Console.WriteLine("Right Shift Assignment Operator: " + x);

            //// initialize variable x again
            //x = 12;

            //// it means x = x >> 4
            //x &= 4;
            //Console.WriteLine("Bitwise AND Assignment Operator: " + x);

            //// initialize variable x again
            //x = 12;

            //// it means x = x >> 4
            //x ^= 4;
            //Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);

            //// initialize variable x again
            //x = 12;

            //// it means x = x >> 4
            //x |= 4;
            //Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);



            //Conditional Operator

            // ternory operator

            //condition? first_expression : second_expression;

            //Explanation:
            //condition:  it must be evaluated to true or false.

            //if the condition is true
            //                  first_expression is evaluated and becomes the result.
            //if the condition is false, 
            //                  second_expression is evaluated and becomes the result.

            //int x = 5, y = 10, result;

            //result = x > y ? x : y;
            //Console.WriteLine("Result when condition false : " + result);

            //result = x < y ? x : y;
            //Console.WriteLine("Result when condition false : " + result);



            // END OF Operator concepts in c#


            Console.ReadLine();
        }
    }
}
