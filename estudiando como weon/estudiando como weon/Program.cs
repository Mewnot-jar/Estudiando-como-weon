using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudiando_como_weon
{
    class Program
    {
        public int numeroMayor(ArrayList lista)
        {
            int numMayor = 0;
            int indice = 0;
            for (int i = 0; i < lista.Capacity; i++)
            {
                if (Convert.ToInt32(lista[i]) > numMayor)
                {
                    numMayor = Convert.ToInt32(lista[i]);
                    indice = i;
                }
            }
            return indice;
        }
        static void Main(string[] args)
        {
            int numMayor = 0;
            Program p = new Program();
            ArrayList numeros = new ArrayList(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[{0}] = {1}", i, numeros[i]);
            }

            Console.WriteLine("El indice del numero mayor es = {0}", p.numeroMayor(numeros));

            Console.ReadKey();
        }
    }
}
