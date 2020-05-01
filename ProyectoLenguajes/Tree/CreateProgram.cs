﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLenguajes.Tree
{
    class CreateProgram
    {
        public void CrearPrograma(Dictionary<List<int>, List<TransicionClass>> TablaDeTransiciones, Dictionary<string, string[]> SetsVar)
        {
            string fileName = @"C:\Lenguajes\Prueba.cs";
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter fs = File.CreateText(fileName))
                {
                    // Add some text to file                        
                    fs.WriteLine("using System;");                   
                    fs.WriteLine("namespace Prueba");
                    fs.WriteLine("{");
                    fs.WriteLine("class Program");
                    fs.WriteLine("{");
                    fs.WriteLine("static void Main(string[] args)");
                    fs.WriteLine("{");
                    fs.WriteLine("Console.WriteLine(\"Hello World!\");");
                    fs.WriteLine("switch (estado)");
                    fs.WriteLine("{");
                    foreach (var item in TablaDeTransiciones)
                    {
                        string auxTrans = "";
                        foreach (var trans in item.Key)
                        {
                            auxTrans += trans.ToString();
                            auxTrans += ",";
                        }

                        if (auxTrans.EndsWith(","))
                        {
                            auxTrans = auxTrans.TrimEnd(',');
                        }

                        fs.WriteLine("case:"+"\"" + auxTrans+"\"");
                        bool isFirst = true;
                        foreach (var transicion in item.Value)
                        {                            
                            if (SetsVar.Count!=0)
                            {
                                if (SetsVar.ContainsKey(transicion.Simbolo))
                                {
                                    var aux = SetsVar[transicion.Simbolo];
                                    foreach (var Frontiers in aux)
                                    {
                                        if (Frontiers.Contains(".."))
                                        {
                                            if (Frontiers.Contains("CHR"))
                                            {
                                                var Fronteras = Frontiers.Split(new string[] { ".." }, StringSplitOptions.None);
                                                for (int i = 0; i < Fronteras.Length; i++)
                                                {
                                                    Fronteras[i] = Fronteras[i].Replace("CHR", string.Empty);
                                                    Fronteras[i] = Fronteras[i].Trim('(');
                                                    Fronteras[i] = Fronteras[i].Trim(')');
                                                }
                                                string ifstring = "";
                                                if (isFirst)
                                                {
                                                    ifstring = "if(token>=" + Fronteras[0].ToString() + "&&token<=" + Fronteras[1].ToString() + ")";
                                                    isFirst = false;
                                                }
                                                else
                                                {
                                                    ifstring = "else if(token>=" + Fronteras[0].ToString() + "&&token<=" + Fronteras[1].ToString() + ")";
                                                }
                                                fs.WriteLine(ifstring);
                                                fs.WriteLine("{");
                                                fs.WriteLine("estado = " + "\"" + transicion.Transicion + "\"" + ";");
                                                fs.WriteLine("}");

                                            }
                                            else
                                            {
                                                var Fronteras = Frontiers.Split(new string[] { ".." }, StringSplitOptions.None);
                                                byte[] auxByte = new byte[2];
                                                for (int i = 0; i < Fronteras.Length; i++)
                                                {
                                                    Fronteras[i] = Fronteras[i].Trim('\'');
                                                }

                                                var LimiteInferior = Encoding.ASCII.GetBytes(Fronteras[0]);
                                                var LimiteSuperior = Encoding.ASCII.GetBytes(Fronteras[1]);

                                                string ifstring = "";
                                                if (isFirst)
                                                {
                                                    ifstring= "if(token>=" + LimiteInferior[0].ToString() + "&&token<=" + LimiteSuperior[0].ToString()+")";
                                                    isFirst = false;
                                                }
                                                else
                                                {
                                                   ifstring = "else if(token>=" + LimiteInferior[0].ToString() + "&&token<=" + LimiteSuperior[0].ToString()+")";
                                                }                                                
                                                fs.WriteLine(ifstring);
                                                fs.WriteLine("{");
                                                fs.WriteLine("estado = "+ "\"" +transicion.Transicion+"\""+";");
                                                fs.WriteLine("}");
                                            }
                                        }
                                        else
                                        {
                                            var ValidateVar = Frontiers.Trim('\'');
                                            var EqualsByte = Encoding.ASCII.GetBytes(ValidateVar);
                                            string ifstring = "";
                                            if (isFirst)
                                            {
                                                ifstring = "if(token=="+ EqualsByte[0].ToString()+ ")";
                                                isFirst = false;
                                            }
                                            else
                                            {
                                                ifstring = "else if(token==" + EqualsByte[0].ToString() + ")";
                                            }
                                            fs.WriteLine(ifstring);
                                            fs.WriteLine("{");
                                            fs.WriteLine("estado = " + "\"" + transicion.Transicion + "\"" + ";");
                                            fs.WriteLine("}");
                                        }
                                    }
                                }
                                else
                                {

                                }
                            }
                        }
                        fs.WriteLine("break;");
                    }
                    fs.WriteLine("}");
                    fs.WriteLine("Console.ReadKey();");
                    fs.WriteLine("}");
                    fs.WriteLine("}");
                    fs.WriteLine("}");                    
                    fs.Close();
                }
                //FileInfo sourceFile = new FileInfo(fileName);
                //CodeDomProvider provider = null;
                //bool compileOk = false;

                //// Select the code provider based on the input file extension.
                //if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
                //{
                //    provider = CodeDomProvider.CreateProvider("CSharp");
                //}
                //else if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".VB")
                //{
                //    provider = CodeDomProvider.CreateProvider("VisualBasic");
                //}
                //else
                //{
                //    Console.WriteLine("Source file must have a .cs or .vb extension");
                //}

                //if (provider != null)
                //{

                //    // Format the executable file name.
                //    // Build the output assembly path using the current directory
                //    // and <source>_cs.exe or <source>_vb.exe.

                //    String exeName = String.Format(@"{0}\{1}.exe",
                //        System.Environment.CurrentDirectory,
                //        sourceFile.Name.Replace(".", "_"));

                //    CompilerParameters cp = new CompilerParameters();

                //    // Generate an executable instead of
                //    // a class library.
                //    cp.GenerateExecutable = true;

                //    // Specify the assembly file name to generate.
                //    cp.OutputAssembly = exeName;

                //    // Save the assembly as a physical file.
                //    cp.GenerateInMemory = false;

                //    // Set whether to treat all warnings as errors.
                //    cp.TreatWarningsAsErrors = false;

                //    // Invoke compilation of the source file.
                //    CompilerResults cr = provider.CompileAssemblyFromFile(cp,
                //        fileName);

                //    if (cr.Errors.Count > 0)
                //    {
                //        // Display compilation errors.
                //        Console.WriteLine("Errors building {0} into {1}",
                //            fileName, cr.PathToAssembly);
                //        foreach (CompilerError ce in cr.Errors)
                //        {
                //            Console.WriteLine("  {0}", ce.ToString());
                //            Console.WriteLine();
                //        }
                //    }
                //    else
                //    {
                //        // Display a successful compilation message.
                //        Console.WriteLine("Source {0} built into {1} successfully.",
                //            fileName, cr.PathToAssembly);
                //    }

                //    // Return the results of the compilation.
                //    if (cr.Errors.Count > 0)
                //    {
                //        compileOk = false;
                //    }
                //    else
                //    {
                //        compileOk = true;
                //    }
                //}



            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
