using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //String is immutable never changes and when we perform any operation
            //on string it creates a new string object in memory and old one is not changed and garbege.
            //it is not good for performance and memory management when we have to perform many operations on string.
            //StringBuilder sb = new StringBuilder();
            //var watch1= System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i <= 5000; i++)
            //{
            //    sb.Append("prod-" + i + ",");
            //    watch1.Stop();

            //}
            //Console.WriteLine($"StringBuilder Time: {watch1.ElapsedMilliseconds} ms");
            //string productlist = "";
            //var watch2 = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i <= 5000; i++)
            //{ productlist += "prod-" + i + ","; }
            //Console.WriteLine($"StringBuilder Time: {watch2.ElapsedMilliseconds} ms");

            #endregion
            #region َََََQ2
            //Console.WriteLine("Enter your age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the day (1-7, where 6=Fri, 7=Sat):");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have a student ID? (yes/no):");
            //string studentid = Console.ReadLine().ToLower();
            //bool isStudent = studentid == "yes";
            //double ticketPrice = 0;
            //double overPrice = 0;
            //double discount = 0;
            //if (age < 5)
            //{
            //    ticketPrice = 0; // Free for children under 5
            //}
            //else if (age > 5 && age <= 12)
            //{
            //    ticketPrice = 30; // $30 for children between 5 and 12
            //}
            //else if (age > 12 && age <= 59)
            //{
            //    ticketPrice = 50; // $50 for adults between 12 and 59
            //}
            //else
            //{
            //    ticketPrice = 25; // $25 for seniors over 60
            //}
            //if (ticketPrice > 0 && (day == 6 || day == 7))
            //{
            //    overPrice = 10;
            //}

            //double totalPrice = ticketPrice + overPrice;

            //if(isStudent&& totalPrice > 0)
            //{
            //                    discount = totalPrice * 0.20;
            //}
            //totalPrice -= discount;
            //Console.WriteLine($" Ticket Price: ${ticketPrice}");
            //if(discount>0)
            //{
            //    Console.WriteLine($" Student Discount: -${discount}");
            //}
            //else
            //{
            //    Console.WriteLine(" No Student Discount Applied");
            //}
            //if (overPrice > 0)
            //{
            //    Console.WriteLine($" Weekend Surcharge: +${overPrice}");
            //}
            //else
            //{
            //    Console.WriteLine(" No Weekend Surcharge Applied");
            //}


            #endregion
        }
    }
}
