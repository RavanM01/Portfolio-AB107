using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Group
    {
        string _GroupNo;
        int _StudentLimit;
        private Student[] Students = new Student[0];
        string pattern = @"^[A-Z]{2}\d{3}$";

        public Group(string groupNo, int studentLimit)
        {
            if (Regex.IsMatch(groupNo, pattern))
            {
            _GroupNo = groupNo;
                
            }
            else
            {
                Console.WriteLine("Duzgun daxil edin");
            }
            StudentLimit = studentLimit;
        }



        public int StudentLimit { get => _StudentLimit; set { if (value >= 5 && value <= 18) { _StudentLimit = value; } else { Console.WriteLine("duzgun say daxil edin"); } } }

        public bool CheckGroupNo(string groupNo)
        {
            if (Regex.IsMatch(groupNo, pattern))
            {
                return true;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length+1);
                Students[^1]= student;
                Console.WriteLine("elave edildi");
            }
        }
        public void GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (id == Students[i].Id)
                {
                    Console.WriteLine($"\n{Students[i].Id}  {Students[i].Point}  {Students[i].FullName}\n");
                }

            }
        }
        public void GetAllStudents()
        {
            for(int i = 0;i < Students.Length; i++)
            {
                Console.WriteLine($"\nID:{Students[i].Id}  Point:{Students[i].Point}  Name:{Students[i].FullName}\n");
            }
        }

    }
}   
