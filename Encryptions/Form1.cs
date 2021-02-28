using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm;

namespace Encryption
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void aboutProgramStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encryption - программа для зашифровывания и расшифровывания сообщений. Версия программы: 0.4 build 6", "О программе", MessageBoxButtons.OK);
        }



        private void onEncryptingSettingsChanged()
        {
            statusLabel.Text = "Ожидание...";
            statusProgressbar.Value = 0;
            encryptingSettingsBlocksNum.Enabled = true;
            encryptingSettingsBlocksNum.Maximum = Math.Max(encryptingTextTextbox.TextLength, 2);
            encryptingSettingsRoundsNum.Enabled = true;

            switch (encryptingTypeCombobox.SelectedIndex)
            {
                case -1:
                    encryptingSettingsRoundsNum.Maximum = 1;
                    break;
                case 0:
                    encryptingSettingsRoundsNum.Maximum = 1;
                    encryptingSettingsRoundsNum.Enabled = false;
                    encryptingSettingsBlocksNum.Maximum = 1;
                    encryptingSettingsBlocksNum.Enabled = false;
                    break;
                case 1:
                    encryptingSettingsRoundsNum.Maximum = encryptingSettingsBlocksNum.Value;
                    break;
                case 2:
                    encryptingSettingsRoundsNum.Maximum = 1024;
                    encryptingSettingsBlocksNum.Maximum = encryptingTextTextbox.TextLength / 16 + 1;
                    encryptingSettingsBlocksNum.Value = encryptingTextTextbox.TextLength / 16 + 1;
                    encryptingSettingsBlocksNum.Enabled = false;
                    break;
            }
        }

        private void encryptingTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            onEncryptingSettingsChanged();
        }

        private void encryptingSettingsRoundsNum_ValueChanged(object sender, EventArgs e)
        {
            onEncryptingSettingsChanged();
        }

        private void encryptingSettingsBlocksNum_ValueChanged(object sender, EventArgs e)
        {
            onEncryptingSettingsChanged();
        }

        private void encryptingTextTexbox_TextChanged(object sender, EventArgs e)
        {
            onEncryptingSettingsChanged();
        }

        private void encryptingKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            onEncryptingSettingsChanged();
        }

        private void encryptingButton_Click(object sender, EventArgs e)
        {
            statusProgressbar.Value = 0;
            if (encryptingTypeCombobox.SelectedIndex == -1)
            {
                statusLabel.Text = "Выберите способ шифрования";
                return;
            }
            if (encryptingTextTextbox.TextLength == 0)
            {
                statusLabel.Text = "Введите текст для шифрования";
                return;
            }
            if (encryptingTextTextbox.TextLength < 2)
            {
                statusLabel.Text = "Слишком короткий текст";
                return;
            }
            if (encryptingKeyTextbox.TextLength == 0)
            {
                statusLabel.Text = "Введите ключ для шифрования";
                return;
            }
            statusProgressbar.Maximum = Convert.ToInt32(encryptingSettingsRoundsNum.Value);
            string result = encryptingTextTextbox.Text;
            for (int i = 1; i <= Convert.ToInt32(encryptingSettingsRoundsNum.Value); ++i)
            {
                statusLabel.Text = "Выполняется шифровка, раунд " + Convert.ToString(i) + "/" + Convert.ToString(encryptingSettingsBlocksNum.Value);
                Update();
                switch (encryptingTypeCombobox.SelectedIndex)
                {
                    case 0:
                        result = Main.Program.TextXOR(result, encryptingKeyTextbox.Text);
                        break;
                    case 1:
                        result = Feistel.Encrypting(result, encryptingKeyTextbox.Text, Convert.ToInt32(encryptingSettingsBlocksNum.Value));
                        break;
                }
                ++statusProgressbar.Value;
                encryptingResultTextbox.Text = result;
            }
            statusLabel.Text = "Текст успешно зашифрован";
            return;
        }



        private void onDecryptingSettingsChanged()
        {
            statusLabel.Text = "Ожидание...";
            statusProgressbar.Value = 0;
            decryptingSettingsBlocksNum.Enabled = true;
            decryptingSettingsBlocksNum.Maximum = Math.Max(decryptingTextTextbox.TextLength, 2);
            decryptingSettingsRoundsNum.Enabled = true;

            switch (decryptingTypeCombobox.SelectedIndex)
            {
                case -1:
                    decryptingSettingsRoundsNum.Maximum = 1;
                    break;
                case 0:
                    decryptingSettingsRoundsNum.Maximum = 1;
                    decryptingSettingsRoundsNum.Enabled = false;
                    decryptingSettingsBlocksNum.Maximum = 1;
                    decryptingSettingsBlocksNum.Enabled = false;
                    break;
                case 1:
                    decryptingSettingsRoundsNum.Maximum = decryptingSettingsBlocksNum.Value;
                    break;
                case 2:
                    decryptingSettingsRoundsNum.Maximum = 1024;
                    decryptingSettingsBlocksNum.Maximum = encryptingTextTextbox.TextLength / 16 + 1;
                    decryptingSettingsBlocksNum.Value = encryptingTextTextbox.TextLength / 16 + 1;
                    decryptingSettingsBlocksNum.Enabled = false;
                    break;
            }
        }

        private void decryptingTextTextbox_TextChanged(object sender, EventArgs e)
        {
            onDecryptingSettingsChanged();
        }

        private void decryptingTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            onDecryptingSettingsChanged();
        }

        private void decryptingSettingsKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            onDecryptingSettingsChanged();
        }

        private void decryptingSettingsBlocksNum_ValueChanged(object sender, EventArgs e)
        {
            onDecryptingSettingsChanged();
        }

        private void decryptingSettingsRoundsNum_ValueChanged(object sender, EventArgs e)
        {
            onDecryptingSettingsChanged();
        }

        private void decryptingButton_Click(object sender, EventArgs e)
        {
            statusProgressbar.Value = 0;
            if (decryptingTypeCombobox.SelectedIndex == -1)
            {
                statusLabel.Text = "Выберите способ шифрования";
                return;
            }
            if (decryptingTextTextbox.TextLength == 0)
            {
                statusLabel.Text = "Введите текст для расшифрования";
                return;
            }
            if (decryptingKeyTextbox.TextLength == 0)
            {
                statusLabel.Text = "Введите ключ для расшифрования";
                return;
            }
            statusProgressbar.Maximum = Convert.ToInt32(decryptingSettingsRoundsNum.Value);
            string result = decryptingTextTextbox.Text;
            for (int i = 1; i <= Convert.ToInt32(decryptingSettingsRoundsNum.Value); ++i)
            {
                statusLabel.Text = "Выполняется расшифровка, раунд " + Convert.ToString(i) + "/" + Convert.ToString(decryptingSettingsBlocksNum.Value);
                Update();
                switch (decryptingTypeCombobox.SelectedIndex)
                {
                    case 0:
                        result = Main.Program.TextXOR(result, decryptingKeyTextbox.Text);
                        break;
                    case 1:
                        result = Feistel.Decrypting(result, decryptingKeyTextbox.Text, Convert.ToInt32(decryptingSettingsBlocksNum.Value));
                        break;
                }
                ++statusProgressbar.Value;
                decryptingResultTextbox.Text = result;
            }
            statusLabel.Text = "Текст успешно расшифрован";
            return;
        }
    }
}
