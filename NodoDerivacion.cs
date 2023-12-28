using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class NodoDerivacion
    {
        public string Simbolo { get; }
        public List<NodoDerivacion> Hijos { get; }

        public NodoDerivacion(string simbolo)
        {
            Simbolo = simbolo;
            Hijos = new List<NodoDerivacion>();
        }

        public void AgregarHijo(NodoDerivacion hijo)
        {
            Hijos.Add(hijo);
        }

        public void EliminarUltimoHijo()
        {
            if (Hijos.Count > 0)
                Hijos.RemoveAt(Hijos.Count - 1);
        }

        public bool TieneTodosLosHijos(List<string> produccion)
        {
            if (Hijos.Count != produccion.Count)
                return false;

            for (int i = 0; i < produccion.Count; i++)
            {
                if (Hijos[i].Simbolo != produccion[i])
                    return false;
            }

            return true;
        }

        public List<string> ActualizarEntrada(List<string> entrada)
        {
            List<string> nuevaEntrada = new List<string>(entrada);
            for (int i = 0; i < Hijos.Count; i++)
            {
                nuevaEntrada.RemoveAt(0);
            }
            return nuevaEntrada;
        }

        public void Mostrar(int nivel = 0)
        {
            string indentacion = new string(' ', nivel * 4);
            Console.WriteLine(indentacion + Simbolo);
            foreach (NodoDerivacion hijo in Hijos)
            {
                hijo.Mostrar(nivel + 1);
            }
        }

    }
}
