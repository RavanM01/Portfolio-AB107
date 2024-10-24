using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Student
    {
        private static int _Id = 1;
        private readonly int _id;

        string _FullName;
        double _Point;

        public Student(string fullName, double point)
        {
            _id = _Id;
            _Id++;
            FullName = fullName;
            Point = point;
        }

        public int Id { get { return _id; } }

        public string FullName { get => _FullName; set => _FullName = value; }
        public double Point { get => _Point; set => _Point = value; }

        public void StudentInfo()
        {
            Console.WriteLine($"ID:{Id}\nName: {FullName}\nPoint:{Point}");
        }

    }
}
