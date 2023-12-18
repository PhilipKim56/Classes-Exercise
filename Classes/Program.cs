using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cars myCar = new Cars();
            myCar.Make = "Honda";
            myCar.Make = "Civic";
            myCar.Year = 2019;

            myCar.Print();

        }
       
    }
}
