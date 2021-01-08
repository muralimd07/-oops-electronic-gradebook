using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronicgradebook
{
     class studentdetails
    {
       
       public SortedList<string, double> marklist = new SortedList<string, double>();

       #region getmarks
       public  SortedList<string, double> getmarks(int numberofsubject)
        {
            int count = 0;
            for (int i = 0; i < numberofsubject; i++)
            {
                count++;
                Console.WriteLine("enter subject name: "+count);
                string subjectname = Console.ReadLine();
                Console.WriteLine("enter subject mark: " + count);
                
                double markofsubject = Convert.ToDouble(Console.ReadLine());
               
                    if (markofsubject <= 100)
                    {
                        marklist[subjectname] = markofsubject;
                    }
            }
            return marklist;
        }

       #endregion

       #region totalscore
       private double totalscore()
        {
            double total=0;
            foreach (KeyValuePair<string, double> i in marklist)
            {
                total += i.Value;
            }
            return total;
        }
       #endregion

       #region grade
       private string grade(double subjectmark)
        {
            string grade = "";

            if (subjectmark >= 90)
            {
                grade = "S";
            }
            else if (subjectmark >= 80)
            {
                grade = "A";
            }
            else if (subjectmark >= 70)
            {
                grade = "B";
            }
            else if (subjectmark >= 60)
            {
                grade = "C";
            }
            else if (subjectmark >= 50)
            {
                grade = "D";
            }
            else if (subjectmark < 50)
            {
                grade = "F";
            }
            else
            {
                throw new NullReferenceException("enter any value");
            }

            return grade;
        }

       #endregion

       #region getstatus
       private string getstatus(string gradeofstud)
        {
            string gradestatus="";

            if (gradeofstud == "F")
            {
                gradestatus = "Fail";
            }
            else if (gradeofstud == "S")
            {
                gradestatus = "Distinction";
            }
            else if (gradeofstud == "A" || gradeofstud == "B")
            {
                gradestatus = "Firstclass";
            }
            else if (gradeofstud == "C" || gradeofstud == "D")
            {
                gradestatus = "SecondClass";
            }
            else
            {
                throw new NullReferenceException("enter any value");
            }
            return gradestatus;

        }

       #endregion

       #region minfunction
       public string findmin()
        {
            return Convert.ToString(marklist.Min());            
        }

       #endregion

       #region maxfunction
       public string findmax()
       {
         return Convert.ToString(marklist.Max());
       }

       #endregion

       #region getstatics
       private void getstatistics()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Total Score: "+ totalscore() +"/"+  marklist.Count*100);
            Console.WriteLine("Highest Score" );
            Console.WriteLine("Lowest Score");
            Console.WriteLine("Average Score"+ totalscore() /marklist.Count);

        }

       #endregion

       #region showstudentdetails
       public void showstudentdetails()
        {
            Console.Write("S.no"+"\t"+"Subject"+"\t"+"\tScore/100"+"\t"+"LetterGrade"+"\t"+"Status");
            int count=1;
            foreach(KeyValuePair<string,double> i in marklist)
            {
                Console.Write(string.Format("\n{0}\t {1}\t \t{2}/100\t \t  \t{3}\t  {4}", count, i.Key, i.Value, grade(i.Value), getstatus((string)grade(i.Value))));
                count++;
            }
           
            getstatistics();
        }

       #endregion


       public  enum gradesystem
         {
           
           

         }
    }
}


