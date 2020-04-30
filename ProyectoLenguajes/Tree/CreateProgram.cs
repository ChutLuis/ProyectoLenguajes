using System;
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
        public void CrearPrograma(Dictionary<List<int>, List<TransicionClass>> TablaDeTransiciones)
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
                        foreach (var transicion in item.Value)
                        {
                            
                        }
                        fs.WriteLine("break;");
                    }
                    fs.WriteLine("Console.ReadKey();");
                    fs.WriteLine("}");
                    fs.WriteLine("}");
                    fs.WriteLine("}");                    
                    fs.Close();
                }
                FileInfo sourceFile = new FileInfo(fileName);
                CodeDomProvider provider = null;
                bool compileOk = false;

                // Select the code provider based on the input file extension.
                if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".CS")
                {
                    provider = CodeDomProvider.CreateProvider("CSharp");
                }
                else if (sourceFile.Extension.ToUpper(CultureInfo.InvariantCulture) == ".VB")
                {
                    provider = CodeDomProvider.CreateProvider("VisualBasic");
                }
                else
                {
                    Console.WriteLine("Source file must have a .cs or .vb extension");
                }

                if (provider != null)
                {

                    // Format the executable file name.
                    // Build the output assembly path using the current directory
                    // and <source>_cs.exe or <source>_vb.exe.

                    String exeName = String.Format(@"{0}\{1}.exe",
                        System.Environment.CurrentDirectory,
                        sourceFile.Name.Replace(".", "_"));

                    CompilerParameters cp = new CompilerParameters();

                    // Generate an executable instead of
                    // a class library.
                    cp.GenerateExecutable = true;

                    // Specify the assembly file name to generate.
                    cp.OutputAssembly = exeName;

                    // Save the assembly as a physical file.
                    cp.GenerateInMemory = false;

                    // Set whether to treat all warnings as errors.
                    cp.TreatWarningsAsErrors = false;

                    // Invoke compilation of the source file.
                    CompilerResults cr = provider.CompileAssemblyFromFile(cp,
                        fileName);

                    if (cr.Errors.Count > 0)
                    {
                        // Display compilation errors.
                        Console.WriteLine("Errors building {0} into {1}",
                            fileName, cr.PathToAssembly);
                        foreach (CompilerError ce in cr.Errors)
                        {
                            Console.WriteLine("  {0}", ce.ToString());
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        // Display a successful compilation message.
                        Console.WriteLine("Source {0} built into {1} successfully.",
                            fileName, cr.PathToAssembly);
                    }

                    // Return the results of the compilation.
                    if (cr.Errors.Count > 0)
                    {
                        compileOk = false;
                    }
                    else
                    {
                        compileOk = true;
                    }
                }



            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
