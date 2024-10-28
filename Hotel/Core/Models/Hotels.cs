using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Hotels
    {
        private static int _id;
        public string Name;
        public int Id { get; }

        public Hotels(string name)
        {
            Id = ++_id;
            Name = name;
        }


    }
}
