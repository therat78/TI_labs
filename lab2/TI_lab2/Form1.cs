using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_lab2
{
    public partial class Form1 : Form
    {
        public const int START_REG_LENGTH = 25;
        string currentFilePath;

        private string startRegister;
        Algorithms alg = new Algorithms(START_REG_LENGTH);
        public Form1()
        {
            InitializeComponent();
            tbStartRegister.MaxLength = START_REG_LENGTH;
            btnEncDec.Enabled = false;
        }

        private void tbStartRegister_KeyPress(object sender, KeyPressEventArgs e)
        {
            startRegister = tbStartRegister.Text;
            if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbStartRegister_TextChanged(object sender, EventArgs e)
        {
            foreach (char ch in tbStartRegister.Text)
            {
                if (ch != '0' && ch != '1')
                {
                    tbStartRegister.Text = startRegister;
                    tbStartRegister.SelectionStart = startRegister.Length;
                    break;
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл для шифрования/дешифрования";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                lblFilePath.Text = $"Файл: {Path.GetFileName(currentFilePath)}";
                btnEncDec.Enabled = true;

                try
                {
                    alg.originalData = File.ReadAllBytes(currentFilePath);
                    tbOriginal.Text = alg.GetBinaryPreview(alg.originalData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEncDec_Click(object sender, EventArgs e)
        {
            try
            {
                string initialState = tbStartRegister.Text.Trim();
                if (initialState.Length != START_REG_LENGTH)
                {
                    MessageBox.Show($"Начальное состояние должно содержать ровно {START_REG_LENGTH} бит!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(initialState, "^[01]+$"))
                {
                    MessageBox.Show("Начальное состояние может содержать только 0 и 1!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                alg.GetStartReg(tbStartRegister.Text);
                tbKey.Text = alg.GetBinaryPreview(alg.GenKeyStream());

                alg.encryptedData = alg.EncryptDecryptData();

                tbEncDec.Text = alg.GetBinaryPreview(alg.encryptedData);

                saveFileDialog.Filter = "All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить зашифрованный файл";
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(currentFilePath) + "_enc" + Path.GetExtension(currentFilePath);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, alg.encryptedData);
                    lblStatus.Text = $"Файл успешно зашифрован и сохранен как: {Path.GetFileName(saveFileDialog.FileName)}";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при шифровании: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Ошибка: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
