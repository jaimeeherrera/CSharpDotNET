using System;
using System.Collections.Generic;
using System.Text;

namespace Students2
{
    class Student
    {
        // notice the private set on the id
        public int Id { get; private set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Student(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
