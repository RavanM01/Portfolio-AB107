namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1=new Student("Ravan",88.3);
            Student student2=new Student("Hikmat",67.4);
            Student student3=new Student("akram",37.9);
            Group group = new Group("AB107",12);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            Console.WriteLine(group.CheckGroupNo("AB107")+"\n");
            student1.StudentInfo();
            group.GetStudent(3);
            group.GetAllStudents();
        }
    }
}
