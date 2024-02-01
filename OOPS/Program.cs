using OOPS.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            //student.StudentName;

            //student.StudentId = 1;

            var studentID = student.StudentAge;


            //student.Id = 0;
            //student.SetId(-1);
            //student.SetName("ShowIT");
            //student.age = -100;

            //Console.WriteLine(student.GetId());
            //Console.WriteLine(student.GetName());
            //Console.WriteLine(student.GetAge());

            

            //Console.ReadLine();


            // form values
            var DTO = new SignUpDTO();

            // Domain object
            var studentToAdd = new Student();

            //studentToAdd.age = DTO.Age;
            //studentToAdd.Name = DTO.Name;

            //context.saveChanges(studentToAdd);


            // MultiLevel Inheritance

            Child child = new Child();
            child.ChildProperty = 1;
            child.ParentProperty = 1;
            child.Print();



            //Parent parent = new Parent();
            //parent.ParentProperty

            Console.ReadLine();

        }
    }
}
