namespace TI_lab1
{
    partial class MenuForm
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
            this.BtnRailFence = new System.Windows.Forms.Button();
            this.BtnVigenere = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRailFence
            // 
            this.BtnRailFence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRailFence.Location = new System.Drawing.Point(172, 82);
            this.BtnRailFence.Name = "BtnRailFence";
            this.BtnRailFence.Size = new System.Drawing.Size(174, 57);
            this.BtnRailFence.TabIndex = 1;
            this.BtnRailFence.Text = "Железнодорожная изгородь";
            this.BtnRailFence.UseVisualStyleBackColor = true;
            this.BtnRailFence.Click += new System.EventHandler(this.BtnRailFence_Click);
            // 
            // BtnVigenere
            // 
            this.BtnVigenere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVigenere.Location = new System.Drawing.Point(172, 169);
            this.BtnVigenere.Name = "BtnVigenere";
            this.BtnVigenere.Size = new System.Drawing.Size(174, 68);
            this.BtnVigenere.TabIndex = 2;
            this.BtnVigenere.Text = "Алгоритм Виженера";
            this.BtnVigenere.UseVisualStyleBackColor = true;
            this.BtnVigenere.Click += new System.EventHandler(this.BtnVigenere_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(172, 259);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(174, 59);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.BtnRailFence);
            this.Controls.Add(this.BtnVigenere);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование текста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BtnRailFence;
        private System.Windows.Forms.Button BtnVigenere;
        private System.Windows.Forms.Button BtnExit;
    }
}