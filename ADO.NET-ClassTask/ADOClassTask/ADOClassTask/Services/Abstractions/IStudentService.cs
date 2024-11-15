using ADOClassTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOClassTask.Services.Abstractions
{
    internal interface IStudentService
    {
        void Add(Student student);

        void Delete(int Id);

        List<Student> GetAll();
    }
}
