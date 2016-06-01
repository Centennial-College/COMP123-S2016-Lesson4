using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson4
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person tanya = new Person();
            tanya.Name = "Tanya";
            tanya.Age = 28;
            tanya.SaysHello();
            tanya.ShowAge();

            Console.WriteLine();

            Person kevin = new Person("Kevin");
            kevin.Age = 23;
            kevin.SaysHello();
            kevin.ShowAge();

            Console.WriteLine();

            Person mark = new Person(30);
            mark.Name = "Mark";
            mark.SaysHello();
            mark.ShowAge();

            Console.WriteLine();

            Person mary = new Person("Mary", 23);
            mary.SaysHello();
            mary.ShowAge();
        }
    }
}
