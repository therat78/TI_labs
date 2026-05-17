using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TI_lab1;

namespace TI_lab1
{
    public partial class RailFenceForm : Form
    {
        private bool encryptMode = true;
        private const int MaxVisualizationLength = 50;

        public RailFenceForm()
        {
            InitializeComponent();
            rbtnEncrypt.Checked = true;
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void RailFenceForm_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtKey.Text, out int rails) || rails < 1)
            {
                MessageBox.Show("Введите количество рельсов >= 1", "Ошибка");
                return;
            }

            string inputText = txtInput.Text;

            string result;
            if (encryptMode)
                result = RailFenceCipher.Encrypt(inputText, rails);
            else
                result = RailFenceCipher.Decrypt(inputText, rails);

            txtOutput.Text = result;
            UpdateButtons();

            string textForVis = inputText.Length > MaxVisualizationLength
                ? inputText.Substring(0, MaxVisualizationLength)
                : inputText;

            VisualizeRailFence(textForVis, rails);
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = rbtnEncrypt.Checked;
            txtOutput.Clear();
        }

        private void VisualizeRailFence(string text, int rails)
        {
            dgvVisualization.Columns.Clear();
            dgvVisualization.Rows.Clear();

            if (rails == 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    dgvVisualization.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Width = 35,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    });
                }

                dgvVisualization.Rows.Add();

                for (int i = 0; i < text.Length; i++)
                {
                    dgvVisualization.Rows[0].Cells[i].Value = text[i].ToString();
                }

                dgvVisualization.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvVisualization.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvVisualization.ScrollBars = ScrollBars.Horizontal;
                return;
            }

            for (int i = 0; i < text.Length; i++)
            {
                dgvVisualization.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Width = 35,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }

            for (int i = 0; i < rails; i++)
                dgvVisualization.Rows.Add();

            List<int> letterPositions = new List<int>();
            List<char> letters = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (char.IsLetter(c) && ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    letterPositions.Add(i);
                    letters.Add(char.ToUpper(c));
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (letterPositions.Contains(i))
                {
                    dgvVisualization.Rows[0].Cells[i].Value = "";
                }
                else
                {
                    dgvVisualization.Rows[0].Cells[i].Value = text[i].ToString();
                }
            }

            int rail = 0;
            int direction = 1;

            for (int i = 0; i < letters.Count; i++)
            {
                int originalPos = letterPositions[i];
                dgvVisualization.Rows[rail].Cells[originalPos].Value = letters[i].ToString();
                rail += direction;

                if (rail == 0 || rail == rails - 1)
                    direction = -direction;
            }

            dgvVisualization.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVisualization.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvVisualization.ScrollBars = ScrollBars.Both;
        }
    }
}