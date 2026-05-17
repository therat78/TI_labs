using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TI_lab1;

namespace TI_lab1
{
    public partial class VigenereForm : Form
    {
        private bool encryptMode = true;
        private const int MaxVisualizationLength = 100;

        public VigenereForm()
        {
            InitializeComponent();
            rbtnEncrypt.Checked = true;
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void VigenereForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuForm)
                {
                    form.Show();
                    break;
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FilterIndex = 1
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtInput.Text = File.ReadAllText(dlg.FileName, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка");
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (txtOutput.TextLength == 0)
            {
                MessageBox.Show("Нет данных для сохранения!", "Ошибка");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FilterIndex = 1
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(dlg.FileName, txtOutput.Text, Encoding.UTF8);
                    MessageBox.Show("Файл успешно сохранен!", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка");
                }
            }
        }

        private void UpdateButtons()
        {
            btnExecute.Enabled = txtInput.TextLength > 0 && txtKey.TextLength > 0;
            btnSaveFile.Enabled = txtOutput.TextLength > 0;

            dgvVisualization.Rows.Clear();
            dgvVisualization.Columns.Clear();
            lbText.Visible = false;
            lbKey2.Visible = false;
            lbResult.Visible = false;
        }

        private void InputChanged(object sender, EventArgs e)
        {
            txtOutput.Clear();
            UpdateButtons();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtKey.Clear();
            dgvVisualization.Rows.Clear();
            dgvVisualization.Columns.Clear();
            rbtnEncrypt.Checked = true;
            lbText.Visible = false;
            lbKey2.Visible = false;
            lbResult.Visible = false;
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = char.ToUpper(e.KeyChar);
            if (!char.IsControl(c) && !Constants.RussianAlphabet.Contains(c))
                e.Handled = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text;
            string key = txtKey.Text;

            string result;

            if (encryptMode)
            {
                result = VigenereCipher.Encrypt(inputText, key);
            }
            else
            {
                result = VigenereCipher.Decrypt(inputText, key);
            }

            txtOutput.Text = result;
            UpdateButtons();

            string textForVisualization = inputText;
            if (textForVisualization.Length > MaxVisualizationLength)
                textForVisualization = textForVisualization.Substring(0, MaxVisualizationLength);

            VisualizeVigenere(textForVisualization, key, encryptMode);
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = rbtnEncrypt.Checked;
            txtOutput.Clear();
        }

        private void rbtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = rbtnEncrypt.Checked;
            txtOutput.Clear();
        }

        private void VisualizeVigenere(string text, string key, bool encrypt)
        {
            text = text.ToUpper();
            key = new string(key.ToUpper().Where(c => Constants.RussianAlphabet.Contains(c)).ToArray());

            lbText.Visible = true;
            lbKey2.Visible = true;
            lbResult.Visible = true;

            dgvVisualization.Columns.Clear();
            dgvVisualization.Rows.Clear();

            List<int> letterIndices = new List<int>();
            for (int i = 0; i < text.Length; i++)
                if (Constants.RussianAlphabet.Contains(text[i]))
                    letterIndices.Add(i);

            if (letterIndices.Count == 0)
                return;

            foreach (int _ in letterIndices)
            {
                dgvVisualization.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Width = 35,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }

            dgvVisualization.Rows.Add(3);

            int keyIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (!Constants.RussianAlphabet.Contains(c))
                    continue;

                char kChar = key[keyIndex % key.Length];
                int ci = Constants.RussianAlphabet.IndexOf(c);
                int ki = Constants.RussianAlphabet.IndexOf(kChar);
                char resultChar;

                if (encrypt)
                {
                    resultChar = Constants.RussianAlphabet[(ci + ki) % Constants.RussianAlphabet.Length];
                    dgvVisualization.Rows[0].Cells[colIndex].Value = c.ToString();
                    dgvVisualization.Rows[2].Cells[colIndex].Value = resultChar.ToString();
                }
                else
                {
                    resultChar = Constants.RussianAlphabet[(ci - ki + Constants.RussianAlphabet.Length) % Constants.RussianAlphabet.Length];
                    dgvVisualization.Rows[0].Cells[colIndex].Value = resultChar.ToString();
                    dgvVisualization.Rows[2].Cells[colIndex].Value = c.ToString();
                }

                dgvVisualization.Rows[1].Cells[colIndex].Value = kChar.ToString();
                keyIndex++;
                colIndex++;
            }

            dgvVisualization.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVisualization.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvVisualization.ScrollBars = ScrollBars.Horizontal;
        }
    }
}