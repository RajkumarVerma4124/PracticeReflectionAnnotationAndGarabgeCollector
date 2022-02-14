using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MoodAnalyzerProgram.Reflection;

namespace MoodAnalyzerProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FetchCustomerTypeInfo();
            Console.ReadLine();
        }

        //Method to fetch the details of a particular class
        public static void FetchCustomerTypeInfo()
        {
            //Fetching the path where the programs are stored
            string path = @"E:\CODING\Coding\React Web Apps\coreAPI\Fellowship\DataStructuresAndAlgorithm\DataStructuresAndAlgorithm\bin\Debug\DataStructuresAndAlgorithm.exe";
            Assembly assembly = Assembly.LoadFrom(path);
            Console.WriteLine("Full Name Of A Assembly "+assembly.GetName().Name);
            
            //Type is class where i am creating object to call inbult function gettype
            Type[] types = assembly.GetTypes();
            Console.WriteLine("ClassNames");
            foreach (Type typeOne in types)
            {
                Console.WriteLine(typeOne.Name);
            }

            //Getting the constructors info from the given class 
            Type type = Type.GetType("MoodAnalyzerProgram.Reflection.Customer");
            Console.WriteLine("Full Name Of A Class "+type.FullName);
            Console.WriteLine("Name Of A The Class " + type.Name);
           
            ConstructorInfo[] constructorInfos = type.GetConstructors();
            Console.WriteLine();
            Console.WriteLine("Customer constructor");
            foreach (ConstructorInfo constructorInfo in constructorInfos)
            {
                Console.WriteLine(constructorInfo.ToString());
            }

            //Getting the properties info from the given class 
            PropertyInfo[] propertyInfos = type.GetProperties();
            Console.WriteLine();
            Console.WriteLine("Customer properties");
            foreach (PropertyInfo properties in propertyInfos)
            {
                Console.WriteLine(properties.Name+" "+properties.PropertyType);
            }

            //Getting the methods info from the given class 
            MethodInfo[] methodInfos = type.GetMethods();
            Console.WriteLine();
            Console.WriteLine("Customer methods");
            foreach (MethodInfo method in methodInfos)
            {
                Console.WriteLine(method.Name+" "+method.ReturnType.Name);
            }
        }
    }
}
