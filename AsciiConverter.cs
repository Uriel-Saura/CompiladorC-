using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class AsciiConverter
    {
        public AsciiConverter() { 
        
        }

        public char ConvertToAscii(int number)
        {
            if (number < 0 || number > 127)
            {
                throw new ArgumentOutOfRangeException("El número debe estar entre 0 y 127.");
            }

            char asciiChar = (char)number;
            return asciiChar;
        }


    }
}
