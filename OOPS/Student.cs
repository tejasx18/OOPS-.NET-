using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Student
    {
        private int rollno;
        private string name;
        private int mathmarks,englishmarks,sciencemarks,totalmarks;
        private double percentage;

        public Student()
        {
            
        }
        public Student(int rno,string n,int mm,int em,int sm)
        {
            rollno = rno;
            name = n;
            mathmarks = mm;
            englishmarks = em;
            sciencemarks = sm;
        }
        public void Calculate()
        {
            totalmarks = mathmarks+englishmarks +sciencemarks;
            percentage = ((double)totalmarks/300)*100;
        }
        public string Print()
        {
            return $"Rollno ${rollno} Name {name} TotalMarks={totalmarks} Percentage={percentage}%";
        }

    }
}
