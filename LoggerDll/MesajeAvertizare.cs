namespace LoggerDll
{
    public class MesajeAvertizare
    {
        public enum Avertizari
        {
            Avertizare = 0,
            Sever = 1,
            Critic = 2
        }
            public static string MesajAvertizare = "Acesta este un mesaj de avertizare moderata";
            public static string MesajSever = "Acesta este un mesaj de avertizare ridicata";
            public static string MesajCritic = "Acesta este un mesaj de avertizare critica";
    }
}
