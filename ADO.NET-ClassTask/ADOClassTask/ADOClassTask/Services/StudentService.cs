using ADOClassTask.Context;
using ADOClassTask.Models;
using ADOClassTask.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOClassTask.Services
{
    internal class StudentService : IStudentService
    {
        AppDBContext context;
        public StudentService()
        {
            context = new AppDBContext();
        }
        public void Add(Student student)
        {
            string command = $"insert into Students values('{student.Name}','{student.Point}')";
            int result = context.NonQueryExecute(command);
            if (result > 0)
            {
                Console.WriteLine("Elave olundu");
            }
            else
            {
                Console.WriteLine("basaramadik abi");
            }
        }

        public void Delete(int Id)
        {
            string deleteQuery = $"delete from Students where Id={Id}";
            int result = context.NonQueryExecute(deleteQuery);
            if (result>0)
            {
                Console.WriteLine("Data Silindi");

            }
            else
            {
                Console.WriteLine("Bele Data yoxdur");
            }
        }

        public List<Student> GetAll()
        {
            List<Student> lists = new List<Student>();
            string query = "select * from Students";
            foreach(DataRow item in context.QueryExecute(query).Rows)
            {
                Student student = new Student()
                {
                    Id = (int)item["Id"],
                    Name = item["Name"].ToString(),
                    Point = double.Parse(item["Point"].ToString())
                };
                lists.Add(student);
            }
            return lists;
        }

        public void Update(int Id)
        {
            Console.WriteLine("Name daxil edin");
            string stName = Console.ReadLine();
            Console.WriteLine("Point daxil edin");
            string stPoint = Console.ReadLine();
            string query = $"Update Students Set Name='{stName}',Point='{stPoint}' where Id={Id}";
            int result = context.NonQueryExecute(query);
            if (result > 0)
            {
                Console.WriteLine("Data deyisdi");
            }
            else
            {
                Console.WriteLine("Olmadi");
            }
        }

    }
}
