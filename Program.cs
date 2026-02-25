using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool value = false;
            Console.WriteLine("Value of value is: " + value);
            bool isFemale = true;
            Console.WriteLine("Value of isFemale is: " + isFemale);


            double age = 22;
            Console.WriteLine("Value of age is: " + age);
            int age2 = 10;
            Console.WriteLine("Value of age2 is: " + age2);
            //double age3 = age / (double)age2;
            age /= 10;
            Console.WriteLine("Value of age3 is: " + age);

            string name = "Duong";
            name += " Tran";
            Console.WriteLine("Value of name is: " + name);
            
            //name = " Tran";
            //Console.WriteLine("Value of name is: " + name);


        }
    }

    class Person
    {
        string name;
        int age;
        bool sex;

        Person()
        {
            name = "Default";
            age = 0;
            sex = true;
        }
        Person(string name, int age, bool sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
    }
}
