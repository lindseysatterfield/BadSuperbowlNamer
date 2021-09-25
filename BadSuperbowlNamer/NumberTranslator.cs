using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperbowlNamer
{
    public class NumberTranslator
    {
        public string Translate(int numberToTranslate)
        {
            if (numberToTranslate == 1)
            {
                return "I";
            }

            return "";
        }
    }
}
