namespace TI_lab3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.btnFindRoots = new System.Windows.Forms.Button();
            this.lblG = new System.Windows.Forms.Label();
            this.cbG = new System.Windows.Forms.ComboBox();
            this.lblX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lblK = new System.Windows.Forms.Label();
            this.tbK = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblEncryptedContent = new System.Windows.Forms.Label();
            this.tbEncryptedOutput = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblRoots = new System.Windows.Forms.Label();
            this.tbRoots = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(16, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(121, 32);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilePath.Location = new System.Drawing.Point(143, 23);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(122, 16);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "Файл не выбран...";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblP.Location = new System.Drawing.Point(13, 68);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(125, 16);
            this.lblP.TabIndex = 2;
            this.lblP.Text = "p (простое число):";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(139, 67);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(121, 20);
            this.tbP.TabIndex = 3;
            this.tbP.TextChanged += new System.EventHandler(this.Parameters_TextChanged);
            this.tbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_KeyPress);
            // 
            // btnFindRoots
            // 
            this.btnFindRoots.Location = new System.Drawing.Point(266, 62);
            this.btnFindRoots.Name = "btnFindRoots";
            this.btnFindRoots.Size = new System.Drawing.Size(185, 28);
            this.btnFindRoots.TabIndex = 4;
            this.btnFindRoots.Text = "Найти первообразные корни";
            this.btnFindRoots.UseVisualStyleBackColor = true;
            this.btnFindRoots.Click += new System.EventHandler(this.btnFindRoots_Click);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(13, 178);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(107, 13);
            this.lblG.TabIndex = 5;
            this.lblG.Text = "g (выбрать корень):";
            // 
            // cbG
            // 
            this.cbG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbG.FormattingEnabled = true;
            this.cbG.Location = new System.Drawing.Point(146, 177);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(121, 21);
            this.cbG.TabIndex = 6;
            this.cbG.SelectedIndexChanged += new System.EventHandler(this.Parameters_TextChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.Location = new System.Drawing.Point(13, 212);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(127, 16);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "x (закрытый ключ):";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(146, 211);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(121, 20);
            this.tbX.TabIndex = 8;
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_KeyPress);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.Location = new System.Drawing.Point(280, 178);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(127, 16);
            this.lblY.TabIndex = 18;
            this.lblY.Text = "y (открытый ключ):";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(413, 178);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(150, 20);
            this.tbY.TabIndex = 19;
            this.tbY.TabStop = false;
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblK.Location = new System.Drawing.Point(13, 245);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(135, 16);
            this.lblK.TabIndex = 9;
            this.lblK.Text = "k (сеансовый ключ):";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(146, 244);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(121, 20);
            this.tbK.TabIndex = 10;
            this.tbK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigits_KeyPress);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.Location = new System.Drawing.Point(16, 287);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(149, 40);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrypt.Location = new System.Drawing.Point(171, 287);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(149, 40);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblEncryptedContent
            // 
            this.lblEncryptedContent.AutoSize = true;
            this.lblEncryptedContent.Location = new System.Drawing.Point(13, 344);
            this.lblEncryptedContent.Name = "lblEncryptedContent";
            this.lblEncryptedContent.Size = new System.Drawing.Size(110, 13);
            this.lblEncryptedContent.TabIndex = 13;
            this.lblEncryptedContent.Text = "Содержимое файла:";
            // 
            // tbEncryptedOutput
            // 
            this.tbEncryptedOutput.Location = new System.Drawing.Point(16, 360);
            this.tbEncryptedOutput.Multiline = true;
            this.tbEncryptedOutput.Name = "tbEncryptedOutput";
            this.tbEncryptedOutput.ReadOnly = true;
            this.tbEncryptedOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEncryptedOutput.Size = new System.Drawing.Size(772, 85);
            this.tbEncryptedOutput.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(13, 461);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 16);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Статус:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblRoots
            // 
            this.lblRoots.AutoSize = true;
            this.lblRoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblRoots.Location = new System.Drawing.Point(13, 102);
            this.lblRoots.Name = "lblRoots";
            this.lblRoots.Size = new System.Drawing.Size(164, 16);
            this.lblRoots.TabIndex = 16;
            this.lblRoots.Text = "Найденные корни для g:";
            // 
            // tbRoots
            // 
            this.tbRoots.Location = new System.Drawing.Point(16, 121);
            this.tbRoots.Multiline = true;
            this.tbRoots.Name = "tbRoots";
            this.tbRoots.ReadOnly = true;
            this.tbRoots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRoots.Size = new System.Drawing.Size(772, 47);
            this.tbRoots.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.tbRoots);
            this.Controls.Add(this.lblRoots);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbEncryptedOutput);
            this.Controls.Add(this.lblEncryptedContent);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.cbG);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.btnFindRoots);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Button btnFindRoots;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.ComboBox cbG;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblEncryptedContent;
        private System.Windows.Forms.TextBox tbEncryptedOutput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblRoots;
        private System.Windows.Forms.TextBox tbRoots;
    }
}