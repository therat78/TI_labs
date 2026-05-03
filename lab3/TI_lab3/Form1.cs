using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace TI_lab3
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        private byte[] fileBytes;
        private readonly Algorithms algorithm = new Algorithms();

        public Form1()
        {
            InitializeComponent();
            UpdateControlsState(false);
        }

        private void UpdateControlsState(bool fileSelected)
        {
            btnEncrypt.Enabled = fileSelected && cbG.Items.Count > 0;
            btnDecrypt.Enabled = fileSelected && cbG.Items.Count > 0;
            btnFindRoots.Enabled = fileSelected;
            tbP.Enabled = fileSelected;
            tbK.Enabled = fileSelected;
            tbX.Enabled = fileSelected;
            cbG.Enabled = fileSelected;
        }
        
        private void ResetData()
        {
            tbP.Text = "";
            tbX.Text = "";
            tbK.Text = "";
            tbY.Text = "";
            tbRoots.Text = "";
            tbEncryptedOutput.Text = "";
            cbG.Items.Clear(); 
        }

        private void OnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                lblFilePath.Text = Path.GetFileName(currentFilePath);
                try
                {
                    fileBytes = File.ReadAllBytes(currentFilePath);

                    try
                    {
                        tbEncryptedOutput.Text = File.ReadAllText(currentFilePath);
                    }
                    catch
                    {
                        tbEncryptedOutput.Text = "[Невозможно отобразить содержимое файла как текст]";
                    }

                    lblStatus.Text = $"Статус: Файл '{lblFilePath.Text}' загружен.";
                    lblStatus.ForeColor = System.Drawing.Color.Blue;
                    UpdateControlsState(true);
                    ResetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fileBytes = null;
                    UpdateControlsState(false);
                }
            }
        }

        private void btnFindRoots_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(tbP.Text, out BigInteger p))
            {
                MessageBox.Show("Пожалуйста, введите корректное число p.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!algorithm.IsPrime(p))
            {
                MessageBox.Show("Число p должно быть простым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStatus.Text = "Статус: Идет поиск первообразных корней...";
            this.Update();

            List<BigInteger> roots = algorithm.FindAllPrimitiveRoots(p);

            if (roots.Count == 0)
            {
                MessageBox.Show("Для данного p не найдено первообразных корней.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "Статус: Корни не найдены.";
                return;
            }

            tbRoots.Text = string.Join(", ", roots);
            cbG.Items.Clear();
            foreach (var root in roots)
            {
                cbG.Items.Add(root.ToString());
            }
            cbG.SelectedIndex = 0;

            lblStatus.Text = $"Статус: Найдено {roots.Count} корней";
            lblStatus.ForeColor = System.Drawing.Color.Green;
            UpdateControlsState(fileBytes != null);
        }

        private void CalculateAndDisplayY()
        {
            if (BigInteger.TryParse(tbP.Text, out BigInteger p) &&
                cbG.SelectedItem != null && BigInteger.TryParse(cbG.SelectedItem.ToString(), out BigInteger g) &&
                BigInteger.TryParse(tbX.Text, out BigInteger x))
            {
                if (p > 1 && x > 0 && x < p)
                {
                    try
                    {
                        BigInteger y = Algorithms.ModPow(g, x, p);
                        tbY.Text = y.ToString();
                    }
                    catch
                    {
                        tbY.Text = "";
                    }
                }
                else
                {
                    tbY.Text = "";
                }
            }
            else
            {
                tbY.Text = "";
            }
        }

        private void Parameters_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayY();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (fileBytes == null)
            {
                MessageBox.Show("Сначала выберите файл для шифрования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!BigInteger.TryParse(tbP.Text, out BigInteger p) ||
                !BigInteger.TryParse(cbG.SelectedItem.ToString(), out BigInteger g) ||
                !BigInteger.TryParse(tbX.Text, out BigInteger x) ||
                !BigInteger.TryParse(tbK.Text, out BigInteger k))
            {
                MessageBox.Show("Пожалуйста, заполните все параметры (p, g, x, k) корректными числами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(x > 1 && x < p - 1))
            {
                MessageBox.Show("Параметр x должен быть в диапазоне 1 < x < p-1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(k > 1 && k < p - 1))
            {
                MessageBox.Show("Параметр k должен быть в диапазоне 1 < k < p-1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Algorithms.Gcd(k, p - 1, out _, out _) != 1)
            {
                MessageBox.Show("Параметр k должен быть взаимно простым с p-1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (p <= 255)
            {
                DialogResult res = MessageBox.Show("Чтобы избежать потери данных, значение p должно быть больше 255.", "Критическое предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                lblStatus.Text = "Статус: Выполняется шифрование...";
                this.Update();

                BigInteger y = Algorithms.ModPow(g, x, p);
                tbY.Text = y.ToString();
                List<BigInteger> encryptedData = algorithm.Encrypt(fileBytes, p, g, y, k);

                tbEncryptedOutput.Text = string.Join(" ", encryptedData);

                saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Сохранить зашифрованный файл";
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(currentFilePath) + "_encrypted.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, tbEncryptedOutput.Text);
                    lblStatus.Text = $"Статус: Файл успешно зашифрован и сохранен как {Path.GetFileName(saveFileDialog.FileName)}.";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при шифровании: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Статус: Ошибка шифрования.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (fileBytes == null)
            {
                MessageBox.Show("Сначала выберите зашифрованный файл с помощью кнопки 'Открыть файл'.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!BigInteger.TryParse(tbP.Text, out BigInteger p) ||
                !BigInteger.TryParse(tbX.Text, out BigInteger x))
            {
                MessageBox.Show("Для расшифровки необходимы корректные параметры p и x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(x > 1 && x < p - 1))
            {
                MessageBox.Show("Параметр x должен быть в диапазоне 1 < x < p-1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (p <= 255)
            {
                MessageBox.Show("Чтобы избежать потери данных, значение p должно быть больше 255.", "Критическое предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string encryptedText = System.Text.Encoding.UTF8.GetString(fileBytes);
                List<BigInteger> encryptedData = encryptedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                              .Select(BigInteger.Parse)
                                                              .ToList();

                tbEncryptedOutput.Text = encryptedText;

                lblStatus.Text = "Статус: Выполняется расшифровка...";
                this.Update();

                byte[] decryptedBytes = algorithm.Decrypt(encryptedData, p, x);

                saveFileDialog.Filter = "Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Сохранить расшифрованный файл";

                string fileName = Path.GetFileNameWithoutExtension(currentFilePath);
                string originalName = fileName.Replace("_encrypted", "");
                string originalExtension = Path.GetExtension(originalName);
                if (string.IsNullOrEmpty(originalExtension))
                {
                    originalName = "decrypted_" + originalName;
                }

                saveFileDialog.FileName = originalName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, decryptedBytes);
                    lblStatus.Text = $"Статус: Файл успешно расшифрован и сохранен как {Path.GetFileName(saveFileDialog.FileName)}.";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Выбранный файл не является корректным зашифрованным файлом. Он должен содержать числа, разделенные пробелами.", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Статус: Ошибка формата файла.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при расшифровке: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = $"Статус: Ошибка расшифровки.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}