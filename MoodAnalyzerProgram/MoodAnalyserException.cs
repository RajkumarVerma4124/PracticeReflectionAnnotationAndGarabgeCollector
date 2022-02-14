using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyserException : Exception
    {
        public ExceptionTypes type;
        public enum ExceptionTypes
        {
            NULL_MOOD_EXCEPTION,
            EMPTY_MOOD_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND,
            METHOD_NOT_FOUND,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD
        }

        public MoodAnalyserException(ExceptionTypes type, string message):base(message)
        {
            this.type = type;
        }
    }
}
