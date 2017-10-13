namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbDelimiter = new System.Windows.Forms.ComboBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtDictFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(80, 11);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(251, 24);
            this.lblCaption.TabIndex = 24;
            this.lblCaption.Text = "Permutation Cryptanalysis";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(125, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbDelimiter
            // 
            this.cbDelimiter.FormattingEnabled = true;
            this.cbDelimiter.Items.AddRange(new object[] {
            "Comma",
            "Tab",
            "Space"});
            this.cbDelimiter.Location = new System.Drawing.Point(62, 167);
            this.cbDelimiter.Name = "cbDelimiter";
            this.cbDelimiter.Size = new System.Drawing.Size(149, 21);
            this.cbDelimiter.TabIndex = 22;
            this.cbDelimiter.Text = "Comma";
            this.cbDelimiter.SelectedIndexChanged += new System.EventHandler(this.cbDelimiter_SelectedIndexChanged);
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(9, 170);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(47, 13);
            this.lblDelimiter.TabIndex = 21;
            this.lblDelimiter.Text = "Delimiter";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(232, 165);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(155, 23);
            this.decryptButton.TabIndex = 20;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(12, 225);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(375, 54);
            this.plainTextBox.TabIndex = 19;
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Location = new System.Drawing.Point(9, 209);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(54, 13);
            this.plainTextLabel.TabIndex = 18;
            this.plainTextLabel.Text = "Plain Text";
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(12, 56);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(375, 69);
            this.cipherTextBox.TabIndex = 17;
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Location = new System.Drawing.Point(9, 40);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(65, 13);
            this.cipherLabel.TabIndex = 16;
            this.cipherLabel.Text = "Enter Cipher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Dictionary File: ";
            // 
            // fDialog
            // 
            this.fDialog.FileName = "fDialog";
            // 
            // txtDictFileName
            // 
            this.txtDictFileName.Location = new System.Drawing.Point(84, 138);
            this.txtDictFileName.Multiline = true;
            this.txtDictFileName.Name = "txtDictFileName";
            this.txtDictFileName.Size = new System.Drawing.Size(269, 20);
            this.txtDictFileName.TabIndex = 26;
            this.txtDictFileName.Text = "D:\\Rana\\C\\Users\\Old Win Data\\Data\\School\\ModernCryptography\\DictionaryCrypto\\Wind" +
    "owsFormsApplication1\\WindowsFormsApplication1\\Test+2+english+words+_20_.txt";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(349, 136);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFile.TabIndex = 27;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 323);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtDictFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDelimiter);
            this.Controls.Add(this.lblDelimiter);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.cipherLabel);
            this.Name = "Form1";
            this.Text = "Permutation Cryptanalysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbDelimiter;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fDialog;
        private System.Windows.Forms.TextBox txtDictFileName;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

