using ProyectoLenguajes.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguajes
{
    class ExpressionTree
    {
        Dictionary<string, int> Precedencias = new Dictionary<string, int>();
        string Recorrido = "";
        string operador, oper;
        public string FirstStep(string RE)
        {
            char[] tokens = RE.ToCharArray();            
            Precedencias.Add("*", 3);
            Precedencias.Add("+", 3);
            Precedencias.Add("?", 3);
            Precedencias.Add(".", 2);
            Precedencias.Add("|", 1);
            Stack<string> T = new Stack<string>();
            Stack<Nodo<string>> S = new Stack<Nodo<string>>();

            for (int i = 0; i < tokens.Count(); i++)
            {
                if (tokens[i].Equals('('))
                {
                    T.Push(tokens[i].ToString());
                }
                else if (tokens[i].Equals(')'))
                {
                    while (T.Peek().CompareTo("(") != 0)
                    {
                        if (T.Count() > 0 && S.Count >= 2)
                        {
                            Nodo<string> temp = new Nodo<string>();
                            temp.Valor = T.Pop();
                            temp.Derecha = S.Pop();
                            temp.Izquierda = S.Pop();
                            S.Push(temp);
                        }
                    }
                    T.Pop();
                    if (i < tokens.Count() - 2 && !Precedencias.ContainsKey(tokens[i + 1].ToString()) && tokens[i + 1] !=')')//Concatenar si el siguiente no es operacion o cerradura
                    {
                        T.Push(".");
                    }
                }
                else if (tokens[i].Equals('['))
                {
                    T.Push(tokens[i].ToString());
                    string tokenST = "";
                    i++;
                    while (tokens[i].CompareTo(']') != 0)
                    {
                        if (tokens[i].Equals('|'))
                        {
                            Nodo<string> NodoAux = new Nodo<string>();
                            NodoAux.Valor = tokenST;
                            tokenST = "";
                            S.Push(NodoAux);
                        }
                        tokenST += tokens[i].ToString();
                        if (tokenST.Equals("|"))
                        {
                            if (T.Count() > 0 && T.Peek().CompareTo("[") != 0 && Precedencias[tokenST] < Precedencias[T.Peek()])
                            {
                                string aux = T.Pop();
                                Nodo<string> nodo = new Nodo<string>();
                                nodo.Valor = aux;
                                nodo.Derecha = S.Pop();
                                nodo.Izquierda = S.Pop();
                                S.Push(nodo);
                                tokenST = "";
                            }
                            else
                            {
                                T.Push(tokenST);
                                tokenST = "";
                            }
                        }
                        i++;
                    }
                    if (tokenST.CompareTo("") != 0 && tokenST.CompareTo("]") != 0 && tokenST.CompareTo("|") != 0)//Concatenar
                    {
                        Nodo<string> NodoAux = new Nodo<string>();
                        NodoAux.Valor = tokenST;
                        tokenST = "";
                        S.Push(NodoAux);
                    }
                    while (T.Peek().CompareTo("[") != 0)
                    {
                        if (T.Count() > 0 && S.Count >= 2)
                        {
                            Nodo<string> temp = new Nodo<string>();
                            temp.Valor = T.Pop();
                            temp.Derecha = S.Pop();
                            temp.Izquierda = S.Pop();
                            S.Push(temp);
                        }
                    }
                    T.Pop();
                    if (i < tokens.Count() - 2 && (tokens[i + 1].Equals('[')|| tokens[i + 1].Equals('(')))//Concatenar
                    {
                        T.Push(".");
                    }
                

                } 
                else if (tokens[i].Equals('+') | tokens[i].Equals('*') | tokens[i].Equals('?'))
                {
                    Nodo<string> aux = new Nodo<string>();
                    aux.Valor = tokens[i].ToString();
                    if (S.Count < 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Nodo<string> popped = S.Pop();
                        aux.Izquierda = popped;
                        S.Push(aux);
                    }
                    if (i < tokens.Count() - 2 && (tokens[i + 1].CompareTo('|')!=0 && tokens[i + 1].CompareTo(')') != 0&& tokens[i + 1].CompareTo(']') != 0))//Concatenar el siguiente token si no es fin de parentesis o corchete o un simbolo
                    {
                        T.Push(".");
                    }
                }
                else if (T.Count() > 0 && T.Peek().CompareTo("(")  != 0 && T.Peek().CompareTo("[")!=0 && Precedencias.ContainsKey(tokens[i].ToString()))
                {
                    if(Precedencias[tokens[i].ToString()] < Precedencias[T.Peek()])
                    {                        
                        string aux = T.Pop();
                        Nodo<string> nodo = new Nodo<string>();
                        nodo.Valor = aux;
                        nodo.Derecha = S.Pop();
                        nodo.Izquierda = S.Pop();
                        S.Push(nodo);
                        T.Push(tokens[i].ToString());
                    }

                }
                else if (tokens[i].Equals('|'))
                {
                    T.Push(tokens[i].ToString());
                }
                else if (tokens[i].Equals(' '))
                {
                    if (i < tokens.Count() - 2 && tokens[i + 1].CompareTo('\'') != 0 && tokens[i - 1].CompareTo('\'') != 0)
                    {
                        if (i < tokens.Count() - 2 && Char.IsLetter(tokens[i-1]) && Char.IsLetter(tokens[i + 1]))// Ver si el espacio entre 2 variables o letras es igual a una concatenacion
                        {
                            T.Push(".");
                        }
                        else if (i < tokens.Count() - 2 && Precedencias.ContainsKey(tokens[i + 1].ToString()))
                        {
                            // no se hace nada por que ya esta la logica hecha en el arbol
                        }
                        else if (i < tokens.Count() - 2 && Char.IsLetter(tokens[i - 1]) && tokens[i + 1].Equals('('))
                        {
                            T.Push(".");
                        }                        
                    }
                    else if (true)
                    {

                    }
                    
                    

                        
                    
                }
                else
                {
                    if (tokens[i]!='#')
                    {
                        string aux1 = "";
                        if (tokens[i+1] == '?' || tokens[i+1] == '*' || tokens[i+1] == '+' || tokens[i+1] == '|' || tokens[i+1] == ']' || tokens[i+1] == '[' || tokens[i+1] == '(' || tokens[i + 1] == ')')
                        {
                            aux1 += tokens[i];
                        }
                        else
                        {
                            while (tokens[i].CompareTo('?') != 0 && tokens[i].CompareTo('*') != 0 && tokens[i].CompareTo('+') != 0 && tokens[i].CompareTo('|') != 0 && tokens[i].CompareTo(']') != 0 && tokens[i].CompareTo('[') != 0 && tokens[i].CompareTo('(') != 0 && tokens[i].CompareTo(')') != 0 && tokens[i].CompareTo(' ') != 0)//Para tomar tokens completos sin necesidad de validaciones innecesarias
                            {
                                aux1 += tokens[i];
                                i++;
                            }
                            i--;
                        }

                        if (i < tokens.Count() - 2 && !Precedencias.ContainsKey(tokens[i + 1].ToString()) && tokens[i+1].CompareTo(')') != 0 && tokens[i + 1].CompareTo(' ') != 0)
                        {
                            T.Push(".");
                        }
                        Nodo<string> aux = new Nodo<string>();
                        aux.Valor = aux1;
                        S.Push(aux);
                    }
                    else
                    {
                        T.Push(".");
                        Nodo<string> aux = new Nodo<string>();
                        aux.Valor = "#";
                        S.Push(aux);
                    }

                }
            }

            while (T.Count()>0)//Ultimo While
            {
                if (S.Count()>=2)
                {
                    Nodo<string> temp = new Nodo<string>();
                    temp.Valor = T.Pop();
                    temp.Derecha = S.Pop();
                    temp.Izquierda = S.Pop();
                    S.Push(temp);
                }
            }
            //Recorrer Arbol
            RecorridoInorder(S.Pop());
            return Recorrido;
        }

        public void  RecorridoInorder(Nodo<string> nodo)
        {
            if (nodo.Izquierda != null)
            {
                RecorridoInorder(nodo.Izquierda);
                
            }
            Recorrido += nodo.Valor;
            if (nodo.Derecha != null)
            {
                RecorridoInorder(nodo.Derecha);
            }
            
        }

    }
}
