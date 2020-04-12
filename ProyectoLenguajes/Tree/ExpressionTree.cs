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
        int posicionAux = 1;
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
                    if (i < tokens.Count() - 2 && !Precedencias.ContainsKey(tokens[i + 1].ToString()) && tokens[i + 1] != ')')//Concatenar si el siguiente no es operacion o cerradura
                    {
                        tokens[i] = '.';
                        i--;
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
                    if (i < tokens.Count() - 2 && (tokens[i + 1].Equals('[') || tokens[i + 1].Equals('(')))//Concatenar
                    {
                        tokens[i] = '.';
                        i--;
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
                    if (i < tokens.Count() - 2 && (tokens[i + 1].CompareTo('|') != 0 && tokens[i + 1].CompareTo(')') != 0 && tokens[i + 1].CompareTo(']') != 0))//Concatenar el siguiente token si no es fin de parentesis o corchete o un simbolo
                    {
                        tokens[i] = '.';
                        i--;
                    }
                }
                else if (T.Count() > 0 && T.Peek().CompareTo("(") != 0 && T.Peek().CompareTo("[") != 0 && Precedencias.ContainsKey(tokens[i].ToString()) && (Precedencias[tokens[i].ToString()] <= Precedencias[T.Peek()]))
                {
                    if (S.Count>=2)
                    {
                        string aux = T.Pop();
                        Nodo<string> nodo = new Nodo<string>();
                        nodo.Valor = aux;
                        nodo.Derecha = S.Pop();
                        nodo.Izquierda = S.Pop();
                        S.Push(nodo);
                        T.Push(tokens[i].ToString());
                    }
                    else
                    {
                        T.Push(tokens[i].ToString());
                    }

                }
                else if (Precedencias.ContainsKey(tokens[i].ToString()))
                {
                    T.Push(tokens[i].ToString());
                }
                else if (tokens[i].Equals(' '))
                {
                    if (i < tokens.Count() - 2 && tokens[i + 1].CompareTo('\'') != 0 && tokens[i - 1].CompareTo('\'') != 0)
                    {
                        if (i < tokens.Count() - 2 && Char.IsLetter(tokens[i - 1]) && Char.IsLetter(tokens[i + 1]))// Ver si el espacio entre 2 variables o letras es igual a una concatenacion
                        {
                            tokens[i] = '.';
                            i--;
                        }
                        else if (i < tokens.Count() - 2 && Precedencias.ContainsKey(tokens[i + 1].ToString()))
                        {
                            // no se hace nada por que ya esta la logica hecha en el arbol
                        }
                        else if (i < tokens.Count() - 2 && Char.IsLetter(tokens[i - 1]) && tokens[i + 1].Equals('('))
                        {
                            tokens[i] = '.';
                            i--;
                        }
                        else if (i < tokens.Count() - 2 && tokens[i + 1].CompareTo(' ') == 0)
                        {
                            bool isLetterBehind = false;
                            bool isComillaBehind = false;
                            if (Char.IsLetter(tokens[i-1]))
                            {
                                isLetterBehind = true;
                            }
                            else if (tokens[i-1].Equals('\''))
                            {
                                isComillaBehind = true;
                            }
                            while (i<tokens.Length - 1 && tokens[i].CompareTo(' ')==0)
                            {
                                i++;
                            }

                            if ((isComillaBehind||isLetterBehind)&&Char.IsLetter(tokens[i]))
                            {
                                tokens[i-1] = '.';                                
                                
                            }
                            else if (tokens[i].CompareTo('(')==0&&isLetterBehind==true)
                            {
                                tokens[i-1] = '.';
                            }                            
                            else
                            {
                                //Se asume que es un caracter especial y la logica esta hecha en el arbol.
                            }
                            i-=2;
                        }
                    }
                    else if (i < tokens.Count() - 2 && tokens[i - 1].CompareTo('\'') == 0 && Char.IsLetter(tokens[i+1]))
                    {
                        tokens[i] = '.';
                        i--;
                    }
                    else if (i < tokens.Count() - 2 && tokens[i +1].CompareTo('\'') == 0 && Char.IsLetter(tokens[i - 1]))
                    {
                        tokens[i] = '.';
                        i--;
                    }
                    
                    
                }
                else
                {
                    if (tokens[i]!='#')
                    {
                        if (tokens[i].Equals('\''))
                        {
                            string auxTokenComilla = "";
                            auxTokenComilla += tokens[i];
                            i++;
                            if (tokens[i+1].Equals('\''))
                            {
                                auxTokenComilla += tokens[i];
                                i++;
                                auxTokenComilla += tokens[i];
                            }

                            if (tokens[i + 1].Equals('\''))
                            {
                                tokens[i] = '.';
                                i--;
                            }
                            Nodo<string> aux = new Nodo<string>();
                            aux.Valor = auxTokenComilla;
                            S.Push(aux);

                        }
                        else
                        {
                            string aux1 = "";
                            if (tokens[i + 1] == '?' || tokens[i + 1] == '*' || tokens[i + 1] == '+' || tokens[i + 1] == '|' || tokens[i + 1] == ']' || tokens[i + 1] == '[' || tokens[i + 1] == '(' || tokens[i + 1] == ')')
                            {
                                aux1 += tokens[i];
                            }
                            else
                            {
                                while (tokens[i].CompareTo('?') != 0 && tokens[i].CompareTo('*') != 0 && tokens[i].CompareTo('+') != 0 && tokens[i].CompareTo('|') != 0 && tokens[i].CompareTo(']') != 0 && tokens[i].CompareTo('[') != 0 && tokens[i].CompareTo('(') != 0 && tokens[i].CompareTo(')') != 0 && tokens[i].CompareTo(' ') != 0 && tokens[i].CompareTo('.') != 0)//Para tomar tokens completos sin necesidad de validaciones innecesarias
                                {
                                    aux1 += tokens[i];
                                    i++;
                                }
                                i--;
                            }

                            if (i < tokens.Count() - 2 && !Precedencias.ContainsKey(tokens[i + 1].ToString()) && tokens[i + 1].CompareTo(')') != 0 && tokens[i + 1].CompareTo(' ') != 0)
                            {
                                tokens[i] = '.';
                                i--;
                            }
                            Nodo<string> aux = new Nodo<string>();
                            aux.Valor = aux1;
                            S.Push(aux);
                        }
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
            FirstLastLeafs(S.Peek());
            RecorridoInorder(S.Peek());




            return Recorrido;
        }

        public void FirstLastLeafs(Nodo<string> nodo)
        {
            if (nodo.Izquierda != null)
            {
                FirstLastLeafs(nodo.Izquierda);

            }
            if (nodo.Derecha != null)
            {
                FirstLastLeafs(nodo.Derecha);
            }
            if (nodo.Derecha == null && nodo.Izquierda == null)
            {
                nodo.Posicion = posicionAux;
                List<int> aux = new List<int>();
                aux.Add(posicionAux);
                nodo.First = aux;
                nodo.Last = aux;
                posicionAux++;
            }
            else
            {
                switch (nodo.Valor)
                {
                    case "*":
                        nodo.Nullable = true;                        
                        nodo.First = nodo.Izquierda.First;                        
                        nodo.Last = nodo.Izquierda.Last;
                        break;
                    case "+":
                        nodo.Nullable = false;
                        nodo.First = nodo.Izquierda.First;
                        nodo.Last = nodo.Izquierda.Last;
                        break;
                    case "?":
                        nodo.Nullable = true;
                        nodo.First = nodo.Izquierda.First;
                        nodo.Last = nodo.Izquierda.Last;
                        break;
                    case ".":
                        if (nodo.Izquierda.Nullable&&nodo.Derecha.Nullable)
                        {
                            nodo.Nullable = true;
                        }
                        else
                        {
                            nodo.Nullable = false;
                        }
                        if (nodo.Izquierda.Nullable)
                        {                            
                            var FirstVarConcat = nodo.Izquierda.First.Union(nodo.Derecha.First);
                            nodo.First = FirstVarConcat.ToList();
                        }
                        else
                        {
                            nodo.First = nodo.Izquierda.First;
                        }

                        if (nodo.Derecha.Nullable)
                        {
                            var LastVarConcat = nodo.Izquierda.Last.Union(nodo.Derecha.Last);
                            nodo.Last = LastVarConcat.ToList();
                        }
                        else
                        {
                            nodo.Last = nodo.Derecha.Last;
                        }
                        break;
                    case "|":
                        if (nodo.Izquierda.Nullable||nodo.Derecha.Nullable)
                        {
                            nodo.Nullable = true;
                        }
                        else
                        {
                            nodo.Nullable = false;
                        }
                        var FirstVarOr = nodo.Izquierda.First.Union(nodo.Derecha.First);
                        nodo.First = FirstVarOr.ToList();
                        var LastVarOr = nodo.Izquierda.Last.Union(nodo.Derecha.Last);
                        nodo.Last = LastVarOr.ToList();
                        break;
                    default:
                        break;
                }
            }
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
