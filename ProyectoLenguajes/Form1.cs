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

            ExpressionTree n1 = new ExpressionTree();
            n1.FirstStep("([A-Z]+[ ]+[=][ ]+(((['][A-Z|0-9|a-z|_]['])|([CHR][(][0-9]+[)]))([\\.][\\.])?[+]?)+[\n]*)*");
            Regex regex = new Regex("([\r\n]*[\\t]?[A-Z]+[ ]+[=][ ]+(((['][A-Z|0-9|a-z|_]['])|(CHR[(][0-9]+[)]))([\\.][\\.])?[+]?)+[\r\n]*)*");
            Regex tokens = new Regex("([\r\n]*[\t]*TOKEN[ ]*[0-9]+[ ]*[=][ ]*((([(|\\{]?[A-Z|a-z|0-9| ]+[()]?[)|\\}]?)|(['].[']))+[\\*|\\+|\\?|\\|]*)+[\r\n]*)*");
            string valor = "	LETRA   = 'A'..'Z'+'a'..'z'+'_'";            
            var matc = regex.Match(valor);


            using (var file = new FileStream(openFile.FileName,FileMode.Open))
            {
                using (var reader = new StreamReader(file))
                {
                    string Texto = reader.ReadToEnd();
                    var aux =  Between(Texto, "TOKENS", "ACTIONS");                    
                    var match = tokens.Match(aux);
                    
                }
            }
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
    }
}
