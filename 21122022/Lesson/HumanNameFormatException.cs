using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class HumanNameFormatException:Exception
    {
        public HumanNameFormatException(string message):base(message)
        {

        }
    }
}
