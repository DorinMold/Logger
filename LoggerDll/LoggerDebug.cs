using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LoggerDll
{
    public class LoggerDebug: MatriceAbs
    {
        public override void Afisare (MesajeAvertizare.Avertizari MesajAv, string MesajEroare)
        {
            int i = (int)MesajAv;
            switch (i)
            {
                case 0:
                    Debug.WriteLine(String.Concat( MesajAv, ": ", MesajEroare));
                    break;
                case 1:
                    Debug.WriteLine(String.Concat( MesajAv, ": ", MesajEroare));
                    break;
                case 2:
                    Debug.WriteLine(String.Concat( MesajAv, ": ", MesajEroare));
                    break;
            }
        }
    }
}
