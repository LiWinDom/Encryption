
namespace Encryptions
{
    partial class mainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encryptingKeyTextbox = new System.Windows.Forms.TextBox();
            this.encryptingKeyLabel = new System.Windows.Forms.Label();
            this.encryptingButton = new System.Windows.Forms.Button();
            this.encryptingResultLabel = new System.Windows.Forms.Label();
            this.encryptingResultTextbox = new System.Windows.Forms.TextBox();
            this.encryptingSettingsRoundsLabel = new System.Windows.Forms.Label();
            this.encryptingSettingsRoundsNum = new System.Windows.Forms.NumericUpDown();
            this.encryptingSettingsBlocksLabel = new System.Windows.Forms.Label();
            this.encryptingSettingsLabel = new System.Windows.Forms.Label();
            this.encryptingSettingsBlocksNum = new System.Windows.Forms.NumericUpDown();
            this.encryptingTextLabel = new System.Windows.Forms.Label();
            this.encryptingTextTextbox = new System.Windows.Forms.TextBox();
            this.encryptingTypeCombobox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decryptingKeyTextbox = new System.Windows.Forms.TextBox();
            this.decryptingResultTextbox = new System.Windows.Forms.TextBox();
            this.decryptingKeyLabel = new System.Windows.Forms.Label();
            this.decryptingTypeCombobox = new System.Windows.Forms.ComboBox();
            this.decryptingButton = new System.Windows.Forms.Button();
            this.decryptingTextTextbox = new System.Windows.Forms.TextBox();
            this.decryptingResultLabel = new System.Windows.Forms.Label();
            this.decryptingTextLabel = new System.Windows.Forms.Label();
            this.decryptingSettingsBlocksNum = new System.Windows.Forms.NumericUpDown();
            this.decryptingSettingsRoundsLabel = new System.Windows.Forms.Label();
            this.decryptingSettingsLabel = new System.Windows.Forms.Label();
            this.decryptingSettingsRoundsNum = new System.Windows.Forms.NumericUpDown();
            this.decryptingSettingsBlocksLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutProgramStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusProgressbar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsRoundsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsBlocksNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptingSettingsBlocksNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptingSettingsRoundsNum)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(319, 236);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encryptingKeyTextbox);
            this.tabPage1.Controls.Add(this.encryptingKeyLabel);
            this.tabPage1.Controls.Add(this.encryptingButton);
            this.tabPage1.Controls.Add(this.encryptingResultLabel);
            this.tabPage1.Controls.Add(this.encryptingResultTextbox);
            this.tabPage1.Controls.Add(this.encryptingSettingsRoundsLabel);
            this.tabPage1.Controls.Add(this.encryptingSettingsRoundsNum);
            this.tabPage1.Controls.Add(this.encryptingSettingsBlocksLabel);
            this.tabPage1.Controls.Add(this.encryptingSettingsLabel);
            this.tabPage1.Controls.Add(this.encryptingSettingsBlocksNum);
            this.tabPage1.Controls.Add(this.encryptingTextLabel);
            this.tabPage1.Controls.Add(this.encryptingTextTextbox);
            this.tabPage1.Controls.Add(this.encryptingTypeCombobox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(311, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encryptingKeyTextbox
            // 
            this.encryptingKeyTextbox.Location = new System.Drawing.Point(115, 59);
            this.encryptingKeyTextbox.MaxLength = 127;
            this.encryptingKeyTextbox.Name = "encryptingKeyTextbox";
            this.encryptingKeyTextbox.Size = new System.Drawing.Size(190, 20);
            this.encryptingKeyTextbox.TabIndex = 12;
            this.encryptingKeyTextbox.TextChanged += new System.EventHandler(this.encryptingKeyTextbox_TextChanged);
            // 
            // encryptingKeyLabel
            // 
            this.encryptingKeyLabel.AutoSize = true;
            this.encryptingKeyLabel.Location = new System.Drawing.Point(6, 62);
            this.encryptingKeyLabel.Name = "encryptingKeyLabel";
            this.encryptingKeyLabel.Size = new System.Drawing.Size(103, 13);
            this.encryptingKeyLabel.TabIndex = 11;
            this.encryptingKeyLabel.Text = "Ключ шифрования:";
            // 
            // encryptingButton
            // 
            this.encryptingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.encryptingButton.Location = new System.Drawing.Point(6, 150);
            this.encryptingButton.Name = "encryptingButton";
            this.encryptingButton.Size = new System.Drawing.Size(299, 23);
            this.encryptingButton.TabIndex = 10;
            this.encryptingButton.Text = "Зашифровать";
            this.encryptingButton.UseVisualStyleBackColor = true;
            this.encryptingButton.Click += new System.EventHandler(this.encryptingButton_Click);
            // 
            // encryptingResultLabel
            // 
            this.encryptingResultLabel.AutoSize = true;
            this.encryptingResultLabel.Location = new System.Drawing.Point(6, 187);
            this.encryptingResultLabel.Name = "encryptingResultLabel";
            this.encryptingResultLabel.Size = new System.Drawing.Size(62, 13);
            this.encryptingResultLabel.TabIndex = 9;
            this.encryptingResultLabel.Text = "Результат:";
            // 
            // encryptingResultTextbox
            // 
            this.encryptingResultTextbox.Location = new System.Drawing.Point(74, 184);
            this.encryptingResultTextbox.MaxLength = 4095;
            this.encryptingResultTextbox.Name = "encryptingResultTextbox";
            this.encryptingResultTextbox.Size = new System.Drawing.Size(231, 20);
            this.encryptingResultTextbox.TabIndex = 8;
            // 
            // encryptingSettingsRoundsLabel
            // 
            this.encryptingSettingsRoundsLabel.AutoSize = true;
            this.encryptingSettingsRoundsLabel.Location = new System.Drawing.Point(35, 126);
            this.encryptingSettingsRoundsLabel.Name = "encryptingSettingsRoundsLabel";
            this.encryptingSettingsRoundsLabel.Size = new System.Drawing.Size(113, 13);
            this.encryptingSettingsRoundsLabel.TabIndex = 7;
            this.encryptingSettingsRoundsLabel.Text = "Количество раундов:";
            // 
            // encryptingSettingsRoundsNum
            // 
            this.encryptingSettingsRoundsNum.Location = new System.Drawing.Point(154, 124);
            this.encryptingSettingsRoundsNum.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.encryptingSettingsRoundsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.encryptingSettingsRoundsNum.Name = "encryptingSettingsRoundsNum";
            this.encryptingSettingsRoundsNum.Size = new System.Drawing.Size(48, 20);
            this.encryptingSettingsRoundsNum.TabIndex = 6;
            this.encryptingSettingsRoundsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.encryptingSettingsRoundsNum.ValueChanged += new System.EventHandler(this.encryptingSettingsRoundsNum_ValueChanged);
            // 
            // encryptingSettingsBlocksLabel
            // 
            this.encryptingSettingsBlocksLabel.AutoSize = true;
            this.encryptingSettingsBlocksLabel.Location = new System.Drawing.Point(35, 100);
            this.encryptingSettingsBlocksLabel.Name = "encryptingSettingsBlocksLabel";
            this.encryptingSettingsBlocksLabel.Size = new System.Drawing.Size(108, 13);
            this.encryptingSettingsBlocksLabel.TabIndex = 5;
            this.encryptingSettingsBlocksLabel.Text = "Количество блоков:";
            // 
            // encryptingSettingsLabel
            // 
            this.encryptingSettingsLabel.AutoSize = true;
            this.encryptingSettingsLabel.Location = new System.Drawing.Point(6, 82);
            this.encryptingSettingsLabel.Name = "encryptingSettingsLabel";
            this.encryptingSettingsLabel.Size = new System.Drawing.Size(148, 13);
            this.encryptingSettingsLabel.TabIndex = 4;
            this.encryptingSettingsLabel.Text = "Параметры зашифрования:";
            // 
            // encryptingSettingsBlocksNum
            // 
            this.encryptingSettingsBlocksNum.Location = new System.Drawing.Point(149, 98);
            this.encryptingSettingsBlocksNum.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.encryptingSettingsBlocksNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.encryptingSettingsBlocksNum.Name = "encryptingSettingsBlocksNum";
            this.encryptingSettingsBlocksNum.Size = new System.Drawing.Size(48, 20);
            this.encryptingSettingsBlocksNum.TabIndex = 3;
            this.encryptingSettingsBlocksNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.encryptingSettingsBlocksNum.ValueChanged += new System.EventHandler(this.encryptingSettingsBlocksNum_ValueChanged);
            // 
            // encryptingTextLabel
            // 
            this.encryptingTextLabel.AutoSize = true;
            this.encryptingTextLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.encryptingTextLabel.Location = new System.Drawing.Point(6, 9);
            this.encryptingTextLabel.Name = "encryptingTextLabel";
            this.encryptingTextLabel.Size = new System.Drawing.Size(83, 13);
            this.encryptingTextLabel.TabIndex = 2;
            this.encryptingTextLabel.Text = "Введите текст:";
            // 
            // encryptingTextTextbox
            // 
            this.encryptingTextTextbox.Location = new System.Drawing.Point(95, 6);
            this.encryptingTextTextbox.Name = "encryptingTextTextbox";
            this.encryptingTextTextbox.Size = new System.Drawing.Size(210, 20);
            this.encryptingTextTextbox.TabIndex = 13;
            this.encryptingTextTextbox.TextChanged += new System.EventHandler(this.encryptingTextTexbox_TextChanged);
            // 
            // encryptingTypeCombobox
            // 
            this.encryptingTypeCombobox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.encryptingTypeCombobox.FormattingEnabled = true;
            this.encryptingTypeCombobox.Items.AddRange(new object[] {
            "Сеть Фейстеля"});
            this.encryptingTypeCombobox.Location = new System.Drawing.Point(6, 32);
            this.encryptingTypeCombobox.Name = "encryptingTypeCombobox";
            this.encryptingTypeCombobox.Size = new System.Drawing.Size(299, 21);
            this.encryptingTypeCombobox.TabIndex = 0;
            this.encryptingTypeCombobox.Text = "Выберите способ шифрования";
            this.encryptingTypeCombobox.UseWaitCursor = true;
            this.encryptingTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.encryptingTypeCombobox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decryptingKeyTextbox);
            this.tabPage2.Controls.Add(this.decryptingResultTextbox);
            this.tabPage2.Controls.Add(this.decryptingKeyLabel);
            this.tabPage2.Controls.Add(this.decryptingTypeCombobox);
            this.tabPage2.Controls.Add(this.decryptingButton);
            this.tabPage2.Controls.Add(this.decryptingTextTextbox);
            this.tabPage2.Controls.Add(this.decryptingResultLabel);
            this.tabPage2.Controls.Add(this.decryptingTextLabel);
            this.tabPage2.Controls.Add(this.decryptingSettingsBlocksNum);
            this.tabPage2.Controls.Add(this.decryptingSettingsRoundsLabel);
            this.tabPage2.Controls.Add(this.decryptingSettingsLabel);
            this.tabPage2.Controls.Add(this.decryptingSettingsRoundsNum);
            this.tabPage2.Controls.Add(this.decryptingSettingsBlocksLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(311, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расшифровать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decryptingKeyTextbox
            // 
            this.decryptingKeyTextbox.Location = new System.Drawing.Point(115, 59);
            this.decryptingKeyTextbox.MaxLength = 127;
            this.decryptingKeyTextbox.Name = "decryptingKeyTextbox";
            this.decryptingKeyTextbox.Size = new System.Drawing.Size(190, 20);
            this.decryptingKeyTextbox.TabIndex = 25;
            this.decryptingKeyTextbox.TextChanged += new System.EventHandler(this.decryptingSettingsKeyTextbox_TextChanged);
            // 
            // decryptingResultTextbox
            // 
            this.decryptingResultTextbox.Location = new System.Drawing.Point(74, 184);
            this.decryptingResultTextbox.MaxLength = 4095;
            this.decryptingResultTextbox.Name = "decryptingResultTextbox";
            this.decryptingResultTextbox.Size = new System.Drawing.Size(231, 20);
            this.decryptingResultTextbox.TabIndex = 21;
            // 
            // decryptingKeyLabel
            // 
            this.decryptingKeyLabel.AutoSize = true;
            this.decryptingKeyLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingKeyLabel.Location = new System.Drawing.Point(6, 62);
            this.decryptingKeyLabel.Name = "decryptingKeyLabel";
            this.decryptingKeyLabel.Size = new System.Drawing.Size(103, 13);
            this.decryptingKeyLabel.TabIndex = 24;
            this.decryptingKeyLabel.Text = "Ключ шифрования:";
            // 
            // decryptingTypeCombobox
            // 
            this.decryptingTypeCombobox.Cursor = System.Windows.Forms.Cursors.Default;
            this.decryptingTypeCombobox.FormattingEnabled = true;
            this.decryptingTypeCombobox.Items.AddRange(new object[] {
            "Сеть Фейстеля"});
            this.decryptingTypeCombobox.Location = new System.Drawing.Point(6, 32);
            this.decryptingTypeCombobox.Name = "decryptingTypeCombobox";
            this.decryptingTypeCombobox.Size = new System.Drawing.Size(299, 21);
            this.decryptingTypeCombobox.TabIndex = 13;
            this.decryptingTypeCombobox.Text = "Выберите способ шифрования";
            this.decryptingTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.decryptingTypeCombobox_SelectedIndexChanged);
            // 
            // decryptingButton
            // 
            this.decryptingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingButton.Location = new System.Drawing.Point(6, 150);
            this.decryptingButton.Name = "decryptingButton";
            this.decryptingButton.Size = new System.Drawing.Size(299, 23);
            this.decryptingButton.TabIndex = 23;
            this.decryptingButton.Text = "Расшифровать";
            this.decryptingButton.UseVisualStyleBackColor = true;
            this.decryptingButton.Click += new System.EventHandler(this.decryptingButton_Click);
            // 
            // decryptingTextTextbox
            // 
            this.decryptingTextTextbox.Location = new System.Drawing.Point(95, 6);
            this.decryptingTextTextbox.MaxLength = 1023;
            this.decryptingTextTextbox.Name = "decryptingTextTextbox";
            this.decryptingTextTextbox.Size = new System.Drawing.Size(210, 20);
            this.decryptingTextTextbox.TabIndex = 14;
            this.decryptingTextTextbox.TextChanged += new System.EventHandler(this.decryptingTextTextbox_TextChanged);
            // 
            // decryptingResultLabel
            // 
            this.decryptingResultLabel.AutoSize = true;
            this.decryptingResultLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingResultLabel.Location = new System.Drawing.Point(6, 187);
            this.decryptingResultLabel.Name = "decryptingResultLabel";
            this.decryptingResultLabel.Size = new System.Drawing.Size(62, 13);
            this.decryptingResultLabel.TabIndex = 22;
            this.decryptingResultLabel.Text = "Результат:";
            // 
            // decryptingTextLabel
            // 
            this.decryptingTextLabel.AutoSize = true;
            this.decryptingTextLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingTextLabel.Location = new System.Drawing.Point(6, 9);
            this.decryptingTextLabel.Name = "decryptingTextLabel";
            this.decryptingTextLabel.Size = new System.Drawing.Size(83, 13);
            this.decryptingTextLabel.TabIndex = 15;
            this.decryptingTextLabel.Text = "Введите текст:";
            // 
            // decryptingSettingsBlocksNum
            // 
            this.decryptingSettingsBlocksNum.Location = new System.Drawing.Point(149, 98);
            this.decryptingSettingsBlocksNum.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.decryptingSettingsBlocksNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.decryptingSettingsBlocksNum.Name = "decryptingSettingsBlocksNum";
            this.decryptingSettingsBlocksNum.Size = new System.Drawing.Size(48, 20);
            this.decryptingSettingsBlocksNum.TabIndex = 16;
            this.decryptingSettingsBlocksNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.decryptingSettingsBlocksNum.ValueChanged += new System.EventHandler(this.decryptingSettingsBlocksNum_ValueChanged);
            // 
            // decryptingSettingsRoundsLabel
            // 
            this.decryptingSettingsRoundsLabel.AutoSize = true;
            this.decryptingSettingsRoundsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingSettingsRoundsLabel.Location = new System.Drawing.Point(35, 126);
            this.decryptingSettingsRoundsLabel.Name = "decryptingSettingsRoundsLabel";
            this.decryptingSettingsRoundsLabel.Size = new System.Drawing.Size(113, 13);
            this.decryptingSettingsRoundsLabel.TabIndex = 20;
            this.decryptingSettingsRoundsLabel.Text = "Количество раундов:";
            // 
            // decryptingSettingsLabel
            // 
            this.decryptingSettingsLabel.AutoSize = true;
            this.decryptingSettingsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingSettingsLabel.Location = new System.Drawing.Point(6, 82);
            this.decryptingSettingsLabel.Name = "decryptingSettingsLabel";
            this.decryptingSettingsLabel.Size = new System.Drawing.Size(154, 13);
            this.decryptingSettingsLabel.TabIndex = 17;
            this.decryptingSettingsLabel.Text = "Параметры расшифрования:";
            // 
            // decryptingSettingsRoundsNum
            // 
            this.decryptingSettingsRoundsNum.Location = new System.Drawing.Point(154, 124);
            this.decryptingSettingsRoundsNum.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.decryptingSettingsRoundsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decryptingSettingsRoundsNum.Name = "decryptingSettingsRoundsNum";
            this.decryptingSettingsRoundsNum.Size = new System.Drawing.Size(48, 20);
            this.decryptingSettingsRoundsNum.TabIndex = 19;
            this.decryptingSettingsRoundsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decryptingSettingsRoundsNum.ValueChanged += new System.EventHandler(this.decryptingSettingsRoundsNum_ValueChanged);
            // 
            // decryptingSettingsBlocksLabel
            // 
            this.decryptingSettingsBlocksLabel.AutoSize = true;
            this.decryptingSettingsBlocksLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.decryptingSettingsBlocksLabel.Location = new System.Drawing.Point(35, 100);
            this.decryptingSettingsBlocksLabel.Name = "decryptingSettingsBlocksLabel";
            this.decryptingSettingsBlocksLabel.Size = new System.Drawing.Size(108, 13);
            this.decryptingSettingsBlocksLabel.TabIndex = 18;
            this.decryptingSettingsBlocksLabel.Text = "Количество блоков:";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(343, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // aboutProgramStripMenuItem
            // 
            this.aboutProgramStripMenuItem.Name = "aboutProgramStripMenuItem";
            this.aboutProgramStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutProgramStripMenuItem.Text = "О программе";
            this.aboutProgramStripMenuItem.Click += new System.EventHandler(this.aboutProgramStripMenuItem_Click);
            // 
            // statusProgressbar
            // 
            this.statusProgressbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusProgressbar.Location = new System.Drawing.Point(12, 282);
            this.statusProgressbar.Maximum = 1;
            this.statusProgressbar.Name = "statusProgressbar";
            this.statusProgressbar.Size = new System.Drawing.Size(319, 23);
            this.statusProgressbar.Step = 1;
            this.statusProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.statusProgressbar.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusLabel.Location = new System.Drawing.Point(13, 266);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(68, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Ожидание...";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(343, 317);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusProgressbar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Encryption - v0.2";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsRoundsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsBlocksNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decryptingSettingsBlocksNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptingSettingsRoundsNum)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramStripMenuItem;
        private System.Windows.Forms.ProgressBar statusProgressbar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox encryptingTypeCombobox;
        private System.Windows.Forms.TextBox encryptingTextTextbox;
        private System.Windows.Forms.Label encryptingSettingsBlocksLabel;
        private System.Windows.Forms.Label encryptingSettingsLabel;
        private System.Windows.Forms.NumericUpDown encryptingSettingsBlocksNum;
        private System.Windows.Forms.Label encryptingTextLabel;
        private System.Windows.Forms.Label encryptingSettingsRoundsLabel;
        private System.Windows.Forms.NumericUpDown encryptingSettingsRoundsNum;
        private System.Windows.Forms.Label encryptingResultLabel;
        private System.Windows.Forms.TextBox encryptingResultTextbox;
        private System.Windows.Forms.TextBox encryptingKeyTextbox;
        private System.Windows.Forms.Label encryptingKeyLabel;
        private System.Windows.Forms.Button encryptingButton;
        private System.Windows.Forms.TextBox decryptingKeyTextbox;
        private System.Windows.Forms.TextBox decryptingResultTextbox;
        private System.Windows.Forms.Label decryptingKeyLabel;
        private System.Windows.Forms.ComboBox decryptingTypeCombobox;
        private System.Windows.Forms.Button decryptingButton;
        private System.Windows.Forms.TextBox decryptingTextTextbox;
        private System.Windows.Forms.Label decryptingResultLabel;
        private System.Windows.Forms.Label decryptingTextLabel;
        private System.Windows.Forms.NumericUpDown decryptingSettingsBlocksNum;
        private System.Windows.Forms.Label decryptingSettingsRoundsLabel;
        private System.Windows.Forms.Label decryptingSettingsLabel;
        private System.Windows.Forms.NumericUpDown decryptingSettingsRoundsNum;
        private System.Windows.Forms.Label decryptingSettingsBlocksLabel;
    }
}

