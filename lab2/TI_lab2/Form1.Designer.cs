namespace TI_lab2
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
            this.tbPolyndrome = new System.Windows.Forms.TextBox();
            this.tbStartRegister = new System.Windows.Forms.TextBox();
            this.btnEncDec = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.tbEncDec = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPolyndrome = new System.Windows.Forms.Label();
            this.lblKeyStream = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblEncDec = new System.Windows.Forms.Label();
            this.lblStartReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPolyndrome
            // 
            this.tbPolyndrome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbPolyndrome.Location = new System.Drawing.Point(114, 12);
            this.tbPolyndrome.Name = "tbPolyndrome";
            this.tbPolyndrome.ReadOnly = true;
            this.tbPolyndrome.Size = new System.Drawing.Size(100, 20);
            this.tbPolyndrome.TabIndex = 0;
            this.tbPolyndrome.Text = "x^25 + x^3 + 1";
            // 
            // tbStartRegister
            // 
            this.tbStartRegister.Location = new System.Drawing.Point(268, 40);
            this.tbStartRegister.Name = "tbStartRegister";
            this.tbStartRegister.Size = new System.Drawing.Size(190, 20);
            this.tbStartRegister.TabIndex = 1;
            this.tbStartRegister.TextChanged += new System.EventHandler(this.tbStartRegister_TextChanged);
            this.tbStartRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStartRegister_KeyPress);
            // 
            // btnEncDec
            // 
            this.btnEncDec.Location = new System.Drawing.Point(12, 119);
            this.btnEncDec.Name = "btnEncDec";
            this.btnEncDec.Size = new System.Drawing.Size(152, 33);
            this.btnEncDec.TabIndex = 2;
            this.btnEncDec.Text = "Encrypt/decrypt";
            this.btnEncDec.UseVisualStyleBackColor = true;
            this.btnEncDec.Click += new System.EventHandler(this.btnEncDec_Click);
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(12, 183);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ReadOnly = true;
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(776, 56);
            this.tbKey.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 72);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(86, 32);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilePath.Location = new System.Drawing.Point(104, 74);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 24);
            this.lblFilePath.TabIndex = 5;
            // 
            // tbOriginal
            // 
            this.tbOriginal.Location = new System.Drawing.Point(12, 264);
            this.tbOriginal.Multiline = true;
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.ReadOnly = true;
            this.tbOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOriginal.Size = new System.Drawing.Size(776, 56);
            this.tbOriginal.TabIndex = 6;
            // 
            // tbEncDec
            // 
            this.tbEncDec.Location = new System.Drawing.Point(12, 341);
            this.tbEncDec.Multiline = true;
            this.tbEncDec.Name = "tbEncDec";
            this.tbEncDec.ReadOnly = true;
            this.tbEncDec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncDec.Size = new System.Drawing.Size(776, 56);
            this.tbEncDec.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(11, 416);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 8;
            // 
            // lblPolyndrome
            // 
            this.lblPolyndrome.AutoSize = true;
            this.lblPolyndrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPolyndrome.Location = new System.Drawing.Point(12, 12);
            this.lblPolyndrome.Name = "lblPolyndrome";
            this.lblPolyndrome.Size = new System.Drawing.Size(93, 20);
            this.lblPolyndrome.TabIndex = 9;
            this.lblPolyndrome.Text = "Многочлен";
            // 
            // lblKeyStream
            // 
            this.lblKeyStream.AutoSize = true;
            this.lblKeyStream.Location = new System.Drawing.Point(13, 167);
            this.lblKeyStream.Name = "lblKeyStream";
            this.lblKeyStream.Size = new System.Drawing.Size(79, 13);
            this.lblKeyStream.TabIndex = 10;
            this.lblKeyStream.Text = "Прямой поток";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(13, 248);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(87, 13);
            this.lblOriginal.TabIndex = 11;
            this.lblOriginal.Text = "Исходный файл";
            // 
            // lblEncDec
            // 
            this.lblEncDec.AutoSize = true;
            this.lblEncDec.Location = new System.Drawing.Point(13, 325);
            this.lblEncDec.Name = "lblEncDec";
            this.lblEncDec.Size = new System.Drawing.Size(216, 13);
            this.lblEncDec.TabIndex = 12;
            this.lblEncDec.Text = "Зашифрованный/расшифрованный файл";
            // 
            // lblStartReg
            // 
            this.lblStartReg.AutoSize = true;
            this.lblStartReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartReg.Location = new System.Drawing.Point(12, 38);
            this.lblStartReg.Name = "lblStartReg";
            this.lblStartReg.Size = new System.Drawing.Size(250, 20);
            this.lblStartReg.TabIndex = 13;
            this.lblStartReg.Text = "Начальное состояние регистра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStartReg);
            this.Controls.Add(this.lblEncDec);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblKeyStream);
            this.Controls.Add(this.lblPolyndrome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbEncDec);
            this.Controls.Add(this.tbOriginal);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnEncDec);
            this.Controls.Add(this.tbStartRegister);
            this.Controls.Add(this.tbPolyndrome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPolyndrome;
        private System.Windows.Forms.TextBox tbStartRegister;
        private System.Windows.Forms.Button btnEncDec;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.TextBox tbEncDec;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPolyndrome;
        private System.Windows.Forms.Label lblKeyStream;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblEncDec;
        private System.Windows.Forms.Label lblStartReg;
    }
}

