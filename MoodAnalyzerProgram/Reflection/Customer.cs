using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram.Reflection
{
    /// <summary>
    /// Customer class to declare method, properties and contructors
    /// </summary>
    public class Customer
    {
        //Properties
        public int Id { get; set; }

        public string Name { get; set; }

        //Parameterized constructor
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //Default constructor
        public Customer()
        {
            this.Id = 20;
            this.Name = string.Empty;
        }

        //Method to print id
        public void PrintId()
        {
            this.Id = 25;
            Console.WriteLine("Id is : {0}",this.Id);
        }

        //Method to print name
        public void PrintName()
        {
            this.Name = "Raj";
            Console.WriteLine("Name is : {0}", this.Name);
        }
    }
}
