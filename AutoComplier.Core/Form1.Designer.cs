namespace AutoComplier.Core
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableNameLabel = new System.Windows.Forms.Label();
            this.toolPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.filePathSelectLabel = new System.Windows.Forms.Label();
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolPathOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolPathSelectLabel = new System.Windows.Forms.Label();
            this.filePathOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableNameLabel
            // 
            this.tableNameLabel.AutoSize = true;
            this.tableNameLabel.Location = new System.Drawing.Point(12, 13);
            this.tableNameLabel.Name = "tableNameLabel";
            this.tableNameLabel.Size = new System.Drawing.Size(47, 12);
            this.tableNameLabel.TabIndex = 0;
            this.tableNameLabel.Text = "MSBUILD";
            // 
            // toolPathTextBox
            // 
            this.toolPathTextBox.Location = new System.Drawing.Point(72, 10);
            this.toolPathTextBox.Name = "toolPathTextBox";
            this.toolPathTextBox.Size = new System.Drawing.Size(191, 21);
            this.toolPathTextBox.TabIndex = 1;
            this.toolPathTextBox.Text = "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\MSBuild.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "构建路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "构建参数";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(73, 44);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(190, 21);
            this.filePathTextBox.TabIndex = 5;
            // 
            // filePathSelectLabel
            // 
            this.filePathSelectLabel.AutoSize = true;
            this.filePathSelectLabel.Location = new System.Drawing.Point(271, 47);
            this.filePathSelectLabel.Name = "filePathSelectLabel";
            this.filePathSelectLabel.Size = new System.Drawing.Size(29, 12);
            this.filePathSelectLabel.TabIndex = 6;
            this.filePathSelectLabel.Text = "选择";
            this.filePathSelectLabel.Click += new System.EventHandler(this.filePathSelectLabel_Click);
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Location = new System.Drawing.Point(73, 82);
            this.parameterTextBox.Multiline = true;
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(499, 137);
            this.parameterTextBox.TabIndex = 7;
            this.parameterTextBox.Text = resources.GetString("parameterTextBox.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "编译生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolPathOpenFileDialog
            // 
            this.toolPathOpenFileDialog.FileName = "toolPathOpenFileDialog";
            // 
            // toolPathSelectLabel
            // 
            this.toolPathSelectLabel.AutoSize = true;
            this.toolPathSelectLabel.Location = new System.Drawing.Point(271, 13);
            this.toolPathSelectLabel.Name = "toolPathSelectLabel";
            this.toolPathSelectLabel.Size = new System.Drawing.Size(29, 12);
            this.toolPathSelectLabel.TabIndex = 9;
            this.toolPathSelectLabel.Text = "选择";
            this.toolPathSelectLabel.Click += new System.EventHandler(this.toolPathSelectLabel_Click);
            // 
            // filePathOpenFileDialog
            // 
            this.filePathOpenFileDialog.FileName = "filePathOpenFileDialog";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(154, 232);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(53, 12);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "生成状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.toolPathSelectLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parameterTextBox);
            this.Controls.Add(this.filePathSelectLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolPathTextBox);
            this.Controls.Add(this.tableNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableNameLabel;
        private System.Windows.Forms.TextBox toolPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label filePathSelectLabel;
        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog toolPathOpenFileDialog;
        private System.Windows.Forms.Label toolPathSelectLabel;
        private System.Windows.Forms.OpenFileDialog filePathOpenFileDialog;
        private System.Windows.Forms.Label resultLabel;
    }
}

