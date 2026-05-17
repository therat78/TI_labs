using System;
using System.Windows.Forms;

namespace TI_lab1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnRailFence_Click(object sender, EventArgs e)
        {
            RailFenceForm form = new RailFenceForm();
            form.Show();
            this.Hide();
        }

        private void BtnVigenere_Click(object sender, EventArgs e)
        {
            VigenereForm form = new VigenereForm();
            form.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAboutDeveloper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа шифрования текста\nВерсия 1.0\n2024",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAboutTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шифрование текстовых файлов:\n\n" +
                "1. Железнодорожная изгородь (английский)\n" +
                "2. Шифр Виженера (русский)\n\n" +
                "Программа поддерживает работу с файлами и ввод текста вручную.",
                "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}