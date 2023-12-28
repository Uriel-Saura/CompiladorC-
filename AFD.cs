using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class AFD
    {
        public static HashSet<AFD> ConjDeAFDs = new HashSet<AFD>();
        public int[][] TransicionesAFD;
        public int idAFD;
        public int row1;
        public int column1;

        public AFD(int carEdosIj, HashSet<ConjIj> EdosAFD)
        {
            TransicionesAFD = new int[carEdosIj][];
            row1 = carEdosIj;
            column1 = 256;
            for (int i = 0; i < carEdosIj; i++)
            {
                foreach(ConjIj cIJ in EdosAFD)
                {
                    if (cIJ.Idj == i)
                    {
                        TransicionesAFD[i] = cIJ.TransicionesAFD;
                    }
                }
            }
        }

        public AFD(int[][]transicionesAFD, int idAFD)
        {
            TransicionesAFD = transicionesAFD;
            this.idAFD = idAFD;
        }

        public AFD()
        {
            idAFD = 0;
            row1 = 0;

        }
        public void getInf()
        {
            //imprimimos el tamaño de la matriz
            Console.WriteLine("Tamaño de la matriz: " + TransicionesAFD.Length);
            //imprimimos cuantas filas tiene
            Console.WriteLine("Filas: " + row1);
            //imprimimos cuantas columnas tiene
            Console.WriteLine("Columnas: " + column1);

            Console.WriteLine("Matriz de transiciones del AFD: \n");
            for (int j = 0; j < row1; j++)
            {
                for (int k = 0; k < column1; k++)
                {
                    Console.WriteLine(TransicionesAFD[j][k]); //ERROR
                }
                Console.WriteLine("\n");
            }
        }

        internal void LeerAFDdeArchivo(string fileAFD, int v)
        {
            throw new NotImplementedException();
        }
    }


}
