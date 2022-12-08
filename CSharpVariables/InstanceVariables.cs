using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVariables
{
    class InstanceVariables
    {
      //Instance variables declaration if we are not declared instance variable as public then it will not show to call from main mwthod
           public int EngMarks;
           public int MarMarks;
           public int HindiMarks;
        public void StudentMarks()
        {
            Console.WriteLine("EngMarks: {0} and MarMarks: {1} and HindiMarks: {2} ",EngMarks , MarMarks ,HindiMarks);

        }
    }
}
