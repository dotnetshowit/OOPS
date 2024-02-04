using AssemblyOne;
using OOPS.Abstraction;
using OOPS.Encapsulation;
using OOPS.Inheritance;
using OOPS.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

            //Child child = new Child();
            //child.ChildProperty = 1;
            //child.ParentProperty = 1;
            //child.Print();

            //Bank bank = new Bank();
            //Console.WriteLine(bank.Balance);

            //bank.Deposit(100);

            //Console.WriteLine(bank.Balance);

            //bank.Withdraw(50);

            //Console.WriteLine(bank.Balance);

            //Parent parent = new Parent();
            //parent.ParentProperty


            Parent obj = new Parent();
            
            //obj.


            Child objChild = new Child();
            
            
            //Parent obj1 = new Child();

            //obj1.Print();

            Fruit fruit = new Fruit();
            //Apple apple = new Apple();

            Fruit apple = new Apple();
            Console.WriteLine(apple.GetName());
            Fruit orange = new Orange();
            Console.WriteLine(orange.GetName());


            //Class1 objClass = new Class1();

            Poly poly = new Poly();
            poly.Add(1, 2);
            poly.Add(1.2f, 2.4f);
            poly.Add("SHOWIT", "DOTNET");



            //Abstraction.Bank bank = new Abstraction.Bank();
            Abstraction.Bank hdfc = new HDFC();
            hdfc.CheckBalance();
            hdfc.Welcome();


            Abstraction.Bank axis = new AXIS();
            axis.CheckBalance();
            axis.Welcome();


            IBank sbi = new SBI();
            sbi.CheckBalance();

            Console.ReadLine();


            Shape circle = new Circle();
            circle.GetArea();

            Shape square = new Square();
            square.GetArea();
        }
    }
}
