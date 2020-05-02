using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDll
{
    class LoggerTxt : MatriceAbs
    {
        public override void Afisare(MesajeAvertizare.Avertizari MesajAv, string MesajEroare)
        {
            int i = (int)MesajAv;
            switch (i)
            {
                case 0:
                    System.IO.File.AppendAllText(@"C:\Users\dorin\source\repos\LoggerErrors.txt", String.Concat(MesajAv, ": ", MesajEroare, "  "));
                    break;
                case 1:
                    System.IO.File.AppendAllText(@"C:\Users\dorin\source\repos\LoggerErrors.txt", String.Concat(MesajAv, ": ", MesajEroare, "  "));
                    break;
                case 2:
                    System.IO.File.AppendAllText(@"C:\Users\dorin\source\repos\LoggerErrors.txt", String.Concat(MesajAv, ": ", MesajEroare, "  "));
                    break;
            }
        }
    }
}
