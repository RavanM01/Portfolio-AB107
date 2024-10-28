using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helpers.Exceptions;
using Core.Models;

namespace Core.Data
{
    public static class AppDBContext
    {
        private static List<Room> Roomlist = new List<Room>();
        private static List<Hotels> Hotellist = new List<Hotels>();

        public static void AddRoom(Room room)
        {
            Roomlist.Add(room);
        }
        public static List<Room> FindAllRoom(double price)
        {
            return Roomlist.FindAll(x => x.PersonCapacity == price);
        }
        public static List<Room> FindAllRoom(int PersonCapacity)
        {
            return Roomlist.FindAll(x=>x.PersonCapacity==PersonCapacity);
        }
        public static List<Room> FindAllRoom(string name)
        {
            return Roomlist.FindAll(x => x.Name == name);
        }
        public static void MakeReservation(int? id ,int personcapacity)
        {
            if (id == null)
            {
                throw new NullReferenceException("id bos ola bilmez.");
            }
            Room foundedroom=Roomlist.Find(x => x.Id == id);
            if (!foundedroom.IsAvailable)
            {
                throw new NotAvailableException("rezerv edile bilmir.");
            }
            if (personcapacity > foundedroom.PersonCapacity)
            {
                throw new NotAvailableException("Musteri sayi coxdur.");
            }

        
            foundedroom.IsAvailable = false;
            Console.WriteLine("Otaq rezerv edildi.");

        }
    }
}
