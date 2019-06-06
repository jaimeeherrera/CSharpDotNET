using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        public static void Main(string[] args)
        //this is where the objects are called
        {
            DriverLicense Jaimee = new DriverLicense("Jaimee", "Herrera", "F", 012345, 10 );
        }
         class DriverLicense
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string Gender { get; set; }
            public int LicenseNum { get; set; }
            public int Age { get; set; }

            public  DriverLicense (string First, string Last, string Gender, int LicenseNum, int Age)
                {
                this.First = First;
                this.Last = Last;
                this.Gender = Gender;
                this.LicenseNum = LicenseNum;
                this.Age = Age;
                }
            public string fullName()
            {
                return (First + Last); 
            }

        }


        class Book
        {
            public string Title { get; set; }
            // adding to the list for multiple authors 
            public List<string> Authors { get; set; }
            public int Pages { get; set; }
            public int SKU { get; set; }
            public string Publisher { get; set; }
            public float Price { get; set; }


            public Book(string Title, string Authors, int Pages, int SKU, string Publish, float Price)


        }
        class Airplane
        {
            public string Manufauter { get; set; }
            public string Model { get; set; }
            public string Variant { get; set; }
            public int Capacity { get; set; }
            public int NumOfEngines { get; set; }

            public Airplane ()
            {

            }
        }
    }
  
