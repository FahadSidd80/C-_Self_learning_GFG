using System;


namespace C_Sharp_GFG_Lang_Fundmntls
{
    //public class MyClass2
    //{
    //    public static int num;
    //}
    class Program
	{
        //public static int num;
        //int engMarks ;
        //int mathMarks ;
        //int phyMarks ;


        //static int x = 10;
        //const int max = 90;


        //int y;
        //byte b;
        //short s;
        //long l;

        //float f;
        //double d;

        //char ch;

        //public void StudentAge()
        //{
        //    int age = 10;
        //    age = age + 10;
        //    Console.WriteLine(age);
        //}




        //int age;
        //Program()
        //{
        //    this.age = 20;
        //}

        //Program()
        //{
        //    this.salary = 20;
        //}

        //int salary;// instance variable

        //int salary=40000;// instance variable
        //static String name = "Fahad";// static variable
        //const float max=90;// const variable

        //readonly int k;
        //public Program()
        //{
        //    this.k = 90;
        //}

        //var x = 10;


        public static void addstr(dynamic s1, dynamic s2)
        {
            Console.WriteLine(s1 + s2);
        }

        public static void Main(string[] args)
		{



            //Console.WriteLine();

            //Console.WriteLine("Hello world !!");
            //Console.WriteLine("Hello World");
            //int x = 10;
            //Console.WriteLine(x);

            //int Number = 10;
            //int number = 20;
            //int NUMBER = 30;

            //Console.WriteLine(Number+".."+number+".."+NUMBER);

            //so from above we can conclude C# is case sensitive lang.

            // ex : int Number = 10;
            //		// int NUMBER = 10;
            //		// int number = 10;
            //		// all above line has different meaning.

            //Identifiers in C#

            //int idn = 10;
            //int x=10;
            //int xy_ = 20;
            //int _xy = 30;
            //int x__y = 40;
            //int __xy = 90;
            //int Xy___ = 100;
            ////int xy@ = 90;
            ////int x y = 20;
            ////int 19xy = 20;
            //int xy19 = 20;
            //int @Main = 90;
            //int System = 80;
            ////int using = 90;
            //int @using = 100;
            //int @import = 19;
            //int @ax12__A = 10;
            //Console.WriteLine(idn+".."+xy_+".."+x+".."+_xy+".."+x__y+".."+__xy+".."+Xy___+".."+xy19+".."+@Main+".."+System+".."+@using+".."+@import+".."+ @ax12__A);

            //int a = 10;
            //int b = 20;
            //int c;
            //int d;
            //c = a + b;
            //d = a - b;
            // Two ways -- string interpolation {0}
            //Console.WriteLine(c);
            //Console.WriteLine("The sum of two number is: {0}", c); //The sum of two number is: 30
            //Console.WriteLine("The subtract of two number is: {0}", d);// The subtract of two number is: -10
            //Console.WriteLine("The sum and Substraction of numbers is {0}, {1}", c, d);// The sum and Substraction of numbers is 30, -10

            //Console.WriteLine($"The Sum of Two Number is : {c} \n  and the subtarction of two number is : {d}");
            //The Sum of Two Number is : 30
            //and the subtarction of two number is : -10

            // reserved keyword in C# but we use as identifie by using @ in start of it.
            //int @using = 10;
            //int @public = 90;

            //int @static = 19;

            //int @void = 29;
            //int @int = 40;

            //int Main = 90;
            //Console.WriteLine(@using);		//10
            //Console.WriteLine(@public);		//90
            //Console.WriteLine(@static);		//19
            //Console.WriteLine(@void);		//29
            //Console.WriteLine(@int);		//40
            //Console.WriteLine(Main);		//90

            //			Data types in C# is mainly divided into three categories

            //Value Data Types
            //Reference Data Types
            //Pointer Data Type


            //1. sbyte

            //sbyte s = -128;
            //Console.WriteLine(s);

            //sbyte s1 = 127;
            //Console.WriteLine(s1);

            //sbyte s3 = 128;
            //Console.WriteLine(s3);

            //sbyte s4 = -129;
            //Console.WriteLine(s4);

            //sbyte b = 10.5;
            //Console.WriteLine(b); //  Cannot implicitly convert type 'double' to 'sbyte'

            //sbyte b = true;
            //Console.WriteLine(b);// Cannot implicitly convert type 'bool' to 'sbyte'

            //sbyte b = "Durga";
            //Console.WriteLine(b);

            //2. short

            //short s = -32768;
            //Console.WriteLine(s);

            //short s = 32767;
            //Console.WriteLine(s);

            //short s = -32769;
            //Console.WriteLine(s);

            //short s = 32768;
            //Console.WriteLine(s);

            //short s = true;
            //Console.WriteLine(s);

            //3. Int :-
            //-2147483648 to  2147483647 

            //int x = -2147483648;
            //Console.WriteLine(x);

            //int x = 2147483647;
            //Console.WriteLine(x);

            //int x = 2147483648;
            //Console.WriteLine(x);

            //int x = 2147483648l;
            //Console.WriteLine(x);

            //int x1 = 2147483648L;
            //Console.WriteLine(x);

            //int x = true;
            //Console.WriteLine(x);

            //long x = 10;
            //Console.WriteLine(x);

            //long l = 923932993893893983l;
            //Console.WriteLine(l);

            //ulong l = 9239329938938939803l;
            //Console.WriteLine(l);

            // Floating Point type

            // float number :-

            //float f = 12.0f;
            //Console.WriteLine(f);

            //float f = 12.34f;
            //Console.WriteLine(f);

            //float f=10.0F;
            //Console.WriteLine(f);

            //double 

            //double d = 10.98;
            //Console.WriteLine(d);

            //decimal d = 12103.3213m;
            //Console.WriteLine(d);

            //char ch = 'A';
            //Console.WriteLine(ch);

            //char ch = 'd';
            //Console.WriteLine( ch);

            //int x = 10;
            //Console.WriteLine(x);

            //uint ui = 0;
            //Console.WriteLine(ui);

            //uint i = -90;
            //Console.WriteLine(i);

            //uint uii = 90737;
            //Console.WriteLine(uii);

            //char ch = 'A';
            //Console.WriteLine(ch);

            //int x = 10;
            //Console.WriteLine(x);

            //short sh = 123;
            //Console.WriteLine(sh);


            //long ln = 2323013;
            //Console.WriteLine(ln);

            //uint ui = 10;
            //Console.WriteLine(ui);

            //ushort us = 10;
            //Console.WriteLine(us);

            //ulong ul = 1021931;
            //Console.WriteLine(ul);

            //double db = 121921.101;
            //Console.WriteLine(db);

            //float fl = 12012.13913f;
            //Console.WriteLine(fl);

            //decimal dm = 121931.3023m;
            //Console.WriteLine(dm);

            //Console.WriteLine("char: " + ch);
            //Console.WriteLine("integer: " + x);
            //Console.WriteLine("short: " + sh);
            //Console.WriteLine("long: " + ln);
            //Console.WriteLine("float: " + fl);
            //Console.WriteLine("double: " + db);
            //Console.WriteLine("decimal: " + dm);
            //Console.WriteLine("Unsinged integer: " + ui);
            //Console.WriteLine("Unsinged short: " + us);
            //Console.WriteLine("Unsinged long: " + ul);


            //sbyte

            //sbyte a = 126;
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //sbyte sb = -129;
            //Console.WriteLine(sb);

            //byte b = 0;
            //Console.WriteLine(b);

            //b++;
            //Console.WriteLine(b);

            //b = 254;
            //Console.WriteLine(b);
            //b++;
            //Console.WriteLine(b);

            //b++;
            //Console.WriteLine(b);

            //bool b = true;
            //Console.WriteLine(b);

            //if (b==true)
            //{
            //    Console.WriteLine("Sahi hai beta !! Go ahed ");
            //}

            //2. REFERENCE DATATYPE:-

            //1. String
            //2. Object 

            //string s = "It represents a sequence of Unicode characters ";
            //String sh = " its type name is System.String. So, string and String are equivalent.";

            //Console.WriteLine(s); // creating through string keyword
            //Console.WriteLine(sh);// creating through string class

            //String st = "Fahah";
            //Console.WriteLine(st);

            //string a = "Geeks";
            //a = a + " for";
            //a = a + " Geeks";
            //Console.WriteLine(a);

            //object obj;
            //obj = 20;
            //Console.WriteLine(obj);

            //Console.WriteLine(obj.GetType());

            //3. Pointer DataType

            //unsafe
            //{
            //int n = 10;
            //int* p = &n;
            //Console.WriteLine("Value {0}:",n);
            //Console.WriteLine("Address {0}:", (int)p);


            //int x = 10;
            //int* p= &x;
            //Console.WriteLine("Address {0}", (int)&x);//Address -1034427012
            //Console.WriteLine("Address {0}", (int)p); //Address -1034427012
            //Console.WriteLine("Value {0}", x);        //Value 10

            //Need to study Further

            //int x =10;
            //int* p = &x;
            //Console.WriteLine(x);
            //Console.WriteLine((int)&x);
            //Console.WriteLine((int)p);


            //3. Variabe

            //int x = 10;
            //int a, y, z = 20;
            //a = 30;
            //y = 40;
            //char ch, ab, cg = 'A';

            //float f, c, g = 10.0f;
            //Console.WriteLine(x);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(y);

            //int a, b, c;
            //a = 10;
            //b = 20;
            //c = 30;

            //Console.WriteLine(a+""+b+""+c);

            //int @int = 10;
            // Console.WriteLine(@int);


            //int age;
            //float _studentname;

            //int geeks;
            //int bookprice;

            //int x1 = 10;// Declaration only
            //int x;
            //x = 10; // Initialization 

            //Two Ways for Initialization:

            //    1. Compile time initialization
            //    2. Run time initialization

            //1.Compile time initialization
            //int s = 10;
            //Console.WriteLine(s);

            //Program obj = new Program();
            //  Console.WriteLine(obj.y);// 0
            //  Console.WriteLine(obj.b);// 0
            //  Console.WriteLine(obj.s);// 0
            //  Console.WriteLine(obj.l);// 0
            //  Console.WriteLine(obj.f);// 0
            //  Console.WriteLine(obj.d);// 0
            //  Console.WriteLine(obj.ch);// 0
            //Console.WriteLine(obj.y);

            //int y;
            //byte b;
            //short s;
            //long l;

            //float f;
            //double d;

            //char ch;
            //2.Run Time Initialization
            //Console.Write("Please enter a value to print: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Value is : "+ num);



            //Types of Variables

            //    1.Local variables
            //    2.Instance variables or Non – Static Variables
            //    3.Static Variables or Class Variables
            //    4.Constant Variables
            //    5.Readonly Variables

            //Local Variables :-
            // variable defined within a block or method or constructor

            //Program objage = new Program();
            //objage.StudentAge();
            //Console.WriteLine(age);


            //2.Instance Variables or Non – Static Variables

            //Instance variables are non-static variables and are
            //declared in a class but outside any method, constructor or block

            //Program obj1_Marks = new Program();
            //obj1_Marks.mathMarks = 10;
            //obj1_Marks.engMarks = 30;
            //obj1_Marks.phyMarks = 60;


            //Program obj2_Marks = new Program();
            //obj2_Marks.mathMarks = 30;
            //obj2_Marks.engMarks = 60;
            //obj2_Marks.phyMarks = 90;

            //Console.WriteLine("Marks for object one ");
            //Console.WriteLine(obj1_Marks.engMarks);
            //Console.WriteLine(obj1_Marks.mathMarks);
            //Console.WriteLine(obj1_Marks.phyMarks);


            //Console.WriteLine("Marks for object two ");
            //Console.WriteLine(obj2_Marks.engMarks);
            //Console.WriteLine(obj2_Marks.mathMarks);
            //Console.WriteLine(obj2_Marks.phyMarks);

            //3. Static variable

            //These variables are declared similarly as instance variables,
            //the difference is that static variables are declared using    
            //the static keyword within a class outside any method 
            //constructor or block.


            //Program.salary= 10000;
            //Console.WriteLine(Program.name+"'s avaerage salary is : "+ Program.salary);
            //Program objins = new Program();
            //objins.age = 30;
            //Console.WriteLine(objins.age);

            // Difference between Instance variable & Static variable

            //Program ObjInsVar = new Program();
            //ObjInsVar.salary = 1000;
            //ObjInsVar.salary = 2000;
            //ObjInsVar.salary = 3000;

            //Console.WriteLine(ObjInsVar.salary);// 3000

            //Program ObjInsVar1 = new Program();
            //ObjInsVar1.salary = 5000;
            //ObjInsVar1.salary = 9000;
            //ObjInsVar1.salary = 6000;

            //Console.WriteLine(ObjInsVar1.salary);// 6000


            //Program ObjInsVar2 = new Program();
            //ObjInsVar.salary = 1000;
            //ObjInsVar.salary = 2000;
            //ObjInsVar.salary = 3000;

            //Console.WriteLine(ObjInsVar.salary);// 3000

            //Program ObjInsVar3 = new Program();

            //ObjInsVar3.salary = 6000;

            //Console.WriteLine(ObjInsVar3.salary);// 6000


            //Program ObjInsVar4 = new Program();

            //ObjInsVar4.salary = 9000;

            //Console.WriteLine(ObjInsVar4.salary);// 9000


            //Program ObjInsVar4 = new Program();

            //Console.WriteLine(Program.name);
            //Console.WriteLine(ObjInsVar4.name);


            //int i = ObjInsVar4.num;

            //Program ObjInsVar4 = new Program();

            //Console.WriteLine(ObjInsVar4.salary);
            //Console.WriteLine(Program.name);


            //Program ObjInsVar5 = new Program();
            //ObjInsVar5.salary = 1900;
            //Console.WriteLine(ObjInsVar5.salary);

            // Need to study further on Instance and static variable


            //Constants Variables

            //Program objCons = new Program();
            //Console.WriteLine(Program.max);

            //Program objVar = new Program();
            //Console.WriteLine("Instance variable: "+objVar.salary);
            //Console.WriteLine("Static variable: "+Program.name);
            //Console.WriteLine("Constant variable: "+Program.max);

            //Program objRedonly = new Program();
            //Console.WriteLine("The value of readonly var is : "+ objRedonly.k);

            //objRedonly.k = 30;
            //Console.WriteLine(objRedonly.k);
            //Console.WriteLine(Program.k);

            // Implicitly Typed Local Variables – var

            //var ivariable = 90;
            //Console.WriteLine(ivariable);

            //var i = 10, p = 90;
            //Console.WriteLine(i+".."+p);


            //var ivar =10;
            //var b -= 90;// Need to study more
            //Console.WriteLine(b);

            //var val = null;

            //var data = { 10,20,30};

            //var data = new int[] {20,40,50,60 };
            //Console.WriteLine(data[0]);
            //Console.WriteLine(data[1]);
            //Console.WriteLine(data[2]);
            //Console.WriteLine(data[3]);

            //var value = "Fa";
            ////value = new int[] { 10,20};

            //value = new string[] { "faa","had" };


            //var value = new int[] {10,20,30 };
            //value = 10;

            //var a = 10 ;
            //var b = "Fahad";
            //var c = 212.23d;
            //var d = false;
            //Console.WriteLine("Type of 'a' is {0} : "+ a.GetType());  // System.Int32
            //Console.WriteLine("Type of 'b' is {0} : " + b.GetType()); // System.String
            //Console.WriteLine("Type of 'c' is {0} : " + c.GetType()); // System.Double
            //Console.WriteLine("Type of 'd' is {0} : " + d.GetType()); // System.Boolean

            //Note: Implicitly typed local variables can be used as a local variable in a function,
            // in foreach, and for loop, as an anonymous type, in LINQ query expression,
            // in using statement etc.

            //var height = 10;
            //var Base = 40;
            //var area = (height * Base)/2;
            //Console.WriteLine("The height of traingle is : " + height + "\n The base of triangle is : " + Base );
            //Console.WriteLine("The area of triangle is : {0} " , area);// 200
            //Console.WriteLine("The area of triangle is :  " + area); // 200

            //Dynamic Type in C#

            //dynamic value = 20;
            //Console.WriteLine(value);

            //dynamic value1 = "Fahad string";
            //dynamic value2 = 10;
            //dynamic value3 = 2321.32;
            //dynamic value4 = true;
            //dynamic value5 = 213213d;

            //Console.WriteLine("Get the actual type of value1 {0} :"+ value1.GetType().ToString());  // :System.String
            //Console.WriteLine("Get the actual type of value1 {0} :"+ value2.GetType().ToString());  // :System.Int32
            //Console.WriteLine("Get the actual type of value1 {0} :"+ value3.GetType().ToString());  // :System.Double
            //Console.WriteLine("Get the actual type of value1 {0} :"+ value4.GetType().ToString());  // :System.Boolean
            //Console.WriteLine("Get the actual type of value1 {0} :"+ value5.GetType().ToString());  // :System.Double


            //addstr("Fahad","ali");      // Fahadali
            //addstr("GFG","GFG");        // GFGGFG
            //addstr("Hello","123");      // Hello123
            //addstr("123","ali");        // 123ali
            //addstr("10","80");          // 1080
            //addstr(10, 30);             // 40
            //addstr(10, 30.323);         // 40.323
            //addstr(10.0f, 23.32d);      // 33.32
            //addstr(10, 121.32f);        // 131.32
            //addstr(10, 30.3123d);       // 40.3123

            //Difference between var and dynamic in C#
            //  var Type 
            //var a = 'f';
            //var b = "GeeksforGeeks";
            //var c = 30.67d;
            //var d = false;
            //var e = 54544;

            //// Display the type
            //Console.WriteLine("Type of 'a' is : {0} ", a.GetType());

            //Console.WriteLine("Type of 'b' is : {0} ", b.GetType());

            //Console.WriteLine("Type of 'c' is : {0} ", c.GetType());

            //Console.WriteLine("Type of 'd' is : {0} ", d.GetType());

            //Console.WriteLine("Type of 'e' is : {0} ", e.GetType());


            ////dynamic Type 

            //dynamic val1 = "GeeksforGeeks";
            //dynamic val2 = 3234;
            //dynamic val3 = 32.55;
            //dynamic val4 = true;

            //// Get the actual type of
            //// dynamic variables
            //// Using GetType() method
            //Console.WriteLine("Get the actual type of val1: {0}",
            //                          val1.GetType().ToString());

            //Console.WriteLine("Get the actual type of val2: {0}",
            //                          val2.GetType().ToString());

            //Console.WriteLine("Get the actual type of val3: {0}",
            //                          val3.GetType().ToString());

            //Console.WriteLine("Get the actual type of val4: {0}",
            //                          val4.GetType().ToString());




















            //}
            Console.ReadKey();
		}
	}
}



