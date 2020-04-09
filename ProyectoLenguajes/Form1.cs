using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            

            string mensaje = "";
            bool required = true;
            Dictionary<string,string[]> SetsVar = new Dictionary<string, string[]>();
            ExpressionTree SETS = new ExpressionTree();
            string recSet = SETS.FirstStep("(a(a|b)*b)#");
            ExpressionTree TOKENS = new ExpressionTree();
            string recTok = TOKENS.FirstStep("([\r\n|\n|\t| ]*TOKEN[\t| ]*[0-9]+[\t| ]*[=][\t| ]*((([(|\\{]?[A-Z|a-z|0-9| ]+[()]?[)|\\}]?)|(['].[']))+[\\*|\\+|\\?|\\|]*)+[ |\r\n|\n|\t]*)*");
            ExpressionTree ACTIONS = new ExpressionTree();
            string recAct = ACTIONS.FirstStep("((RESERVADAS|[A-Z]+)[(][)][ ]*[\t]*[\r\n|\n| ]*([{][\r\n|\n| ]*([\t]*[ ]*[0-9]+[ ]*[=][ ]*(['][A-Z]+['])[\r\n|\n| ]*)+[\r\n|\n| ]*[}][\r\n|\n| ]*)*)");
            ExpressionTree ERROR = new ExpressionTree();
            string recErr = ERROR.FirstStep("([\r\n|\n|\t| ]*ERROR[ ]*[=][ ]*[0-9]+[\r\n|\n|\t| ]*)*");

            Regex regex = new Regex("([\r\n|\n|\t| ]*[A-Z]+[ ]*[=][ ]*(((['][A-Z|0-9|a-z|_]['])|(CHR[(][0-9]+[)]))([\\.][\\.])?[+]?)+[ |\r\n|\n|\t]*)*");
            Regex tokens = new Regex("([\r\n|\n|\t| ]*TOKEN[\t| ]*[0-9]+[\t| ]*[=][\t| ]*((([(|\\{]?[A-Z|a-z|0-9| ]+[()]?[)|\\}]?)|(['].[']))+[\\*|\\+|\\?|\\|]*)+[ |\r\n|\n|\t]*)*");
            Regex actions = new Regex("((RESERVADAS|[A-Z]+)[(][)][ ]*[\t]*[\r\n|\n| ]*([{][\r\n|\n| ]*([\t]*[ ]*[0-9]+[ ]*[=][ ]*(['][A-Z]+['])[\r\n|\n| ]*)+[\r\n|\n| ]*[}][\r\n|\n| ]*)*)");
            Regex Error = new Regex("([\r\n|\n|\t| ]*ERROR[ ]*[=][ ]*[0-9]+[\r\n|\n|\t| ]*)*");



            Dictionary<string, int> Precedencias = new Dictionary<string, int>();            
            Precedencias.Add("*", 3);
            Precedencias.Add("+", 3);
            Precedencias.Add("?", 3);
            Precedencias.Add(".", 2);
            Precedencias.Add("|", 1);


            using (var file = new FileStream(openFile.FileName,FileMode.Open))
            {
                using (var reader = new StreamReader(file))
                {
                    string Texto = reader.ReadToEnd();
                    if (Regex.IsMatch(Texto,"SETS"))
                    {
                        string inbetween = Between(Texto,"SETS","TOKENS");
                        var matches = regex.Match(inbetween);
                        if (matches.Value.CompareTo("")!=0)
                        {
                            var aux = matches.Value.Replace("\r\n", string.Empty);
                            if (aux.EndsWith(".."))
                            {
                                mensaje += "Gramatica de los SETS ERRONEA";
                                required = false;
                                
                            }
                            else if (aux.EndsWith("+"))
                            {
                                mensaje += "Gramatica de los SETS ERRONEA";
                                required = false;
                            }
                            else
                            {
                                mensaje += "Gramatica de los SETS Aceptada ,";
                                string[] stringSeparators = new string[] { "\r\n" };
                                string[] lines = inbetween.Split(stringSeparators, StringSplitOptions.None);
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    lines[i] = lines[i].Trim('\t');
                                }
                                foreach (var item in lines)
                                {
                                    if (item!="")
                                    {
                                        var auxArray = item.Split('=');
                                        var Variable = auxArray[0].Trim(new Char[] { ' ', '\t'});
                                        var Valor = auxArray[1].Trim(new Char[] { ' ', '\t' });
                                        string[] auxValor;
                                        if (Valor.Contains("+"))
                                        {
                                            auxValor = Valor.Split('+');
                                        }
                                        else
                                        {
                                            auxValor = new string[]{Valor};
                                        }
                                        SetsVar.Add(Variable,auxValor);           

                                    }
                                }
                            }
                        }
                        else
                        {
                            mensaje += "Gramatica de los SETS ERRONEA";
                            required = false;
                        }
                    }
                    else
                    {
                        mensaje += "No se encontro sets, ";
                    }
                    if (Regex.IsMatch(Texto,"TOKENS")&&required==true)
                    {
                        string inbetween = Between(Texto, "TOKENS", "ACTIONS");
                        var matches = tokens.Match(inbetween);
                        var aux = matches.Value.Replace("\r\n", string.Empty);
                        if (matches.Value.CompareTo("") != 0)
                        {

                            
                            var lmao = aux.ToCharArray();
                            string aux2 = "";
                            aux = aux.Trim();
                            if (!aux.EndsWith("'") && !aux.EndsWith("}")&& !aux.EndsWith("*")&& !aux.EndsWith("?")&&!aux.EndsWith("+")&& !aux.EndsWith(")"))
                            {
                                mensaje = "Gramatica de los TOKENS  Erronea";
                                required = false;
                            }
                            for (int i = 0; i < lmao.Count(); i++)
                            {
                                var cha = Convert.ToChar("'");
                                if (lmao[i]=='('&& lmao[i+1]!=cha)
                                {
                                    bool salida = true;
                                    while (salida)
                                    {
                                        if (i<lmao.Count())
                                        {
                                            if (lmao[i] == ')')
                                            {
                                                salida = true;
                                                required = true;
                                            }
                                            else if (aux2.Contains("TOKEN"))
                                            {
                                                salida = false;
                                                required = false;
                                                i = lmao.Count() - 1;
                                            }
                                            aux2 += lmao[i];
                                        }
                                        else
                                        {
                                            salida = false;
                                        }
                                        i++;
                                    }
                                }
                            }

                            if (required==true)
                            {
                                mensaje += "Gramatica de los TOKENS Aceptada ,";
                                string[] stringSeparators = new string[] { "\r\n","\n" };
                                string[] lines = inbetween.Split(stringSeparators, StringSplitOptions.None);
                                string auxString = "";
                                for (int i = 0; i < lines.Length; i++)
                                {
                                    lines[i] = lines[i].Trim('\t');
                                }
                                foreach (var item in lines)
                                {
                                    if (item != "")
                                    {
                                        if (item.Contains("="))
                                        {
                                            var auxArray = item.Split(new Char[] { '=' }, 2);
                                            if (auxArray[0].Contains("TOKEN"))
                                            {
                                                var Variable = auxArray[0].Trim(new Char[] { ' ', '\t', '\n' });
                                                var Valor = auxArray[1].Trim(new Char[] { ' ', '\t', '\n' });
                                                if (Valor.Contains("{ RESERVADAS() }"))
                                                {
                                                    Valor = Valor.Replace("{ RESERVADAS() }", "");
                                                }
                                                auxString += Valor;
                                                auxString += "|";
                                            }
                                        }
                                    }
                                }
                                if (auxString.EndsWith("|"))
                                {
                                    auxString = auxString.Remove(auxString.Length - 1);
                                    auxString = auxString.Trim(new Char[] { ' ', '\t' });
                                }
                                auxString = "(" + auxString + ")#";
                                ExpressionTree tokensExpression = new ExpressionTree();
                                tokensExpression.FirstStep(auxString);
                            }
                            else
                            {
                                mensaje = "Gramatica de los TOKENS  Erronea";
                            }
                        }
                        else
                        {
                            mensaje = "Gramatica de los TOKENS  Erronea";
                            required = false;
                        }
                    }
                    else if(required==true)
                    {
                        mensaje = "No se encontro TOKENS ";
                        required = false;
                    }
                    if (Regex.IsMatch(Texto,"ACTIONS")&&required==true)
                    {
                        string inbetween = Between(Texto, "ACTIONS", "ERROR");
                        var matches = actions.Match(inbetween);
                        if (matches.Value.CompareTo("") != 0)
                        {                            
                            if (matches.Value.Contains("RESERVADAS()"))
                            {
                                mensaje += "Gramatica de las ACTIONS Aceptada ,";
                            }
                            else
                            {
                                mensaje = "Gramatica de las ACTIONS ERRONEA, no contiene RESERVADAS ()";
                                required = false;
                            }
                        }
                        else
                        {
                            mensaje = "Gramatica de las ACTIONS ERRONEA";
                            required = false;
                        }
                    }
                    else if(required==true)
                    {
                        mensaje = "No se encontro ACTIONS ";
                        required = false;
                    }
                    if (Regex.IsMatch(Texto,"ERROR")&&required==true)
                    {
                        string after = After(Texto, "}");                        
                        var matches = Error.Match(after);
                        if (matches.Value.CompareTo("") != 0)
                        {
                            mensaje += "Gramatica de los ERRORES Aceptada.";
                        }
                        else
                        {
                            mensaje = "Gramatica de los ERRRORES ERRONEA";                            
                        }
                    }
                    else if(required==true)
                    {
                        mensaje = "No se encontro ERRORES ";                       
                    }


                    MensajeGramatica.Text = mensaje;

                }
            }
            List<string> ERtoAE = new List<string>();
            ERtoAE.Add("Expresion Regular");
            ERtoAE.Add("([\r\n|\n]*[\t| ]*[A-Z]+[ ]+[=][ ]+(((['][A-Z|0-9|a-z|_]['])|(CHR[(][0-9]+[)]))([\\.][\\.])?[+]?)+[\r\n|\n| |\t]*)+");
            ERtoAE.Add("Recorrido InOrder del Arbol de Expresion");
            ERtoAE.Add(recSet);
            ERtoAE.Add("Expresion Regular");
            ERtoAE.Add("([\r\n|\n|\t| ]*TOKEN[\t| ]*[0-9]+[\t| ]*[=][\t| ]*((([(|\\{]?[A-Z|a-z|0-9| ]+[()]?[)|\\}]?)|(['].[']))+[\\*|\\+|\\?|\\|]*)+[ |\r\n|\n|\t]*)*");
            ERtoAE.Add("Recorrido InOrder del Arbol de Expresion");
            ERtoAE.Add(recTok);
            ERtoAE.Add("Expresion Regular");
            ERtoAE.Add("((RESERVADAS|[A-Z]+)[(][)][ ]*[\t]*[\r\n|\n| ]*([{][\r\n|\n| ]*([\t]*[ ]*[0-9]+[ ]*[=][ ]*(['][A-Z]+['])[\r\n|\n| ]*)+[\r\n|\n| ]*[}][\r\n|\n| ]*)*)");
            ERtoAE.Add("Recorrido InOrder del Arbol de Expresion");
            ERtoAE.Add(recAct);
            ERtoAE.Add("Expresion Regular");
            ERtoAE.Add("([\r\n|\n|\t| ]*ERROR[ ]*[=][ ]*[0-9]+[\r\n|\n|\t| ]*)*");
            ERtoAE.Add("Recorrido InOrder del Arbol de Expresion");
            ERtoAE.Add(recErr);


            Expresiones.DataSource=ERtoAE;
        }
        private bool IsAllUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsUpper(input[i]))
                    return false;
            }

            return true;
        }
        private string Between(string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            int posB = value.LastIndexOf(b);
            if (posA == -1)
            {
                return "";
            }
            if (posB == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB)
            {
                return "";
            }
            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }
        public  string After(string value, string a)
        {
            int posA = value.LastIndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= value.Length)
            {
                return "";
            }
            return value.Substring(adjustedPosA);
        }
        public  string Before( string value, string a)
        {
            int posA = value.IndexOf(a);
            if (posA == -1)
            {
                return "";
            }
            return value.Substring(0, posA);
        }


    }
}
