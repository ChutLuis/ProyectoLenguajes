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

            using (var file = new FileStream(openFile.FileName,FileMode.Open))
            {
                using (var reader = new StreamReader(file))
                {
                    string firstBlock = reader.ReadLine();
                    firstBlock += "\n";
                    while (firstBlock!= null)
                    {
                        if (IsAllUpper(firstBlock)&& firstBlock=="SETS")
                        {

                        }
                        else if (IsAllUpper(firstBlock) && "SETS".Contains(firstBlock))
                        {
                            
                        }
                        firstBlock = reader.ReadLine();
                        firstBlock += "\n";
                    }
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
    }
}
