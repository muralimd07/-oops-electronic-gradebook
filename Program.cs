using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Electronicgradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            studentdetails dt = new studentdetails();
            dt.getmarks(2);
            dt.showstudentdetails();

            Console.ReadKey();
        }
    }
}
