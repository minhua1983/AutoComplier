﻿using System;
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
            string templateFileName = @"D:\minhua\workspace\AutoComplier\AutoComplier.UI\Test.tt";

            CustomCmdLineHost host = new CustomCmdLineHost();
            Engine engine = new Engine();
            host.TemplateFileValue = templateFileName;
            string input = File.ReadAllText(templateFileName);



            string output = engine.ProcessTemplate(input, host);
            MessageBox.Show(output);


            foreach (CompilerError error in host.Errors)
            {
                MessageBox.Show(error.ToString());
            }

            //启动MSBuild.exe
            Process.Start(toolPathTextBox.Text, filePathTextBox.Text + " " + parameterTextBox.Text);
        }
    }
}
