using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls.Fundamentals
{
    public class Student
    {

        // Declare name field  
        private string name = "GeeksforGeeks";

        // Declare name property  
        public string Name
        {

            // get is contextual keyword 
            get
            {
                return name;
            }

            // set is a contextual 
            // keyword 
            set
            {
                name = value;
            }
        }
    }

    internal class Keywords
    {

        //class Mod
        //{

        //    // using public modifier 
        //    // keyword 
        //    public int n1;

        //}

        public static void Main(String[] args)
        {

            // here int is keyword and a is identifier
            //int a = 10;

            //Console.WriteLine("The value of a is: {0}", a);


            //There are total 78 keywords in C# as follows:
            //Keywords in C# is mainly divided into 10 categories as follows:

            //1. Value Type Keywords: There are 15 keywords in value types which
            //are used to define various data types.

            // here byte is keyword 
            //// a is identifier 
            //byte a = 47;
            //Console.WriteLine("The value of a is: {0}", a);


            //// here bool is keyword 
            //// b is identifier 
            //// true is a keyword 
            //bool b = true;

            //Console.WriteLine("The value of b is: {0}", b);

            //3. Reference Type Keywords: There are 6 keywords in reference types
            //which are used to store references of the data or objects.
            //The keywords in this category are: class, delegate, interface,
            //object, string, void.


            //4. Modifiers Keywords: There are 17 keywords in modifiers which are
            //used to modify the declarations of type member.


            //Mod obj1 = new Mod();

            //// access to public members 
            //obj1.n1 = 77;

            //Console.WriteLine("Value of n1: {0}", obj1.n1);


            //6.Statements Keywords: There are total 18 keywords which are used
            //in program instructions.


            // using for as statement keyword 
            // GeeksforGeeks is printed only 2 times  
            // because of continue statement  
            //for (int i = 1; i < 3; i++)
            //{

            //    // here if and continue are keywords 
            //    if (i == 2)
            //        continue;

            //    Console.WriteLine("GeeksforGeeks");

            //}

            //8. Method Parameters Keywords: There are total 4 keywords which
            //are used to change the behavior of the parameters that passed to
            //a method. The keyword includes in this category are: params, in, ref,
            //out.


            //9. Namespace Keywords: There are total 3 keywords in this category which
            //are used in namespaces.The keywords are: namespace, using, extern.


            //10..Operator Keywords: There are total 8 keywords which are used for different
            //purposes like creating objects, getting a size of object etc.The keywords are:
            //as, is, new, sizeof, typeof, true, false, stackalloc.


            //11. Conversion Keywords: There are 3 keywords which are used in type conversions.
            //The keywords are: explicit, implicit, operator.



            //12. Access Keywords: There are 2 keywords which are used in accessing and referencing
            //the class or instance of the class. The keywords are base, this.

            //13.  Literal Keywords: There are 2 keywords which are used as literal or constant.
            //The keywords are null, default.

            //, Important Points:
            //Keywords are not used as an identifier or name of a class, variable, etc.
            //If you want to use a keyword as an identifier then you must use @ as a prefix.For
            //example, @abstract is valid identifier but not abstract because it is a keyword.


            // Example:

            //int a = 10;              // Here int is a valid keyword

            //double int = 10.67;     // invalid because int is a keyword

            //double @int = 10.67;   // valid identifier, prefixed with @

            //int @null = 0;       // valid

            // C# Program to illustrate the use of  
            // prefixing @ in keywords 

            // here int is keyword 
            // a is identifier 
            //int a = 10;

            //Console.WriteLine("The value of a is: {0}", a);

            //// prefix @ in keyword int which  
            //// makes it a valid identifier 
            //int @int = 11;

            //Console.WriteLine("The value of a is: {0}", @int);


            //Contextual Keywords
            //These are used to give a specific meaning in the program.
            //Whenever a new keyword comes in C#, it is added to the contextual
            //keywords, not in the keyword category. This helps to avoid the
            //crashing of programs which are written in earlier versions.

            //Important Points:

            //These are not reserved words.
            //It can be used as identifiers outside the context that’s why
            //it named contextual keywords.
            //These can have different meanings in two or more contexts.
            //There are total 30 contextual keywords in C#.

            //Eg
            Student s = new Student();

            // calls set accessor of the property Name,  
            // and pass "GFG" as value of the  
            // standard field 'value'.  
            s.Name = "GFG";

            // displays GFG, Calls the get accessor  
            // of the property Name.  
            Console.WriteLine("Name: " + s.Name);

            // using get and set as identifier 
            int get = 50;
            int set = 70;

            Console.WriteLine("Value of get is: {0}", get);
            Console.WriteLine("Value of set is: {0}", set);



            Console.ReadLine();
        }
    }
}
