using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerDll
{
    public static class ApplicationLog
    {
        public static MatriceAbs WriteLog( string Varianta )
        {
            if ( Varianta.Equals("Consola" ) ) {
                return new LoggerConsole(); 
            } else if (Varianta.Equals("Debug"))
            {
                return new LoggerDebug();
            }
            return new LoggerConsole();
        }
    }
}
