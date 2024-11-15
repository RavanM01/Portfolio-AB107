using ADOClassTask.Models;
using ADOClassTask.Services;

namespace ADOClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            /*
            Student student = new Student()
            {
                Name= "Test3",
                Point=68
            };
            studentService.Add(student);
            
            foreach(var item in studentService.GetAll())
            {
                Console.WriteLine(item);
            }
            
           studentService.Delete(2);
            */
   

            studentService.Update(1);
        }
    }
}
