using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls.Fundamentals
{
    internal class DataTypes
    {
        public static void Main(string[] args)
        {
            // data Types :
            // 1. Value
            // 2. reference
            // 3. Pointer

            //Primitive DT
            // Value Type ->Signed and UnSigned Integral DT (8 Types)
            // 1. byte -
            // 2. short
            //3. int
            //4. long
            //5. sbyte
            //6. ushort
            //7. uint
            //8. ulong

            //int x1 = 10;
            //int x = 2147483647;

            //int x = 2147483647;
            //int y = -2147483648;


            //Console.WriteLine(y);

            //byte b = 10;
            byte b1 = 0;
            //byte b2 = 255;
            //byte b3 = -1;
            //byte b4 = 256;
            Console.WriteLine(b1);
            //Console.WriteLine(b2);
            //Console.WriteLine(b3);
            //Console.WriteLine(b4);
            //Console.WriteLine(b);

            //sbyte s = 10;
            //sbyte s1 = -128;
            //sbyte s2 = 127;
            //sbyte s3 = -129;
            //sbyte s4 = 128;
            //byte b = 128;

            //Console.WriteLine(s);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //Console.WriteLine(s3);
            //Console.WriteLine(s4);


            //byte b = 256;
            //Console.WriteLine(b);

            //byte b = 10.5;
            //Console.WriteLine(b);

            //byte b = true;

            //byte b = (byte)(10.5);
            //Console.WriteLine(b);// 10

            //byte b = (byte)(-1);
            //Console.WriteLine(b);

            //byte b = (byte)(255.89);
            //Console.WriteLine(b);// 255

            //byte b = 255.87;
            //Console.WriteLine(b);

            //byte b = (byte)(255.80);
            //Console.WriteLine(b);// 255

            //sbyte s = (sbyte)-125.09;
            //Console.WriteLine(s);

            //sbyte s = (sbyte)128;

            //sbyte s = (sbyte)'a';
            //Console.WriteLine(s);// 97

            //sbyte s = (sbyte)'z';
            //Console.WriteLine(s); // 122  

            //byte b = (byte)'z';
            //Console.WriteLine(b);// 122

            //short s = -32768;
            //Console.WriteLine(s);// -32768

            //short s = 32767;
            //Console.WriteLine(s);// 32767

            //short s = -32769;
            //Console.WriteLine(s);

            //short s = 32768;
            //Console.WriteLine(s);

            //ushort us = 65535;
            //Console.WriteLine(us);// 65535

            //ushort us = 0;
            //Console.WriteLine(us);// 0

            //ushort us = -1;
            //Console.WriteLine(us);

            //ushort us = 65536;
            //Console.WriteLine(us);

            //short s = (short) 10321.2323f;
            //Console.WriteLine(s);// 10321

            //ushort s = (ushort)10321.2323f;
            //Console.WriteLine(s);// 10321

            //short s = (short)-10200.381819F;
            //Console.WriteLine(s); // -10200


            //ushort us = (ushort)-10200.381819F;
            //Console.WriteLine(us); 


            //ushort us =(ushort) 122.3032;
            //Console.WriteLine(us);// 122

            //sbyte s = 126;
            //Console.WriteLine(s);
            //s++;
            //Console.WriteLine(s);
            //s++;
            //Console.WriteLine(s);
            //s++;
            //Console.WriteLine(s);
            //s++;
            //Console.WriteLine(s);
            //s--;
            //Console.WriteLine(s);

            //byte b = 0;
            //Console.WriteLine(b);
            //b++;
            //Console.WriteLine(b);
            //b = 254;
            //b++;
            //Console.WriteLine(b);
            //b++;
            //Console.WriteLine(b);
            //b++;
            //Console.WriteLine(b);

            //char a = 'G';
            //int i = 89;
            //short s = 56;
            //long l = 4564;
            //uint ui = 95;
            //ushort us = 76;
            //ulong ul = 3624573;
            //double d = 8.358674532;
            //float f = 3.7330645f;
            //decimal dec = 389.5m;

            //Console.WriteLine("char: " + a);
            //Console.WriteLine("integer: " + i);
            //Console.WriteLine("short: " + s);
            //Console.WriteLine("long: " + l);
            //Console.WriteLine("float: " + f);
            //Console.WriteLine("double: " + d);
            //Console.WriteLine("decimal: " + dec);
            //Console.WriteLine("Unsinged integer: " + ui);
            //Console.WriteLine("Unsinged short: " + us);
            //Console.WriteLine("Unsinged long: " + ul);


            //long l = 1092912;
            //Console.WriteLine(l);

            //long l = -19329042;
            //Console.WriteLine(l);

            //ulong ul = -9349132;
            //Console.WriteLine(ul);

            //float f = 92388.23923F;
            //Console.WriteLine(f);// 92388.24

            //double d = 2321.22112;
            //Console.WriteLine(d);

            //double d = 210894.240982109000d;
            //Console.WriteLine(d);// 210894.240982109

            //double d = 1391.23432D;
            //Console.WriteLine(d);

            //decimal d = 13213124309981904718980210982.2141241242187214987679876879987679889724891268921764891264891789981274091274981247198247129847981274918274981274981274982174192874918267498126741892648912649812647128946981722146891246898912749812649814020999999m;
            //Console.WriteLine(d);// 13213124309981904718980210982

            //decimal d = 2414.24124M;
            //Console.WriteLine(d);// 2414.24124

            //int x = (int)2147483648l;

            //Boolean b = true;
            //Console.WriteLine(b);// True

            //Boolean b = True;
            //Console.WriteLine(b);

            //Boolean b = "true";
            //Console.WriteLine(b);

            //Boolean b = false;
            //boolean c = true;

            //bool b = true;
            //Console.WriteLine(b);

            //Bool b = true;
            //Console.WriteLine(b);

            //Boolean b = false;
            //Console.WriteLine(b);

            //bool b = true;
            //Console.WriteLine(b);


            //int x = 0;
            //if (x)
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine(x);
            //}

            //int x = 1;
            //while (1)
            //{
            //    Console.WriteLine();
            //}

            //char ch= 'f';
            //Console.WriteLine(ch);

            //char ch = ' ';
            //Console.WriteLine(ch);

            //char c = '0';
            //Console.WriteLine(c);// 0

            //char ch = '9';
            //Console.WriteLine(ch);// 9

            //char ch1 = 'a';
            //Console.WriteLine(ch1);// a

            //int x = 'a'; //implicit type casting char to int convrsion 
            //Console.WriteLine(x);// 97

            //char ch = null;
            //Console.WriteLine(ch);

            //bool b = true;
            //if(b == true)
            //{
            //    Console.WriteLine("Yes");
            //}

            //bool b = false;
            //if (true)
            //{
            //    Console.WriteLine("Yes");
            //}

            //2. reference DT
            //2.1 - string
            //2.2 - object

            //String: It represents a sequence of Unicode characters and its 
            //        type name is System.String.So, string and String are equivalent.

            //string s1 = "hello"; // creating through string keyword  
            //String s2 = "welcome"; // creating through String class 

            //Console.WriteLine(s1);// hello
            //Console.WriteLine(s2);// welcome

            //Object: In C#, all types, predefined and user-defined, reference types 
            //        and value types, inherit directly or indirectly from Object. 
            //        So basically it is the base class for all the data types in C#.

            //string s = "Geek";
            //s += "for";
            //s = s + "Geeks";

            //Console.WriteLine(s);//GeekforGeeks

            //object obj;
            //obj = 20;
            //Console.WriteLine(obj);// 20  -- object to value type -- unboxing

            //Console.WriteLine(obj.GetType());// System.Int32

            //3.Pointer Data Type : The Pointer Data Types will contain a memory address
            //    of the variable value.

            //To get the pointer details we have a two symbols ampersand(&) and asterisk(*).
            //ampersand(&): It is Known as Address Operator.It is used to determine the address of a variable.
            //asterisk(*): It also known as Indirection Operator.It is used to access the value of an address.

            //unsafe
            //{
            //    int n = 10;
            //    int* p = &n;
            //    Console.WriteLine("value of variable n : {0}" , n);// 10
            //    Console.WriteLine("address of variable p : {0} ",(int) p);// 678947020 -- changes every time

            //}

            //need to study further on pinter concepts
        }
    }
}
