using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOClassTask.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Point { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Point:{Point}";
        }
    }
}
