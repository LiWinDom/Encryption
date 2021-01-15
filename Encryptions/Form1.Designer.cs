
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
            this.encryptingTestButton = new System.Windows.Forms.Button();
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
            this.encryptingTextTexbox = new System.Windows.Forms.TextBox();
            this.encryptingTypeCombobox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThemeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusProgressbar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsRoundsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsBlocksNum)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.encryptingTestButton);
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
            this.tabPage1.Controls.Add(this.encryptingTextTexbox);
            this.tabPage1.Controls.Add(this.encryptingTypeCombobox);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encryptingTestButton
            // 
            resources.ApplyResources(this.encryptingTestButton, "encryptingTestButton");
            this.encryptingTestButton.Name = "encryptingTestButton";
            this.encryptingTestButton.UseVisualStyleBackColor = true;
            // 
            // encryptingKeyTextbox
            // 
            resources.ApplyResources(this.encryptingKeyTextbox, "encryptingKeyTextbox");
            this.encryptingKeyTextbox.Name = "encryptingKeyTextbox";
            // 
            // encryptingKeyLabel
            // 
            resources.ApplyResources(this.encryptingKeyLabel, "encryptingKeyLabel");
            this.encryptingKeyLabel.Name = "encryptingKeyLabel";
            // 
            // encryptingButton
            // 
            resources.ApplyResources(this.encryptingButton, "encryptingButton");
            this.encryptingButton.Name = "encryptingButton";
            this.encryptingButton.UseVisualStyleBackColor = true;
            this.encryptingButton.Click += new System.EventHandler(this.encryptingButton_Click);
            // 
            // encryptingResultLabel
            // 
            resources.ApplyResources(this.encryptingResultLabel, "encryptingResultLabel");
            this.encryptingResultLabel.Name = "encryptingResultLabel";
            // 
            // encryptingResultTextbox
            // 
            resources.ApplyResources(this.encryptingResultTextbox, "encryptingResultTextbox");
            this.encryptingResultTextbox.Name = "encryptingResultTextbox";
            // 
            // encryptingSettingsRoundsLabel
            // 
            resources.ApplyResources(this.encryptingSettingsRoundsLabel, "encryptingSettingsRoundsLabel");
            this.encryptingSettingsRoundsLabel.Name = "encryptingSettingsRoundsLabel";
            this.encryptingSettingsRoundsLabel.Click += new System.EventHandler(this.encryptingSettingsRoundsLabel_Click);
            // 
            // encryptingSettingsRoundsNum
            // 
            resources.ApplyResources(this.encryptingSettingsRoundsNum, "encryptingSettingsRoundsNum");
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
            this.encryptingSettingsRoundsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.encryptingSettingsRoundsNum.ValueChanged += new System.EventHandler(this.encryptingSettingsRoundsNum_ValueChanged);
            // 
            // encryptingSettingsBlocksLabel
            // 
            resources.ApplyResources(this.encryptingSettingsBlocksLabel, "encryptingSettingsBlocksLabel");
            this.encryptingSettingsBlocksLabel.Name = "encryptingSettingsBlocksLabel";
            // 
            // encryptingSettingsLabel
            // 
            resources.ApplyResources(this.encryptingSettingsLabel, "encryptingSettingsLabel");
            this.encryptingSettingsLabel.Name = "encryptingSettingsLabel";
            this.encryptingSettingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // encryptingSettingsBlocksNum
            // 
            resources.ApplyResources(this.encryptingSettingsBlocksNum, "encryptingSettingsBlocksNum");
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
            this.encryptingSettingsBlocksNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.encryptingSettingsBlocksNum.ValueChanged += new System.EventHandler(this.encryptingSettingsBlocksNum_ValueChanged);
            // 
            // encryptingTextLabel
            // 
            resources.ApplyResources(this.encryptingTextLabel, "encryptingTextLabel");
            this.encryptingTextLabel.Name = "encryptingTextLabel";
            // 
            // encryptingTextTexbox
            // 
            resources.ApplyResources(this.encryptingTextTexbox, "encryptingTextTexbox");
            this.encryptingTextTexbox.Name = "encryptingTextTexbox";
            this.encryptingTextTexbox.TextChanged += new System.EventHandler(this.encryptingTextTexbox_TextChanged);
            // 
            // encryptingTypeCombobox
            // 
            resources.ApplyResources(this.encryptingTypeCombobox, "encryptingTypeCombobox");
            this.encryptingTypeCombobox.Cursor = System.Windows.Forms.Cursors.Default;
            this.encryptingTypeCombobox.FormattingEnabled = true;
            this.encryptingTypeCombobox.Items.AddRange(new object[] {
            resources.GetString("encryptingTypeCombobox.Items"),
            resources.GetString("encryptingTypeCombobox.Items1"),
            resources.GetString("encryptingTypeCombobox.Items2")});
            this.encryptingTypeCombobox.Name = "encryptingTypeCombobox";
            this.encryptingTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.encryptingTypeCombobox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsStripMenuItem,
            this.aboutProgramStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // settingsStripMenuItem
            // 
            resources.ApplyResources(this.settingsStripMenuItem, "settingsStripMenuItem");
            this.settingsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeThemeStripMenuItem});
            this.settingsStripMenuItem.Name = "settingsStripMenuItem";
            this.settingsStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // changeThemeStripMenuItem
            // 
            resources.ApplyResources(this.changeThemeStripMenuItem, "changeThemeStripMenuItem");
            this.changeThemeStripMenuItem.Name = "changeThemeStripMenuItem";
            this.changeThemeStripMenuItem.Click += new System.EventHandler(this.changeThemeStripMenuItem_Click);
            // 
            // aboutProgramStripMenuItem
            // 
            resources.ApplyResources(this.aboutProgramStripMenuItem, "aboutProgramStripMenuItem");
            this.aboutProgramStripMenuItem.Name = "aboutProgramStripMenuItem";
            // 
            // statusProgressbar
            // 
            resources.ApplyResources(this.statusProgressbar, "statusProgressbar");
            this.statusProgressbar.Maximum = 1;
            this.statusProgressbar.Name = "statusProgressbar";
            this.statusProgressbar.Step = 1;
            this.statusProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.statusProgressbar.Click += new System.EventHandler(this.statusProgressbar_Click);
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // mainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusProgressbar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsRoundsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encryptingSettingsBlocksNum)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramStripMenuItem;
        private System.Windows.Forms.ProgressBar statusProgressbar;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox encryptingTypeCombobox;
        private System.Windows.Forms.TextBox encryptingTextTexbox;
        private System.Windows.Forms.ToolStripMenuItem changeThemeStripMenuItem;
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
        private System.Windows.Forms.Button encryptingTestButton;
    }
}

