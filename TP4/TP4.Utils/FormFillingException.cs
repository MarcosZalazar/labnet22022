using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Utils
{
    public class FormFillingException : Exception
    {
        public FormFillingException()
        {

        }

        public FormFillingException(string message) : base(message)
        {

        }
    }
}
