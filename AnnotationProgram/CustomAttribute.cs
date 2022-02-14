using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AnnotationProgram
{
    /// <summary>
    /// Defining a custom class attribute
    /// </summary>
    public class CustomAttribute:Attribute
    {
        //Private Properties

        private string Title { get; set; }
        private string Description { get; set; }

        //Parameterized constructor
        public CustomAttribute(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
        }

        //Method to show the feild attributes of the custom attribute using reflection
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Method Of Class {0}", classType.Name);

            //Array to store all methods of given class
            MethodInfo[] methods = classType.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.Write(method.Name+" , ");
            }
            Console.WriteLine();

            //Looping through to read all the methods
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                //Creating object array to receive method attrbute returned by the get cutom attributes method
                object[] attributesArray = methods[i].GetCustomAttributes(true);

                //foreach loop to read through all the attribues of the method
                foreach (Attribute attribute in attributesArray)
                {
                    if(attribute is CustomAttribute)
                    {
                        //Displaying the fields of the custom attribute
                        CustomAttribute attributObject = (CustomAttribute)attribute;
                        if(attributObject != null)
                        {
                            Console.WriteLine("Applying custom attributes on methods");
                            Console.WriteLine("{0} - {1}, {2}", methods[i].Name, attributObject.Title, attributObject.Description);
                        }
                    }
                }
            }
        }
    }
}
