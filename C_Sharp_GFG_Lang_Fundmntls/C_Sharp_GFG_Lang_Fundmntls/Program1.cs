using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_GFG_Lang_Fundmntls
{
    //internal class Complex {

    //    int real;
    //    int img;

    //    public void setData(int r, int i)
    //    {
    //        real = r;
    //        img = i;
    //    }

    //    public void displayData()
    //    {
    //        Console.WriteLine("The value of real is {0}: " + real);
    //        Console.WriteLine("The value of imagenary is {0}: " + img);
    //    }
    //}

    //class Modif
    //{
    //    public static void Main(String[] args)
    //    {
    //        Complex obj = new Complex();
    //        obj.setData(1, 2);
    //        obj.displayData();
    //    }
    //}

    //class parent
    //{
    //    private int value;

    //    public void setValue(int v)
    //    {
    //        value = v;
    //    }

    //    public int getValue()
    //    {
    //        return value;
    //    }

    //}
    //class child  : parent
    //{
    //    public void displayValue()
    //    {
    //        Console.WriteLine("Value = " + value);
    //    }
    //}

    //class Parent
    //{
    //    private protected int value;

    //    public void setValue(int v)
    //    {
    //        value = v;
    //    }
    //    public int getValue()
    //    {
    //        return value;
    //    }
    //}

    //class Child : Parent
    //{
    //    public void showValue()
    //    {
    //        Console.WriteLine("Value = "+ value);
    //    }
    //}

    internal class Program1
    {
        //    //1.Class Level Scope

        //int x = 10;

        //public void display()
        //{
        //    Console.WriteLine(x);
        //}

        //public void Display()
        //{
        //    int x = 19;
        //    Console.WriteLine(x);
        //}

        //public void Display1()
        //{

        //    Console.WriteLine(x);
        //}


        //public void display()
        //{
        //    int i = 0;
        //    for (i=0; i<3;i++)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}

        //public int rollno;
        //public string name;

        //public Program1(int r, string n)
        //{
        //    rollno = r;
        //    name = n;
        //}

        //public int getRollno()
        //{
        //    return rollno;
        //}

        //public string getName()
        //{
        //    return name;
        //}

        //class XPAM
        // {
        //     protected int x;

        //     public XPAM()
        //     {
        //         x = 10;
        //     }
        // }
        // class Y : XPAM
        // {
        //     public int getX()
        //     {
        //         return x;
        //     }
        // }

        //protected internal int value;

        //public class ABC
        //{
        //    public void testAccess()
        //    {
        //        Program1 obj = new Program1();
        //        obj.value = 19;
        //    }
        //}

        

        public static void Main(string[] args)
        {


            // Binary Literals and Digit Separators in C#
            //var num1 = 0b1010;
            //var num2 = 0b01000011;

            //Console.WriteLine(num1);// 10 // by default int me value reutrn karega
            //Console.WriteLine(num2);// 67
            //Console.WriteLine("Character value of binary num2 is {0} : " + Convert.ToChar(num2));

            //var num3 = 0b101010001010101100010;
            //Console.WriteLine("Integer value of " + num3 + " is :"+ Convert.ToInt32(num3));

            //Digit Separator


            // Without Using digit separators
            //long x = 100000022200000202;
            //long z = 10000000020;

            //Console.WriteLine("X: {0}", x);   //  X: 100000022200000202
            //Console.WriteLine("Z: {0}", z);   //  Z: 10000000020

            //// Using digit separators
            //long num1 = 1_00_10_00_00_00;
            //var num2 = 0b_010_000_000_000_000_000_000_000_000;
            //long num3 = 1_00_00_00_00_00_00;
            //var num4 = 0b_1_1000_0000_1000_0000_0011_0000_0000_1000_0001;

            //Console.WriteLine("Num1: {0}", num1);   // Num1: 10010000000
            //Console.WriteLine("Num2: {0}", num2);   // Num2: 33554432
            //Console.WriteLine("Num3: {0}", num3);   // Num3: 1000000000000
            //Console.WriteLine("Num4: {0}", num4);   // Num4: 103213629569


            //Scope of Variables in C#

            //1.Class Level Scope
            //2.Method Level Scope
            //3.Block Level Scope

            //1.Class Level Scope

            //Program1 obj = new Program1();
            //obj.display();


            //2.Method Level Scope/behave like Local variable
            //Program1 obj = new Program1();
            //obj.Display();
            //obj.Display1(); //  The name 'x' does not exist in the current context


            //3.Block Level Scope

            //Program1 obj = new Program1();
            //obj.display();// 0,1,2

            //for (int j=0; j<4; j++)
            //{
            //    //Console.WriteLine(j);// 0,1,2,3
            //}
            //Console.WriteLine(j);


            //Console.WriteLine(i);


            //Program1 obj = new Program1(1,"Fahad");
            //Console.WriteLine("ROll no is  {0} : " + obj.rollno);
            //Console.WriteLine("Name is  {0} : " + obj.name);
            //Console.WriteLine("Roll no is : {0}"+obj.getRollno());
            //Console.WriteLine("Name is : {0}" + obj.getName());

            //XPAM obj1 = new XPAM();
            //Y obj2 = new Y();
            //Console.WriteLine("Value of x is {0} "+ obj2.getX());

            //internal/default Accessibility Level

            //Access is limited to only the current Assembly, that is any
            //class or type declared as internal is accessible anywhere
            //inside the same namespace.It is the default access modifier
            //in C#.

            // Instantiate the class Complex
            // in separate class but within
            // the same assembly


            //parent obj = new parent();
            //obj.setValue(4);
            //Console.WriteLine("Value = :" + obj.getValue());

            //private protected Accessibility Level
            //Access is granted to the containing class and its derived
            //types present in the current assembly.This modifier is valid
            //in C# version 7.2 and later.

            //Parent objparnt = new Parent();
            //objparnt.setValue(4);
            //Console.WriteLine("Get Value "+ objparnt.getValue());

            //byte b = 10;
            //byte c = 20;
            //byte a = b + c;
            //Console.WriteLine(a);

            //byte b = 10;
            //byte c = 20;
            //byte a = (byte)(b + c);// 30
            //Console.WriteLine(a);// 30


            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");




















        }  // main method end tag

    } // class end tag

    

} // namespae end tag
