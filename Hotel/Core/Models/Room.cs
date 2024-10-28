using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Room
    {
        private static int _id;
        public string Name;
        public double Price;
        public int PersonCapacity;
        public bool IsAvailable=true;
        public int Id { get; }

        public Room(string name, double price, bool ısAvailable,int personcapacity)
        {
            Id = ++_id;
            Name = name;
            Price = price;
            IsAvailable = ısAvailable;
            PersonCapacity = personcapacity;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price},Isavailable: {IsAvailable}";
        }
    }
}
