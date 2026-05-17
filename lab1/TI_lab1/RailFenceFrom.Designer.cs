namespace TI_lab1
{
    partial class RailFenceForm
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

        private void InitializeComponent()
        {
            this.LbLabName = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.lblnput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVisualization = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualization)).BeginInit();
            this.SuspendLayout();
            // 
            // LbLabName
            // 
            this.LbLabName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbLabName.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold);
            this.LbLabName.Location = new System.Drawing.Point(0, 24);
            this.LbLabName.Name = "LbLabName";
            this.LbLabName.Size = new System.Drawing.Size(780, 70);
            this.LbLabName.TabIndex = 27;
            this.LbLabName.Text = "Железнодорожная изгородь";
            this.LbLabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(321, 285);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 59);
            this.btnExecute.TabIndex = 20;
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rbtnDecrypt
            // 
            this.rbtnDecrypt.AutoSize = true;
            this.rbtnDecrypt.Location = new System.Drawing.Point(352, 240);
            this.rbtnDecrypt.Name = "rbtnDecrypt";
            this.rbtnDecrypt.Size = new System.Drawing.Size(101, 17);
            this.rbtnDecrypt.TabIndex = 19;
            this.rbtnDecrypt.Text = "Расшифровать";
            this.rbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbtnEncrypt
            // 
            this.rbtnEncrypt.AutoSize = true;
            this.rbtnEncrypt.Checked = true;
            this.rbtnEncrypt.Location = new System.Drawing.Point(352, 207);
            this.rbtnEncrypt.Name = "rbtnEncrypt";
            this.rbtnEncrypt.Size = new System.Drawing.Size(95, 17);
            this.rbtnEncrypt.TabIndex = 17;
            this.rbtnEncrypt.TabStop = true;
            this.rbtnEncrypt.Text = "Зашифровать";
            this.rbtnEncrypt.UseVisualStyleBackColor = true;
            this.rbtnEncrypt.CheckedChanged += new System.EventHandler(this.rbtnEncrypt_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(598, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 59);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(56, 285);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 59);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(390, 119);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(33, 13);
            this.lbKey.TabIndex = 22;
            this.lbKey.Text = "Ключ";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(342, 149);
            this.txtKey.MaxLength = 2;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(120, 20);
            this.txtKey.TabIndex = 14;
            this.txtKey.TextChanged += new System.EventHandler(this.InputChanged);
            this.txtKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKey_KeyPress);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(584, 119);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(62, 13);
            this.lbOutput.TabIndex = 18;
            this.lbOutput.Text = "Результат:";
            // 
            // lblnput
            // 
            this.lblnput.AutoSize = true;
            this.lblnput.Location = new System.Drawing.Point(70, 119);
            this.lblnput.Name = "lblnput";
            this.lblnput.Size = new System.Drawing.Size(92, 13);
            this.lblnput.TabIndex = 16;
            this.lblnput.Text = "Исходный текст:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(586, 149);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(187, 108);
            this.txtOutput.TabIndex = 25;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(24, 149);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(210, 108);
            this.txtInput.TabIndex = 13;
            this.txtInput.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 26;
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.btnSaveFile});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(48, 20);
            this.btnFile.Text = "Файл";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenFile.Size = new System.Drawing.Size(173, 22);
            this.btnOpenFile.Text = "Открыть";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveFile.Size = new System.Drawing.Size(173, 22);
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // dgvVisualization
            // 
            this.dgvVisualization.AllowUserToAddRows = false;
            this.dgvVisualization.AllowUserToDeleteRows = false;
            this.dgvVisualization.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvVisualization.ColumnHeadersHeight = 60;
            this.dgvVisualization.ColumnHeadersVisible = false;
            this.dgvVisualization.Location = new System.Drawing.Point(24, 370);
            this.dgvVisualization.Name = "dgvVisualization";
            this.dgvVisualization.ReadOnly = true;
            this.dgvVisualization.RowHeadersVisible = false;
            this.dgvVisualization.RowHeadersWidth = 62;
            this.dgvVisualization.Size = new System.Drawing.Size(749, 223);
            this.dgvVisualization.TabIndex = 28;
            // 
            // RailFenceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(780, 607);
            this.Controls.Add(this.dgvVisualization);
            this.Controls.Add(this.LbLabName);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.rbtnDecrypt);
            this.Controls.Add(this.rbtnEncrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblnput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RailFenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Железнодорожная изгородь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RailFenceForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LbLabName;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RadioButton rbtnDecrypt;
        private System.Windows.Forms.RadioButton rbtnEncrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label lblnput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.DataGridView dgvVisualization;
    }
}