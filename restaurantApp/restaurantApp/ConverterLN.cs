using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantApp
{
    public class ConverterLN
    {
        public static int stringToInt(String numero) {
            if (numero == "uno") return 1;
            else if (numero == "dos") return 2;
            else if (numero == "tres") return 3;
            else if (numero == "cuatro") return 4;
            else if (numero == "cinco") return 5;
            else return 6;
        }


    }
}
