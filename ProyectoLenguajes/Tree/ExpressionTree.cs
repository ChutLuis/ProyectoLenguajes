﻿using ProyectoLenguajes.Tree;
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
        public void FirstStep(string RE)
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
                if (tokens[i].Equals('['))
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
                    if (tokenST.CompareTo("") != 0 && tokenST.CompareTo("]") != 0 && tokenST.CompareTo("|") != 0)
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
                    if (i < tokens.Count() - 2 && tokens[i + 1].Equals('['))
                    {
                        T.Push(".");
                    }
                }
                else if (tokens[i].Equals('('))
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
                    if (i<tokens.Count()-2&&(tokens[i+1].Equals('(')))
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
                    if (i< tokens.Count()-2 &&( tokens[i + 1].Equals('[')|| tokens[i + 1].Equals('(')))
                    {
                        T.Push(".");
                    }
                }
                else if (T.Count() > 0 && T.Peek().CompareTo("(") != 0 && tokens[i].Equals('|'))
                {
                    string aux = T.Pop();
                    Nodo<string> nodo = new Nodo<string>();
                    nodo.Valor = aux;
                    nodo.Derecha = S.Pop();
                    nodo.Izquierda = S.Pop();
                    S.Push(nodo);
                }
                else
                {
                    T.Push(tokens[i].ToString());
                }
            }

            RecorridoInorder(S.Pop());
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
