using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectorProgram
{
    /// <summary>
    /// Garbage collector porogram to test diff methods
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                //Allocating an array and make it unreachable.
                int[] values = new int[50000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                //Collecting garbage.
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
            Console.WriteLine();

            long bytes1 = GC.GetTotalMemory(false); // get memory in bytes
            byte[] memory = new byte[1000 * 1000 * 10]; // ten million bytes
            memory[0] = 1; //set memory (prevent allocation from being optimized out)

            long bytes2 = GC.GetTotalMemory(false); // get memory
            long bytes3 = GC.GetTotalMemory(true); //get memory

            //Displaying the bytes
            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1); // write difference
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2); // write difference
            Console.ReadLine();
        }
    }
}
