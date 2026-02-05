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
        }
    }
}
