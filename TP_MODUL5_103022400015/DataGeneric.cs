using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL5_103022400015
{
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah {data}");
        }
    }
}
