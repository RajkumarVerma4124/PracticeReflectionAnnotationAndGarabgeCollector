using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProgram
{
    public class Employer
    {
        int id;
        string name;
        public Employer(int i, string n)
        {
            id = i;
            name = n;
        }
        [CustomAttribute("Accessor", "Gives value of Employer Id")]
        public int getId()
        {
            return id;
        }
        [CustomAttribute("Accessor", "Gives value of Employer Name")]
        public string getName()
        {
            return name;
        }
    }
}
