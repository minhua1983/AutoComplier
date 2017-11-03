using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.CodeDom.Compiler;
using Microsoft.VisualStudio.TextTemplating;

namespace AutoComplier.Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolPathSelectLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = toolPathOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK) toolPathTextBox.Text = toolPathOpenFileDialog.FileName;
        }

        private void filePathSelectLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = toolPathOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK) filePathTextBox.Text = toolPathOpenFileDialog.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = new string[] {
                //@"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\Test.tt",
                @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\Model.tt",
                @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\Repository.tt",
                @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\Service.tt",
                @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\Controller.tt"
            };

            //MessageBox.Show(System.Environment.CurrentDirectory);

            files.ToList().ForEach(file =>
            {
                CustomCmdLineHost host = new CustomCmdLineHost();
                Engine engine = new Engine();
                host.TemplateFileValue = file;
                string input = File.ReadAllText(file);

                string output = engine.ProcessTemplate(input, host);
                //MessageBox.Show(output);

                foreach (CompilerError error in host.Errors)
                {
                    MessageBox.Show(error.ToString());
                }
            });

            //*最大化，且不会自动关闭
            string cmd = toolPathTextBox.Text + " " + filePathTextBox.Text + " " + parameterTextBox.Text;
            cmd += " \n pause";
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.WindowStyle = ProcessWindowStyle.Maximized;
            ps.FileName = "cmd.exe";
            ps.Arguments = "/K " + cmd + @"
            pause";
            Process.Start(ps);
            //*/
            //启动MSBuild.exe
            //Process.Start(toolPathTextBox.Text, filePathTextBox.Text +@" " + parameterTextBox.Text);
        }
    }
}
