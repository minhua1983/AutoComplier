using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;
using Microsoft.VisualStudio.TextTemplating;

namespace AutoComplier.XCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string templateFileName = @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\Test.tt";

            CustomCmdLineHost host = new CustomCmdLineHost();
            Engine engine = new Engine();
            host.TemplateFileValue = templateFileName;
            string input = File.ReadAllText(templateFileName);



            string output = engine.ProcessTemplate(input, host);
            Console.WriteLine(output);


            foreach (CompilerError error in host.Errors)
            {
                Console.WriteLine(error.ToString());
            }

            Console.ReadLine();
        }
    }
}
