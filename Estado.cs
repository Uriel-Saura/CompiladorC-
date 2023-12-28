using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Estado
    {
        static int ContadorIdEstado = 0;
        private int idEstado1, Token1;
        private bool EdoAcept1;
        private HashSet<Transicion> Trans1 = new HashSet<Transicion>();

        //constructor
        public Estado()
        {
            EdoAcept = false;
            Token = -1;

            IdEstado = ContadorIdEstado++;
            Trans1.Clear();
        }

        public void getTrans()
        {
            foreach(Transicion trans in Trans1)
            {
                Console.WriteLine("Inf: "+ trans.getInf() +" Sup: "+trans.getSup());
            }
        }

        public int IdEstado { get => idEstado1; set => idEstado1 = value; }
        public bool EdoAcept { get => EdoAcept1; set => EdoAcept1 = value;}
        public int Token { get => Token1; set => Token1 = value;}
        public HashSet<Transicion> Trans { get => Trans1; set => Trans1 = value;}




    }
}
