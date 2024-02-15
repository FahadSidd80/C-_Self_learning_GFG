using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Calculte_interest
{
    public partial class InterestCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalculate_Click(object sender, EventArgs e)
        {
            Calculation();
        }

        public void Calculation()
        {
            Console.WriteLine("Program to calculate interest of Credit card !!!!\n\n");
            Console.WriteLine("Enter number of months interest to be calculated :");
            int noOfMonths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter difference amount in  every months : ");
            int diffamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Interest amount of 1st month : ");
            int interestAmount = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[noOfMonths + 1];
            x[0] = interestAmount;
            int sum = 0;
            int i;
            for (i = 1; i < x.Length; i++)
            {
                x[i] = (x[i - 1] - diffamount);
                sum += x[i - 1];
                Console.WriteLine("z = " + i + "th month " + x[i - 1] + " Rs.");
                Console.WriteLine("\n");
            }
            int sumplusextra;
            Console.WriteLine("Enter extra amount per month :");
            int extra = Convert.ToInt32(Console.ReadLine());
            extra = noOfMonths * extra;
            sumplusextra = sum + extra;
            Console.WriteLine("\n");
            Console.WriteLine($"Sum of total interest amount for {noOfMonths} Months without extra amount : " + sum);
            Console.WriteLine($"Sum of total interest amount for {noOfMonths} Months plus extra amount : " + sumplusextra);
            Console.WriteLine("Difference in amount : " + (sumplusextra - sum));
        }
    }
}