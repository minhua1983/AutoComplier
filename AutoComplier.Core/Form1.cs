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
            resultLabel.Text = "代码生成中...";

            string AutoCompilerPath = @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\";


            string[] files = new string[] {
                //@"D:\minhua\workspace\AutoComplier\AutoComplier.UI\T4\Test.tt",
                AutoCompilerPath + @"Model.tt",
                AutoCompilerPath + @"Repository.tt",
                AutoCompilerPath + @"Service.tt",
                AutoCompilerPath + @"Controller.tt"
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
                    //MessageBox.Show(error.ToString());
                }

                if (host.Errors == null || host.Errors.Count == 0)
                {
                    file = file.Replace(".tt", ".cs");
                    using (StreamWriter writer = new StreamWriter(file))
                    {
                        writer.Write(output);
                    }
                }
            });

            resultLabel.Text = "项目构建中...";

            /*最大化，且不会自动关闭
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
            Process.Start(toolPathTextBox.Text, filePathTextBox.Text +@" " + parameterTextBox.Text);

            resultLabel.Text = "处理完毕";
        }
    }
}
