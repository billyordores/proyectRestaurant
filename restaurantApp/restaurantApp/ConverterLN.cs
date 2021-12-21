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
            else if (numero == "seis") return 6;
            else if (numero == "siete") return 7;
            else if (numero == "ocho") return 8;
            else if (numero == "nueve") return 9;
            else if (numero == "unocero") return 10;
            else if (numero == "unouno") return 11;
            else if (numero == "unodos") return 12;
            else if (numero == "unotres") return 13;
            else if (numero == "unocuatro") return 14;
            else if (numero == "unocinco") return 15;
            else if (numero == "unoseis") return 16;
            else if (numero == "unosiete") return 17;
            else if (numero == "unoocho") return 18;
            else if (numero == "unonueve") return 19;
            else if (numero == "doscero") return 20;
            else if (numero == "dosuno") return 21;
            else if (numero == "dosdos") return 22;
            else if (numero == "dostres") return 23;
            else if (numero == "doscuatro") return 24;
            else if (numero == "doscinco") return 25;
            else if (numero == "dosseis") return 26;
            else if (numero == "dossiete") return 27;
            else if (numero == "dosocho") return 28;
            else if (numero == "dosnueve") return 29;
            else if (numero == "trescero") return 30;
            else return 0;
        }


    }
}
