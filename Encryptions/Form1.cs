using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions;

namespace Encryptions
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusProgressbar_Click(object sender, EventArgs e)
        {

        }

        private void encryptingTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel.Text = "Ожидание...";
            statusProgressbar.Value = 0;
        }

        private void changeThemeStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encryptingSettingsRoundsNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void encryptingSettingsRoundsLabel_Click(object sender, EventArgs e)
        {

        }

        private void encryptingButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Шифрование...";
            statusProgressbar.Value = 0;
            if (encryptingTypeCombobox.SelectedIndex == -1)
            {
                statusLabel.Text = "Выберите способ шифрования";
                return;
            }
            if (encryptingTextTexbox.TextLength == 0)
            {
                statusLabel.Text = "Введите текст для шифрования";
                return;
            }
            if (encryptingKeyTextbox.TextLength == 0)
            {
                statusLabel.Text = "Введите ключ для шифрования";
                return;
            }
            statusProgressbar.Maximum = Convert.ToInt32(encryptingSettingsRoundsNum.Value);
            string result = encryptingTextTexbox.Text;
            for (int i = 0; i < Convert.ToInt32(encryptingSettingsRoundsNum.Value); ++i)
            {
                switch (encryptingTypeCombobox.SelectedIndex)
                {
                    case 0:
                        statusLabel.Text = "Этот способ пока не реализован";
                        break;
                    case 1:
                        statusLabel.Text = "Этот способ пока не реализован";
                        break;
                    case 2:
                        result = Functions.Encrypting.Feistel(result, encryptingKeyTextbox.Text, Convert.ToInt32(encryptingSettingsBlocksNum.Value));
                        ++statusProgressbar.Value;             //
                        statusLabel.Text = "Зашифровано!";     //эти части потом надо будет перенести за switch
                        encryptingResultTextbox.Text = result; //
                        break;
                }
            }
            return;
        }

        private void encryptingSettingsBlocksNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void encryptingTextTexbox_TextChanged(object sender, EventArgs e)
        {
            encryptingSettingsBlocksNum.Maximum = Math.Max(encryptingTextTexbox.TextLength / 2, 2);
        }
    }
}
