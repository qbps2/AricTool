
namespace SearchStringProject
{
    partial class SearchStringProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMultiResult = new System.Windows.Forms.CheckBox();
            this.checkBoxShowLine = new System.Windows.Forms.CheckBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonOpenCompleteFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchString3 = new System.Windows.Forms.TextBox();
            this.textBoxSearchString2 = new System.Windows.Forms.TextBox();
            this.textBoxSearchString1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPrintLine1 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintLine2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintLine3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(15, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(146, 39);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Location = new System.Drawing.Point(17, 401);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(198, 38);
            this.buttonExecute.TabIndex = 7;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMultiResult);
            this.groupBox1.Controls.Add(this.checkBoxShowLine);
            this.groupBox1.Location = new System.Drawing.Point(17, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // checkBoxMultiResult
            // 
            this.checkBoxMultiResult.AutoSize = true;
            this.checkBoxMultiResult.Location = new System.Drawing.Point(16, 64);
            this.checkBoxMultiResult.Name = "checkBoxMultiResult";
            this.checkBoxMultiResult.Size = new System.Drawing.Size(119, 24);
            this.checkBoxMultiResult.TabIndex = 11;
            this.checkBoxMultiResult.Text = "Multi-Result";
            this.checkBoxMultiResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowLine
            // 
            this.checkBoxShowLine.AutoSize = true;
            this.checkBoxShowLine.Location = new System.Drawing.Point(16, 34);
            this.checkBoxShowLine.Name = "checkBoxShowLine";
            this.checkBoxShowLine.Size = new System.Drawing.Size(169, 24);
            this.checkBoxShowLine.TabIndex = 10;
            this.checkBoxShowLine.Text = "Show Line Number";
            this.checkBoxShowLine.UseVisualStyleBackColor = true;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(191, 21);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(13, 20);
            this.labelFileName.TabIndex = 9;
            this.labelFileName.Text = ".";
            // 
            // buttonOpenCompleteFile
            // 
            this.buttonOpenCompleteFile.Location = new System.Drawing.Point(280, 401);
            this.buttonOpenCompleteFile.Name = "buttonOpenCompleteFile";
            this.buttonOpenCompleteFile.Size = new System.Drawing.Size(197, 38);
            this.buttonOpenCompleteFile.TabIndex = 10;
            this.buttonOpenCompleteFile.Text = "Open Complete File";
            this.buttonOpenCompleteFile.UseVisualStyleBackColor = true;
            this.buttonOpenCompleteFile.Click += new System.EventHandler(this.buttonOpenCompleteFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPrintLine3);
            this.groupBox2.Controls.Add(this.checkBoxPrintLine2);
            this.groupBox2.Controls.Add(this.checkBoxPrintLine1);
            this.groupBox2.Controls.Add(this.textBoxSearchString3);
            this.groupBox2.Controls.Add(this.textBoxSearchString2);
            this.groupBox2.Controls.Add(this.textBoxSearchString1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "String Settings:";
            // 
            // textBoxSearchString3
            // 
            this.textBoxSearchString3.Location = new System.Drawing.Point(206, 130);
            this.textBoxSearchString3.Name = "textBoxSearchString3";
            this.textBoxSearchString3.Size = new System.Drawing.Size(291, 26);
            this.textBoxSearchString3.TabIndex = 12;
            // 
            // textBoxSearchString2
            // 
            this.textBoxSearchString2.Location = new System.Drawing.Point(206, 83);
            this.textBoxSearchString2.Name = "textBoxSearchString2";
            this.textBoxSearchString2.Size = new System.Drawing.Size(291, 26);
            this.textBoxSearchString2.TabIndex = 11;
            // 
            // textBoxSearchString1
            // 
            this.textBoxSearchString1.Location = new System.Drawing.Point(206, 35);
            this.textBoxSearchString1.Name = "textBoxSearchString1";
            this.textBoxSearchString1.Size = new System.Drawing.Size(291, 26);
            this.textBoxSearchString1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search String 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search String 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search String 1:";
            // 
            // checkBoxPrintLine1
            // 
            this.checkBoxPrintLine1.AutoSize = true;
            this.checkBoxPrintLine1.Location = new System.Drawing.Point(535, 35);
            this.checkBoxPrintLine1.Name = "checkBoxPrintLine1";
            this.checkBoxPrintLine1.Size = new System.Drawing.Size(179, 24);
            this.checkBoxPrintLine1.TabIndex = 14;
            this.checkBoxPrintLine1.Text = "Print Appended Line";
            this.checkBoxPrintLine1.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintLine2
            // 
            this.checkBoxPrintLine2.AutoSize = true;
            this.checkBoxPrintLine2.Location = new System.Drawing.Point(535, 83);
            this.checkBoxPrintLine2.Name = "checkBoxPrintLine2";
            this.checkBoxPrintLine2.Size = new System.Drawing.Size(179, 24);
            this.checkBoxPrintLine2.TabIndex = 15;
            this.checkBoxPrintLine2.Text = "Print Appended Line";
            this.checkBoxPrintLine2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrintLine3
            // 
            this.checkBoxPrintLine3.AutoSize = true;
            this.checkBoxPrintLine3.Location = new System.Drawing.Point(535, 129);
            this.checkBoxPrintLine3.Name = "checkBoxPrintLine3";
            this.checkBoxPrintLine3.Size = new System.Drawing.Size(179, 24);
            this.checkBoxPrintLine3.TabIndex = 16;
            this.checkBoxPrintLine3.Text = "Print Appended Line";
            this.checkBoxPrintLine3.UseVisualStyleBackColor = true;
            // 
            // SearchStringProject
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOpenCompleteFile);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "SearchStringProject";
            this.Text = "Search String 1.0.1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SearchStringProject_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SearchStringProject_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxShowLine;
        private System.Windows.Forms.CheckBox checkBoxMultiResult;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonOpenCompleteFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearchString3;
        private System.Windows.Forms.TextBox textBoxSearchString2;
        private System.Windows.Forms.TextBox textBoxSearchString1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPrintLine3;
        private System.Windows.Forms.CheckBox checkBoxPrintLine2;
        private System.Windows.Forms.CheckBox checkBoxPrintLine1;
    }
}

