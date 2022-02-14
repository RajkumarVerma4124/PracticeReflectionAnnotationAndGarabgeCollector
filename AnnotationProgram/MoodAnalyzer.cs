using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnnotationProgram;

namespace AnnotationProgram
{
    /// <summary>
    /// Creating Mood Analyser
    /// </summary>
    public class MoodAnalyzer
    {
        public string message;
        
        //Default constructor(UC4)
        public MoodAnalyzer()
        {
            Console.WriteLine("Default constructor");
        }
        //Parameterized constructor
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        [CustomAttribute("AnalyserMood", "Identifying the mood based on input message")]
        public string AnalyserMood()
        {
            try 
            {
                if (this.message.ToLower().Contains("sad"))
                    return "sad";
                else if (this.message.Equals(string.Empty))
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
                else
                    return "happy";
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
                //throw new NullReferenceException();
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionTypes.NULL_MOOD_EXCEPTION,"Message should not be null");
            }
           
        }
    }
}
