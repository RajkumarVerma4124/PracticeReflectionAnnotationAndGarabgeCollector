using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Initializing the author properties
            Author author = new Author();
            author.FirstName = "Raj";
            author.LastName = "verma";
            author.Age = 24;
            author.PhoneNumber = "8848418648";
            author.EmailId = "bevdeyiwg@gmail.com";

            //Calling the test author model method to test all the properties
            TestAuthorModel(author);
            Console.WriteLine();
            //Calling the AttrubuteDisplay method using the classname
            CustomAttribute.AttributeDisplay(typeof(MoodAnalyzer));
            Console.WriteLine();
            CustomAttribute.AttributeDisplay(typeof(Employer));
            Console.WriteLine();
            CustomAttribute.AttributeDisplay(typeof(Employee));
            Console.ReadLine();
        }

        //Method to test the author class properties
        public static void TestAuthorModel(Author author)
        {
            ValidationContext context = new ValidationContext(author, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(author, context, validationResults, true);
            if(!valid)
            {
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}" , validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Satisfied all the validation");
            }
        }
    }
}
