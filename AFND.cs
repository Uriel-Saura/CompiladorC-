using Practica1.Graficos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Practica1
{
    
    public class ConjIj
    {
        public int j;
        public int Idj;
        public HashSet<Estado> ConjI;
        public int[] TransicionesAFD = new int[256];
        public Boolean aceptacion = false;
        public int token;

        public ConjIj()
        {

            for (int d = 0; d < 256; d++)
            {
                TransicionesAFD[d] = -1;
            }
        }



    }



    public class AFND
    {

        public static HashSet<AFND> ConjDeAFNDs = new HashSet<AFND>();
        Estado EdoIni;
        HashSet<Estado> EdosAFND = new HashSet<Estado>();
        HashSet<Estado> EdosAcept = new HashSet<Estado>();
        HashSet<char> Alfabeto = new HashSet<char>();
        bool SeAgregoAFNUnionLexico;
        public int IdAFND;


        public void imprimirEdosAcept()
        {
            //iteramos la lista de estados de aceptacion
            Console.WriteLine("Id automata: " + IdAFND);
            foreach (Estado e in EdosAcept)
            {
                Console.WriteLine("Tokens de la lista EdosAcept con union especial: " + e.Token);
                Console.WriteLine();
               

            }
            Console.WriteLine();

            foreach (Estado e in EdosAFND)
            {
                Console.WriteLine("Tokens de la lista de edosAFND con union especial: " + e.Token);
                Console.WriteLine();
               
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        public void getInfo()
        {
            //recuperamos todos los valores
            foreach(Estado e in EdosAFND)
            {
                Console.WriteLine($"{e.IdEstado}");
                Console.Write("Transiciones: ");
                e.getTrans();
            }
            Console.WriteLine();
            foreach(Estado e in EdosAcept)
            {
                Console.WriteLine(e.EdoAcept);
                Console.Write("Transiciones: ");
                e.getTrans();
            }
            Console.WriteLine();
            foreach(char c in Alfabeto)
            {
                Console.WriteLine("Alfabeto: " + c);
            }
        }


        public AFND()
        {
            IdAFND = 0;
            EdoIni = null;
            EdosAFND.Clear();
            EdosAcept.Clear();
            Alfabeto.Clear();
            SeAgregoAFNUnionLexico = false;
        }
        
        //geters

        public int getIdAFND()
        {
            return IdAFND;
        }
        public AFND CrearAFNDBasico(char s, int ID)
        {
            Transicion t;
            Estado e1, e2;
            e1 = new Estado();
            e2 = new Estado();
            t = new Transicion(s, e2);
            e1.Trans.Add(t);
            e2.EdoAcept = true;
            _ = Alfabeto.Add(s);
            EdoIni = e1;
            _= EdosAFND.Add(e1);
            _= EdosAFND.Add(e2);
            _= EdosAcept.Add(e2);
            IdAFND = ID;
            SeAgregoAFNUnionLexico=false;
            MessageBox.Show("Se creó el autómata con rango "+s+" ", "Alerta");
            return this;

        }



        public AFND CrearAFNDBasico(char s1, char s2, int ID)
        {

            char i;
            Transicion t;
            Estado e1, e2;
            e1 = new Estado();
            e2 = new Estado();
            t = new Transicion(s1, s2, e2);
            _ = e1.Trans.Add(t);
            e2.EdoAcept = true;
            for (i = s1; i <= s2; i++)
                _ = Alfabeto.Add(i);

            EdoIni = e1;
            _ = EdosAFND.Add(e1);
            _ = EdosAFND.Add(e2);
            _ = EdosAcept.Add(e2);
            IdAFND = ID;
            SeAgregoAFNUnionLexico = false;
            MessageBox.Show("Se creó el autómata con rango"+ s1 + " " +s2+ " ", "Alerta");
            return this;
        
        }


   

        public AFND UnirAFND(AFND f2)
        {
            Estado e1 = new Estado(), e2 = new Estado();
            // e1 tendrá dos transiciones epsilon. Una al edo inicial del primer automata y otra al inicial del segundo automata
            Transicion t1 = new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni );
            Transicion t2 = new Transicion(SimbolosEspeciales.EPSILON, f2.EdoIni );
            _ = e1.Trans.Add(t1);
            _ = e1.Trans.Add(t2);

            //Ahora cada estado de aceptaci´n de this y f2 tenrá una transicion epsilon al nuevo estado de aceptación e2
            //los que eran estados de acpetación de this, ya no serán de aceptación.
            //los que eran estados de aceptación de f2, ya no serán de aceptación

            foreach(Estado e in this.EdosAcept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e2));
                _ = e.EdoAcept = false; 
            }

            foreach(Estado e in f2.EdosAcept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e2));
                _ = e.EdoAcept = false;
            }

            //ahora e2 es el estado de aceptacion
            //Se actualiza la inf del nuevo automata
            this.EdosAcept.Clear();
            f2.EdosAcept.Clear();
            this.EdoIni = e1;
            e2.EdoAcept = true;
            this.EdosAcept.Add(e2);
            this.EdosAFND.UnionWith(f2.EdosAFND);
            this.EdosAFND.Add(e1);
            this.EdosAFND.Add(e2 ); 
            this.Alfabeto.UnionWith(f2.Alfabeto);
           // this.IdAFND = f2.IdAFND;
            MessageBox.Show("Se Unió correctamente", "Alerta");


            return this;
        }


        public AFND  ConcAFND(AFND f2)
        {
            // En la operación de concatenacion se fusionan el estado de aceptacion del this, 
            // Conservamos el estado de acpetación de this
            foreach(Transicion t in f2.EdoIni.Trans)
            {
                foreach(Estado e in this.EdosAcept)
                {
                    e.Trans.Add(t);
                    e.EdoAcept = false;
                }
            }
            f2.EdosAFND.Remove(f2.EdoIni);
            this.EdosAcept = f2.EdosAcept;
            this.EdosAFND.UnionWith(f2.EdosAFND);
            this.Alfabeto.UnionWith(f2.Alfabeto);
            MessageBox.Show("Se concatenó perfectamente", "Alerta");

            return this;
        
        }


        public AFND CerrPos()
        {
            //Se crea un nuevo edo inicial y un nuevo edo de aceptación
            Estado e_ini = new Estado(), e_fin = new Estado();

            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            foreach(Estado e in EdosAcept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
                _ = e.EdoAcept = false;
            }
            EdoIni = e_ini;
            e_fin.EdoAcept = true;
            EdosAcept.Clear();
            EdosAcept.Add(e_fin);
            EdosAFND.Add(e_ini);
            EdosAFND.Add(e_fin);
            MessageBox.Show("Se creó la cerradura positiva", "Alerta");

            return this;

        }

        public AFND CerrKleen()
        {
            //Se crea un nuevo edo inicial y un nuevo edo de aceptacion y uno nuevo edo de aceptación
            Estado e_ini = new Estado(), e_fin = new Estado();

            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
            foreach(Estado e in EdosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
                e.EdoAcept = false;
            }
            EdoIni = e_ini;
            e_fin.EdoAcept = true;
            EdosAcept.Clear();
            EdosAcept.Add(e_fin);
            EdosAFND.Add(e_ini);
            EdosAFND.Add(e_fin);
            MessageBox.Show("Se creó la cerradura de kleene", "Alerta");
            return this;


        }

        public AFND Opcional()
        {
            //Se crea un nuevo edo inicial y un nuevo edo de aceptación
            Estado e_ini = new Estado(), e_fin = new Estado();

            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, EdoIni));
            e_ini.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin));

            foreach(Estado e in EdosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e_fin) );
                e.EdoAcept = false;
            }

            EdoIni = e_ini;
            e_fin.EdoAcept= true;
            EdosAcept.Clear();
            EdosAcept.Add(e_fin);
            EdosAFND.Add(e_ini);
            EdosAFND.Add(e_fin);
            MessageBox.Show("Se creó el opcional", "Alerta");
            return this;
        }


        public HashSet<Estado> CerraduraEpsilon(Estado e)
        {
            HashSet<Estado> R = new HashSet<Estado>();
            Stack<Estado> S = new Stack<Estado>();
            Estado aux, Edo;
            R.Clear();
            S.Clear();


            S.Push(e);
            while(S.Count != 0)
            {
                aux = S.Pop();
                R.Add(aux);
                foreach(Transicion t in aux.Trans)
                {
                    if((Edo = t.GetEdoTrans(SimbolosEspeciales.EPSILON)) != null)
                    {
                        if (!R.Contains(Edo))
                            S.Push(Edo);
                    }
                }
              
            }
           
            return R;
        
        
        }

        public HashSet<Estado> CerraduraEpsilon(HashSet<Estado> ConjEdos)
        {
            HashSet<Estado> R = new HashSet<Estado>();
            Stack<Estado> S = new Stack<Estado>();
            Estado aux, Edo;
            R.Clear();
            S.Clear();

            foreach(Estado e in ConjEdos)
                S.Push(e);

            while (S.Count != 0)
            {
                aux = S.Pop();
                R.Add(aux);
                foreach(Transicion t in aux.Trans)
                {
                    if((Edo = t.GetEdoTrans(SimbolosEspeciales.EPSILON)) != null)
                    {
                        if(!R.Contains(Edo))
                            S.Push(Edo);
                    }
                }

            }
            return R;
        }


        public HashSet<Estado> Mover(Estado edo, char simb)
        {
            HashSet<Estado> C = new HashSet<Estado>();
            Estado aux;
            C.Clear();

            foreach(Transicion t in edo.Trans)
            {
                aux = t.GetEdoTrans(simb);
                if(aux != null)
                    C.Add(aux);
            }
            return C;
        }

        public HashSet<Estado> Mover(HashSet<Estado> Edos, Char simb)
        {
            HashSet<Estado> C = new HashSet<Estado>();
            Estado aux;
            C.Clear();

            foreach(Estado Edo in Edos)
            {
                foreach(Transicion t in Edo.Trans)
                {
                    aux = t.GetEdoTrans(simb);
                    if (aux != null)
                        C.Add(aux);
                }
            }
            return C;
        }


        public HashSet<Estado> Ir_A(HashSet<Estado> Edos, char simb)
        {
            HashSet<Estado> C = new HashSet<Estado>();
            C.Clear();
            C = CerraduraEpsilon(ConjEdos: Mover(Edos, simb));
            return C;
        }

        public void UnionEspecialAFNDs(AFND f, int Token)
        {
            Estado e;
            if (!this.SeAgregoAFNUnionLexico)
            {
                this.EdosAFND.Clear();
                this.EdosAFND.Clear();
                this.Alfabeto.Clear();
                e = new Estado();
                e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, f.EdoIni));
                this.EdoIni = e;
                this.EdosAFND.Add(e);
                this.SeAgregoAFNUnionLexico = true;
            }
            else
              this.EdoIni.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON,f.EdoIni));

            foreach(Estado EdoAcep in f.EdosAcept)
                EdoAcep.Token = Token;

            this.EdosAcept.UnionWith(f.EdosAcept);
            this.EdosAFND.UnionWith(f.EdosAFND);
            this.Alfabeto.UnionWith(f.Alfabeto);
        }

        private int IndiceCaracter(char[] ArregloAlfabeto, char c)
        {
            for(int i = 0; i < ArregloAlfabeto.Length; i++)
                if (ArregloAlfabeto[i] == c) return i;

            return -1;
        }


        public AFD ConvAFNDaAFD()
        {
            int CardAlfabeto, NumEdosAFD, i, j, r;
            char[] ArrAlfabeto;
            ConjIj Ij, Ik;
            bool existe;

            HashSet<Estado> ConjAux = new HashSet<Estado> ();
            HashSet<ConjIj> EdosAFD = new HashSet<ConjIj> ();
            Queue<ConjIj> EdosSinAnalizar = new Queue<ConjIj> ();

            EdosAFD.Clear();
            EdosSinAnalizar.Clear();

            CardAlfabeto = Alfabeto.Count;
            ArrAlfabeto = new char[CardAlfabeto];
            i = 0;
            foreach(char c in Alfabeto)
                ArrAlfabeto[i++] = c;

            j = 0; //Contador para los estados del AFD
            Ij = new ConjIj();

            Ij.ConjI = CerraduraEpsilon(this.EdoIni);
            Ij.Idj = j;
            Ij.TransicionesAFD[0] = j;


            EdosAFD.Add(Ij);
            EdosSinAnalizar.Enqueue(Ij);

            j++;
            while (EdosSinAnalizar.Count != 0)
            {
                Ij = EdosSinAnalizar.Dequeue();

                foreach(char c in Alfabeto)
                {
                    Console.WriteLine(c);

                    Ik = new ConjIj();
                    Ik.ConjI = Ir_A(Ij.ConjI, c);

                    //tienen que estar vacios para dejar de analizar
                    if (Ik.ConjI.Count == 0)
                        continue;

                    existe = false;
                    foreach(ConjIj I in EdosAFD)
                    {
                        if ( I.ConjI.SetEquals(Ik.ConjI) )
                        {
                            
                            existe = true;
                            r = IndiceCaracter(ArrAlfabeto, c);
                            Ij.TransicionesAFD[c] = I.Idj;
                            break;
                        }
                    }
                    if (!existe)
                    {

                        Ik.Idj = j;
                        Ik.TransicionesAFD[0] = j;
                        r = IndiceCaracter(ArrAlfabeto, c);
                        Ij.TransicionesAFD[c] = Ik.Idj;
                        EdosAFD.Add(Ik);
                        EdosSinAnalizar.Enqueue(Ik);
                        j++;
                    }
                }

            }

            NumEdosAFD = j;

            foreach(ConjIj I in EdosAFD)
            {
                ConjAux.Clear();
                ConjAux.UnionWith(I.ConjI);
                ConjAux.IntersectWith(EdosAcept);

                if (ConjAux.Count() != 0)
                {
                    foreach(Estado EdoAcept in ConjAux)
                    {
                        I.TransicionesAFD[255] = EdoAcept.Token;
                        I.aceptacion = true;
                        break;
                    }
                }
                else
                {
                    I.TransicionesAFD[255] = -1;
                }
            }

           
            AFD nuevoAFD = new AFD(NumEdosAFD, EdosAFD);
            return nuevoAFD;



        }



        public void MostrarAFND()
        {
           
            // Crea una cadena de texto para mostrar el autómata en un MessageBox
            string mensaje = "";
            int[] edos = new int[2];
            char[] transiciones = new char[2];
            int i = 0, j=0;

            foreach (Estado e in EdosAFND)
            {
                mensaje += "\n";
                mensaje += "Estado: " + e.IdEstado.ToString() + "\n";
                //salto de linea
                mensaje += "\n";
                foreach (Transicion t in e.Trans)
                {
                    mensaje += "  " + t.SimbInf.ToString() + " -> " + t.SimbSup.ToString() + "\n";
                    transiciones[j] = t.SimbInf;
                    transiciones[j + 1] = t.SimbSup;
                    
                }
                mensaje += "\n";
                
                //insertamos el estado 
                edos[i] = e.IdEstado;
                i++;

            }

            using (GraficoBasico graficarAutomata = new GraficoBasico(edos, transiciones))
            graficarAutomata.ShowDialog();



        }

        //mostrar un automata con union especial
        public void MostrarAFNDEspecial()
        {


        }



    

       


    }
}
