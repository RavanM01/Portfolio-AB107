using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Person
    {
        string _fullname;
        byte _age;
        string _phonenumber;
        public string FullName { get { return _fullname; } set { _fullname = value; } }
        public byte Age { get { return _age; } set { _age = value; } }
        public string PhoneNumber { get { return _phonenumber; } set { _phonenumber = value; } }

        public Person(string FullName, byte Age, string PhoneNumber)
        {

            _fullname = FullName;
            _age = Age;
            _phonenumber = PhoneNumber;
        }

        public bool FullNameCheck()
        {
            
            string[] words = FullName.Split(' ');
            if (words.Length < 2) return false;

            foreach (var part in words)
            {
                if (!char.IsUpper(part[0])) return false;
            }

            return true;
        }

    }
}
