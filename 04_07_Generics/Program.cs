using System;

namespace _04_07_Generics
{

    class Program
    {

        delegate object Del(object parametr);

        static object DelegateCreate(object parametr)
        {
            return parametr;
        }

        static void Main()
        {
            Del ptr;
            ptr = DelegateCreate;
            DelegateCreate(ptr);

        }
    }
}
