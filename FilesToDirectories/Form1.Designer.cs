namespace FilesToDirectories
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_NameStep1 = new System.Windows.Forms.Label();
            this.button_SelectDirectory = new System.Windows.Forms.Button();
            this.label_SelectedDirectory = new System.Windows.Forms.Label();
            this.label_NameStep2 = new System.Windows.Forms.Label();
            this.listBox_ListFiles = new System.Windows.Forms.ListBox();
            this.label_NameStep3 = new System.Windows.Forms.Label();
            this.button_StartToMove = new System.Windows.Forms.Button();
            this.label_CountSelectedFiles = new System.Windows.Forms.Label();
            this.label_CountFiles = new System.Windows.Forms.Label();
            this.label_of = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox_InformationFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NameStep1
            // 
            this.label_NameStep1.AutoSize = true;
            this.label_NameStep1.Location = new System.Drawing.Point(12, 9);
            this.label_NameStep1.Name = "label_NameStep1";
            this.label_NameStep1.Size = new System.Drawing.Size(134, 17);
            this.label_NameStep1.TabIndex = 0;
            this.label_NameStep1.Text = "1. Select a directory";
            // 
            // button_SelectDirectory
            // 
            this.button_SelectDirectory.Location = new System.Drawing.Point(16, 51);
            this.button_SelectDirectory.Name = "button_SelectDirectory";
            this.button_SelectDirectory.Size = new System.Drawing.Size(75, 23);
            this.button_SelectDirectory.TabIndex = 1;
            this.button_SelectDirectory.Text = "Select";
            this.button_SelectDirectory.UseVisualStyleBackColor = true;
            this.button_SelectDirectory.Click += new System.EventHandler(this.Select_Click);
            // 
            // label_SelectedDirectory
            // 
            this.label_SelectedDirectory.AutoSize = true;
            this.label_SelectedDirectory.Location = new System.Drawing.Point(110, 54);
            this.label_SelectedDirectory.Name = "label_SelectedDirectory";
            this.label_SelectedDirectory.Size = new System.Drawing.Size(170, 17);
            this.label_SelectedDirectory.TabIndex = 2;
            this.label_SelectedDirectory.Text = "a directory is not selected";
            // 
            // label_NameStep2
            // 
            this.label_NameStep2.AutoSize = true;
            this.label_NameStep2.Location = new System.Drawing.Point(12, 102);
            this.label_NameStep2.Name = "label_NameStep2";
            this.label_NameStep2.Size = new System.Drawing.Size(146, 17);
            this.label_NameStep2.TabIndex = 3;
            this.label_NameStep2.Text = "2. Select files to move";
            // 
            // listBox_ListFiles
            // 
            this.listBox_ListFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_ListFiles.FormattingEnabled = true;
            this.listBox_ListFiles.ItemHeight = 16;
            this.listBox_ListFiles.Location = new System.Drawing.Point(0, 0);
            this.listBox_ListFiles.Name = "listBox_ListFiles";
            this.listBox_ListFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_ListFiles.Size = new System.Drawing.Size(249, 375);
            this.listBox_ListFiles.TabIndex = 4;
            this.listBox_ListFiles.SelectedValueChanged += new System.EventHandler(this.ListBox_SelectedItemsChanged);
            // 
            // label_NameStep3
            // 
            this.label_NameStep3.AutoSize = true;
            this.label_NameStep3.Location = new System.Drawing.Point(12, 184);
            this.label_NameStep3.Name = "label_NameStep3";
            this.label_NameStep3.Size = new System.Drawing.Size(184, 17);
            this.label_NameStep3.TabIndex = 5;
            this.label_NameStep3.Text = "3. Moving files to directories";
            // 
            // button_StartToMove
            // 
            this.button_StartToMove.Location = new System.Drawing.Point(14, 234);
            this.button_StartToMove.Name = "button_StartToMove";
            this.button_StartToMove.Size = new System.Drawing.Size(75, 23);
            this.button_StartToMove.TabIndex = 6;
            this.button_StartToMove.Text = "Start";
            this.button_StartToMove.UseVisualStyleBackColor = true;
            this.button_StartToMove.Click += new System.EventHandler(this.Start_Click);
            // 
            // label_CountSelectedFiles
            // 
            this.label_CountSelectedFiles.AutoSize = true;
            this.label_CountSelectedFiles.Location = new System.Drawing.Point(32, 142);
            this.label_CountSelectedFiles.Name = "label_CountSelectedFiles";
            this.label_CountSelectedFiles.Size = new System.Drawing.Size(16, 17);
            this.label_CountSelectedFiles.TabIndex = 7;
            this.label_CountSelectedFiles.Text = "0";
            // 
            // label_CountFiles
            // 
            this.label_CountFiles.AutoSize = true;
            this.label_CountFiles.Location = new System.Drawing.Point(116, 142);
            this.label_CountFiles.Name = "label_CountFiles";
            this.label_CountFiles.Size = new System.Drawing.Size(16, 17);
            this.label_CountFiles.TabIndex = 8;
            this.label_CountFiles.Text = "0";
            // 
            // label_of
            // 
            this.label_of.AutoSize = true;
            this.label_of.Location = new System.Drawing.Point(90, 142);
            this.label_of.Name = "label_of";
            this.label_of.Size = new System.Drawing.Size(20, 17);
            this.label_of.TabIndex = 9;
            this.label_of.Text = "of";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_CountFiles);
            this.splitContainer1.Panel1.Controls.Add(this.button_StartToMove);
            this.splitContainer1.Panel1.Controls.Add(this.label_NameStep1);
            this.splitContainer1.Panel1.Controls.Add(this.label_NameStep3);
            this.splitContainer1.Panel1.Controls.Add(this.label_of);
            this.splitContainer1.Panel1.Controls.Add(this.label_CountSelectedFiles);
            this.splitContainer1.Panel1.Controls.Add(this.button_SelectDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.label_SelectedDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.label_NameStep2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 375);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox_ListFiles);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox_InformationFile);
            this.splitContainer2.Size = new System.Drawing.Size(518, 375);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 5;
            // 
            // textBox_InformationFile
            // 
            this.textBox_InformationFile.AcceptsReturn = true;
            this.textBox_InformationFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_InformationFile.Location = new System.Drawing.Point(0, 0);
            this.textBox_InformationFile.Multiline = true;
            this.textBox_InformationFile.Name = "textBox_InformationFile";
            this.textBox_InformationFile.ReadOnly = true;
            this.textBox_InformationFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_InformationFile.Size = new System.Drawing.Size(265, 375);
            this.textBox_InformationFile.TabIndex = 1;
            this.textBox_InformationFile.Text = "To look information about a file select one file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Files to Directories";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_NameStep1;
        private System.Windows.Forms.Button button_SelectDirectory;
        private System.Windows.Forms.Label label_SelectedDirectory;
        private System.Windows.Forms.Label label_NameStep2;
        private System.Windows.Forms.ListBox listBox_ListFiles;
        private System.Windows.Forms.Label label_NameStep3;
        private System.Windows.Forms.Button button_StartToMove;
        private System.Windows.Forms.Label label_CountSelectedFiles;
        private System.Windows.Forms.Label label_CountFiles;
        private System.Windows.Forms.Label label_of;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox_InformationFile;
    }
}

