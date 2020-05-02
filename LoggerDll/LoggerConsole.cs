using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDll
{
    public class LoggerConsole: MatriceAbs
    {
        public override void Afisare(MesajeAvertizare.Avertizari MesajAv, string MesajEroare)
        {
            int i = (int)MesajAv;
            switch ( i ) {
                case 0: 
                    Console.WriteLine(String.Concat(MesajAv, ": ", MesajEroare));
                    break;
                case 1:
                    Console.WriteLine(String.Concat(MesajAv, ": ", MesajEroare));
                    break;
                case 2:
                    Console.WriteLine(String.Concat(MesajAv, ": ", MesajEroare));
                    break;
            }
        }
    }
}
