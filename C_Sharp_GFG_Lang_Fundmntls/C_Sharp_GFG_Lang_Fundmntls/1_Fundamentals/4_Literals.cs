using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls.Fundamentals
{
    internal  class Literals
    {
        public static void Main(String[] args)
        {
            //1. Decimal Literals

            //Literals can be of the following types:

            //    1. Integer Literals
            //    2. Floating - point Literals
            //    3. Character Literals
            //    4. String Literals
            //    5. Null Literals
            //    6. Boolean Literals

            //1. Integral-- Decimal Literal
            //int x = 10;
            //Console.WriteLine(x);

            //Octal Literals:

            //int x = 019;
            //Console.WriteLine(x);

            //3. Hexa decimal -- In this C# is not case sensitive -Exception here

            //int x =  0x123;
            //Console.WriteLine(x);// 291  we get value in decimal form

            //int x = 0x123Face;
            //Console.WriteLine(x);// 19135182

            //int x = 0X123FACE;
            //Console.WriteLine(x);// 19135182

            //4. Binary 

            //int x = 0b01100110;
            //Console.WriteLine(x);// 102

            //int x = 0B01101;
            //Console.WriteLine(x);// 13

            //int x = 0B01100110; -- In this C# is not case sensitive -Exception here
            //Console.WriteLine(x); // 102


            //07778    // invalid: 8 is not an octal digit 
            //045uu    // invalid: suffix (u) is repeated
            //0b105    // invalid: 5 is not a binary digit
            //0b101    // valid binary literal
            //456      // valid decimal literal
            //02453    // valid octal literal 
            //0x65d    // valid hexadecimal literal 
            //12356    // valid int literal 
            //304U     // valid unsigned int literal 
            //3078L    // valid long literal 
            //965UL    // valid unsigned long literal 

            //int x =07778;
            //int x1 = 045uu;// invalid: suffix (u) is repeated
            //int x2 = 0b105; // invalid: 5 is not a binary digit
            //int x3 = 0b101;  // valid binary literal
            //int x4 = 456;    // valid decimal literal
            //int x5 = 02453;  // valid octal literal 
            //int x6 = 0x65d;  // valid hexadecimal literal 
            //int x7 = 12356;  // valid int literal 
            //uint x8 = 304U;    // valid unsigned int literal 
            //long x9 = 3078L;    // valid long literal 
            //ulong x10 = 965UL;   // valid unsigned long literal 

            //Console.WriteLine(x); // 778
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);
            //Console.WriteLine(x3);  //5
            //Console.WriteLine(x4);  //456
            //Console.WriteLine(x5);  //2453
            //Console.WriteLine(x6);  //1629
            //Console.WriteLine(x7);  //12356
            //Console.WriteLine(x8);  // 304
            //Console.WriteLine(x9);  // 307
            //Console.WriteLine(x10);   //  965

            //ulong ul = 98248L;// System.Int64
            //Console.WriteLine(ul.GetType());// System.UInt64 - ul
            //Console.WriteLine(ul);// 98248

            //int x = 10;
            //int x = 01234567;
            //Console.WriteLine(x);// 1234567
            //Console.WriteLine(x.GetType());// System.Int32

            //int x5 = 02453;
            //Console.WriteLine(x5.GetType());// 2453

            //int x = 0786; -- Ther is not cotal numbe rin c#

            //Note: There is no Octal Number Literals in C#. On many websites, 
            //        you will find that in Octal number, digits from 0 – 7 are
            //        allowed and the octal number should always have a prefix 0.
            //        Example: int x=0146; But this is wrong. In C#, Octal Number 
            //        Representation is not possible. Refer to the following Stack 
            //        Overflow link.

            //https://stackoverflow.com/questions/4247037/octal-equivalent-in-c-sharp

            //int x = 0xFace;
            //Console.WriteLine(x);// 64206

            //int x = 0xBeef;
            //Console.WriteLine(x);// 48879

            //int x = 10;
            //int x1 = 010;
            //int x2 = 0x10;
            //Console.WriteLine(x); // 10
            //Console.WriteLine(x1);// 10
            //Console.WriteLine(x2);// 16


            //int x = 10;
            //long l = 10l;

            //int x = 10l;
            //long l = 10;

            //Console.WriteLine(l);// 10

            //sbyte b = 10;
            //sbyte b = 127;
            //sbyte b = 128;
            //Console.WriteLine(b);// 127

            //byte b = -127;
            //Console.WriteLine(b);

            //short s = 32767;
            //short s1 = 32768;

            //FLoating Point lIterals

            //float f = 1213.456f;
            //Console.WriteLine(f);// 1213.456

            //double a = 101.230;

            //// It also acts as decimal literal
            //double b = 0123.222;

            //Console.WriteLine(a); // 101.23
            //Console.WriteLine(b);// 123.222


            //float f = 123.456d;

            //double d = 123.456;
            //double d1 = 0123.456;
            //double d2 = 0X123.465;
            //Console.WriteLine(d2);

            //double d = 0786;
            //double d = 0XFace;

            //double d = 10;
            //Console.Write(d);// 10

            //double d = 1.23e3;
            //Console.Write(d);// 1230

            //float f = 1.2e3;
            //float f = 1.2e3f;
            //Console.Write(f);// 1200

            //Character Literals: For character data types we can specify literals in 3 ways:

            //char ch = 'a';
            //Console.Write(ch);// a

            //char ch = '\u0061'; //-- Hexa  --0061 --XXXX
            //Console.WriteLine(ch);//a --Hexa to char

            //char ch = '\u0098';
            //Console.WriteLine(ch); // ?

            //char ch = '\n';
            //Console.WriteLine(ch);// new line

            //Console.WriteLine("Hello\n\nGeeks\t!");

            //char ch = '\u0292';

            //char ch = '\t';
            //Console.WriteLine(ch.GetType());// System.Char

            //String Literals: Literals which are enclosed in double quotes(“”) or 
            //    starts with @”” are known as the String literals. 



            //String s1 = "Hello Geeks!";

            //String s2 = @"Hello Geeks!";

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //String s = @"Fahad";
            //String s1 = "Ali";
            //Console.WriteLine(s1);
            //Console.WriteLine(s);

            //Boolean Literals: Only two values are allowed 
            //    for Boolean literals i.e. true and false.

            //bool b = true;
            //bool b1 = false;
            //Console.WriteLine(b);
            //Console.WriteLine(b1);


























            Console.WriteLine();

        }
    }
}
