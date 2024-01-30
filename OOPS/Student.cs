using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Student
    {

        private int _Id;
        private string FirstName;
        private string LastName;
        private DateTime dateOfBirth;

        //public int Student { get; set; }
        public int StudentId { 
            get
            {
                return this._Id;
            }
        }


        public int StudentAge {
            get
            {
                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - dateOfBirth.Year;

                // Go back to the year in which the person was born in case of a leap year
                if (dateOfBirth.Date > today.AddYears(-age)) age--;
                // using dateOfBirth

                return age;
            }
        }


        public Student()
        {

        }


        //public void SetId(int id)
        //{
        //    if(id < 0)
        //    {
        //        throw new ArgumentException("Id cannot be less than 0");
        //    }
        //    this.Id = id;
        //}

        //public int GetId()
        //{
        //    return this.Id;
        //}

        //public int GetAge()
        //{
          
        //}

        
        //public void SetName(string name)
        //{
        //    this.Name = name;
        //}

        public string GetName()
        {
            return this.FirstName + " " + this.LastName;
        }


        // Variables


        // Properties
        public string StudentName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        //public int StudentAge { get; set; }
    }
}
