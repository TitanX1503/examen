using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Matrix matrix = new Matrix
            (
                new int [4, 3]{
                    {V, Pa, Pl, V},
                    {C, M, Pl, B},
                    {C, A, A, Pb}
                },
                3
            );
        }
    }
}
