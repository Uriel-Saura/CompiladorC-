using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.EMMA;

namespace Practica1
{

    public class Gramatica
    {

        private Dictionary<string, List<List<string>>> reglas;

        public Gramatica()
        {
            reglas = new Dictionary<string, List<List<string>>>();
        }

        public void AgregarRegla(string simboloNoTerminal, List<List<string>> producciones)
        {
            reglas[simboloNoTerminal] = producciones;
        }

        public NodoDerivacion GenerarArbolDerivaciones(string simboloInicial, string cadena)
        {
            List<string> tokens = TokenizarCadena(cadena);
            return GenerarArbolDerivacionesRecursivo(simboloInicial, tokens);
        }

        private List<string> TokenizarCadena(string cadena)
        {
            // Implementa la lógica para tokenizar la cadena
            // según las reglas de tu gramática y devuelve la lista de tokens
            // Aquí puedes utilizar expresiones regulares u otros métodos de análisis léxico
            // En este ejemplo, se utiliza un método simple para dividir la cadena por espacios

            string[] tokensArray = cadena.Split(' ');
            List<string> tokens = new List<string>(tokensArray);
            return tokens;
        }

        private NodoDerivacion GenerarArbolDerivacionesRecursivo(string simbolo, List<string> entrada)
        {
            NodoDerivacion nodo = new NodoDerivacion(simbolo);

            //recorremos la lista de entrada
           for(int i = 0; i < entrada.Count; i++)
            {
                string aux = entrada[i];
                char a = aux[0];
                // = [[1,2][1,2]];

                if(a.Equals("["))
                {
                    //no hace nada
                }
                else if (Char.IsDigit(a))
                {
                    entrada[i] = "110";
                }else if (entrada[i].Length > 0 && (!entrada[i].Equals("=")) )
                {
                    //agregamos el 120 en la posición de i en la lista
                    entrada[i] = "120";

                } 


            }



            if (entrada.Count > 0)
            {
                List<List<string>> producciones = reglas[simbolo];

                foreach (List<string> produccion in producciones)
                {
                    if (CorrespondeProduccion(produccion, entrada))
                    {
                        foreach (string simboloProduccion in produccion)
                        {
                            if (EsTerminal(simboloProduccion))
                            {
                                nodo.AgregarHijo(new NodoDerivacion(simboloProduccion));
                                entrada.RemoveAt(0);
                            }
                            else
                            {
                                NodoDerivacion nodoHijo = GenerarArbolDerivacionesRecursivo(simboloProduccion, entrada);
                                if (nodoHijo != null)
                                {
                                    nodo.AgregarHijo(nodoHijo);
                                    entrada = nodoHijo.ActualizarEntrada(entrada);
                                }
                                else
                                {
                                    nodo.EliminarUltimoHijo();
                                    break;
                                }
                            }
                        }

                        if (nodo.TieneTodosLosHijos(produccion))
                            return nodo;
                    }
                }
            }

            return null;
        }

        private bool CorrespondeProduccion(List<string> produccion, List<string> entrada)
        {
            if (produccion.Count > entrada.Count)
                return false;

            for (int i = 0; i < produccion.Count; i++)
            {
                if (!EsTerminal(produccion[i]) && !reglas.ContainsKey(produccion[i]))
                    return false;

                if (EsTerminal(produccion[i]) && produccion[i] != entrada[i])
                    return false;
            }

            return true;
        }

        private bool EsTerminal(string simbolo)
        {
            return !reglas.ContainsKey(simbolo);
        }



    }

}
