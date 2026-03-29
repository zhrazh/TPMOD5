using System;

namespace TP_MODUL5_103022400015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric h = new HaloGeneric();
            h.SapaUser("Azzhara Putri");

            DataGeneric<string> data = new DataGeneric<string>("103022400015");
            data.PrintData();
        }
    }
}
