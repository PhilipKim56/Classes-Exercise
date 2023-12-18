using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cars
    {
        public Cars() 
        { 
        
        }


        public string Make {  get; set; }
        public string Model { get; set; } 
        public int Year { get; set; }

        public void Print()
        {
            Console.WriteLine($"The car you are looking at is a {Year}, {Make}, {Model}");  
        }
    }
}
