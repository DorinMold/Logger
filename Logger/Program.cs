using System;
using LoggerDll;

namespace Logger
{
    class Program
    {
        static int Var1 = 3;
        static int Var2 = 0;
        static int Var3 = 5;
        static int Rezultat;
        static MatriceAbs LoggerConsole = ApplicationLog.WriteLog("Console");
        static MatriceAbs LoggerDebug = ApplicationLog.WriteLog("Debug");
        static MatriceAbs LoggerTxt = ApplicationLog.WriteLog("Text");
        static void Main(string[] args)
        {
            // Cazul primei erori de impartire la zero
            try
            {
                Rezultat = Var1 / Var2;
            }
            catch (Exception e)
            {
                Console.WriteLine($"---------Eroare Impartire {Var1} la {Var2}--------------------");
                LoggerConsole.Afisare(MesajeAvertizare.Avertizari.Avertizare , e.Message);
                LoggerDebug.Afisare(MesajeAvertizare.Avertizari.Avertizare, e.Message);
                LoggerTxt.Afisare(MesajeAvertizare.Avertizari.Avertizare, e.Message);
            }

            //cazul altei erori de impartire la zero
            try
            {
                Rezultat = Var3 / Var2;
            }
            catch (Exception e)
            {
                Console.WriteLine($"---------Eroare Impartire {Var3} la {Var2}--------------------");
                LoggerConsole.Afisare(MesajeAvertizare.Avertizari.Sever, e.Message);
                LoggerDebug.Afisare(MesajeAvertizare.Avertizari.Sever, e.Message);
                LoggerTxt.Afisare(MesajeAvertizare.Avertizari.Sever, e.Message);
            }

            //cazul ultimei erori de impartire la zero
            try
            {
                Rezultat = int.Parse("eroare");
            }
            catch (Exception e)
            {
                Console.WriteLine($"---------Eroare Impartire {Var3} la {Var2}--------------------");
                LoggerConsole.Afisare(MesajeAvertizare.Avertizari.Critic, e.Message);
                LoggerDebug.Afisare(MesajeAvertizare.Avertizari.Critic, e.Message);
                LoggerTxt.Afisare(MesajeAvertizare.Avertizari.Critic, e.Message);
            }
        }
    }
}
