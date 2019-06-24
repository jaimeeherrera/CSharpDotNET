using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRentable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Boat());
            rentables.Add(new House());
            rentables.Add(new Car());

            foreach(IRentable rental in rentals)
            {
                Console.WriteLine($"Rental type: (rental.GetType()");
                Console.WriteLine(rental.GetDesciption());
                Console.WriteLine(rental.GetDailyRate().toString ());
                Console.WriteLine("__________________________________");

            }

        }

    }
}

public interface IRentable
{
    void GetDailyRate();
    void GetDescription():
}

public class Boat: IRentable 
    {
    // internally store an hourly rate
    private decimal _hourlyRate = 12.5m;
    public void GetDailyRate(decimal _hourlyRate)
    {
        return decimal.Round(_hourlyRate * 24, 2);
    }
    //get the description
    public String Description { get; set; }
    public void GetDescription(string description)
    {
        return Description;
    }
         public Boat(string description)
        {
            Description = description;
         }
 
}

    public class Car: IRentable 
    {
    //Interally store the daily rate 
    public decimal _dailyRate;
    public void GetDailyRate(decimal _dailyRate)
    {
        return decimal.Round(_dailyRate, 2 ); 
    }
    public void GetDescription(string description)
    {
        return Description;
    }

    public String Description { get; set; }
    public Car (string description)
    {
    Description = description;
    }
    public String Description { get; set; }
    }

public class House : IRentable
    {
    public decimal _weeklyRate = 1200m; 
    public void GetDailyRate(decimal _dailyRate)
    {
        return decimal.Round(_dailyRate / 7 , 2);
    }
    //get the description

    public String Description { get; set; }
    public void GetDescription(string description)
    {
        return Description;
    }
    public House (string description)
    {
        Description = description;
    }
}


   