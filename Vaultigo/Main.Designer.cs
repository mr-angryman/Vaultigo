namespace Vaultigo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            includeUppercaseCheckBox = new CheckBox();
            includeLowercaseCheckBox = new CheckBox();
            includeNumbersCheckBox = new CheckBox();
            includeSymbolsCheckBox = new CheckBox();
            noSimilarCharactersCheckBox = new CheckBox();
            noDuplicatedCharactersCheckBox = new CheckBox();
            noSequentialCharactersCheckBox = new CheckBox();
            passwordLenghtLabel = new Label();
            passwordLengthNumeric = new NumericUpDown();
            resultTextBox = new TextBox();
            resultLabel = new Label();
            generateButton = new Button();
            mainToolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)passwordLengthNumeric).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(413, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // includeUppercaseCheckBox
            // 
            includeUppercaseCheckBox.AutoSize = true;
            includeUppercaseCheckBox.Font = new Font("Segoe UI", 12F);
            includeUppercaseCheckBox.Location = new Point(12, 12);
            includeUppercaseCheckBox.Name = "includeUppercaseCheckBox";
            includeUppercaseCheckBox.Size = new Size(156, 25);
            includeUppercaseCheckBox.TabIndex = 1;
            includeUppercaseCheckBox.Text = "Include Uppercase";
            mainToolTip.SetToolTip(includeUppercaseCheckBox, "Enables the uppercase charset.");
            includeUppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeLowercaseCheckBox
            // 
            includeLowercaseCheckBox.AutoSize = true;
            includeLowercaseCheckBox.Font = new Font("Segoe UI", 12F);
            includeLowercaseCheckBox.Location = new Point(12, 43);
            includeLowercaseCheckBox.Name = "includeLowercaseCheckBox";
            includeLowercaseCheckBox.Size = new Size(156, 25);
            includeLowercaseCheckBox.TabIndex = 2;
            includeLowercaseCheckBox.Text = "Include Lowercase";
            mainToolTip.SetToolTip(includeLowercaseCheckBox, "Enables the lowercase charset.");
            includeLowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeNumbersCheckBox
            // 
            includeNumbersCheckBox.AutoSize = true;
            includeNumbersCheckBox.Font = new Font("Segoe UI", 12F);
            includeNumbersCheckBox.Location = new Point(12, 74);
            includeNumbersCheckBox.Name = "includeNumbersCheckBox";
            includeNumbersCheckBox.Size = new Size(148, 25);
            includeNumbersCheckBox.TabIndex = 3;
            includeNumbersCheckBox.Text = "Include Numbers";
            mainToolTip.SetToolTip(includeNumbersCheckBox, "Enables the numbers charset.");
            includeNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeSymbolsCheckBox
            // 
            includeSymbolsCheckBox.AutoSize = true;
            includeSymbolsCheckBox.Font = new Font("Segoe UI", 12F);
            includeSymbolsCheckBox.Location = new Point(12, 105);
            includeSymbolsCheckBox.Name = "includeSymbolsCheckBox";
            includeSymbolsCheckBox.Size = new Size(143, 25);
            includeSymbolsCheckBox.TabIndex = 4;
            includeSymbolsCheckBox.Text = "Include Symbols";
            mainToolTip.SetToolTip(includeSymbolsCheckBox, "Enables the symbols charset.");
            includeSymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // noSimilarCharactersCheckBox
            // 
            noSimilarCharactersCheckBox.AutoSize = true;
            noSimilarCharactersCheckBox.Font = new Font("Segoe UI", 12F);
            noSimilarCharactersCheckBox.Location = new Point(190, 12);
            noSimilarCharactersCheckBox.Name = "noSimilarCharactersCheckBox";
            noSimilarCharactersCheckBox.Size = new Size(181, 25);
            noSimilarCharactersCheckBox.TabIndex = 5;
            noSimilarCharactersCheckBox.Text = "No Similar Characters";
            mainToolTip.SetToolTip(noSimilarCharactersCheckBox, "Removes confusing characters like 0, O, 1, l, and I");
            noSimilarCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // noDuplicatedCharactersCheckBox
            // 
            noDuplicatedCharactersCheckBox.AutoSize = true;
            noDuplicatedCharactersCheckBox.Font = new Font("Segoe UI", 12F);
            noDuplicatedCharactersCheckBox.Location = new Point(190, 43);
            noDuplicatedCharactersCheckBox.Name = "noDuplicatedCharactersCheckBox";
            noDuplicatedCharactersCheckBox.Size = new Size(206, 25);
            noDuplicatedCharactersCheckBox.TabIndex = 6;
            noDuplicatedCharactersCheckBox.Text = "No Duplicated Characters";
            mainToolTip.SetToolTip(noDuplicatedCharactersCheckBox, "Prevents the same character from appearing more than once in the password.");
            noDuplicatedCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // noSequentialCharactersCheckBox
            // 
            noSequentialCharactersCheckBox.AutoSize = true;
            noSequentialCharactersCheckBox.Font = new Font("Segoe UI", 12F);
            noSequentialCharactersCheckBox.ForeColor = SystemColors.ControlText;
            noSequentialCharactersCheckBox.Location = new Point(190, 74);
            noSequentialCharactersCheckBox.Name = "noSequentialCharactersCheckBox";
            noSequentialCharactersCheckBox.Size = new Size(205, 25);
            noSequentialCharactersCheckBox.TabIndex = 7;
            noSequentialCharactersCheckBox.Text = "No Sequential Characters";
            mainToolTip.SetToolTip(noSequentialCharactersCheckBox, "Blocks characters that follow each other in order, like abc or 123.");
            noSequentialCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordLenghtLabel
            // 
            passwordLenghtLabel.AutoSize = true;
            passwordLenghtLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLenghtLabel.Location = new Point(13, 140);
            passwordLenghtLabel.Name = "passwordLenghtLabel";
            passwordLenghtLabel.Size = new Size(61, 21);
            passwordLenghtLabel.TabIndex = 9;
            passwordLenghtLabel.Text = "Length:";
            // 
            // passwordLengthNumeric
            // 
            passwordLengthNumeric.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLengthNumeric.Location = new Point(80, 136);
            passwordLengthNumeric.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            passwordLengthNumeric.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            passwordLengthNumeric.Name = "passwordLengthNumeric";
            passwordLengthNumeric.Size = new Size(316, 29);
            passwordLengthNumeric.TabIndex = 10;
            mainToolTip.SetToolTip(passwordLengthNumeric, "Length of the generated password.");
            passwordLengthNumeric.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // resultTextBox
            // 
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTextBox.Location = new Point(74, 196);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(322, 29);
            resultTextBox.TabIndex = 11;
            mainToolTip.SetToolTip(resultTextBox, "The password result.");
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(12, 201);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(56, 21);
            resultLabel.TabIndex = 12;
            resultLabel.Text = "Result:";
            // 
            // generateButton
            // 
            generateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateButton.Location = new Point(13, 243);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(382, 49);
            generateButton.TabIndex = 13;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 309);
            Controls.Add(generateButton);
            Controls.Add(resultLabel);
            Controls.Add(resultTextBox);
            Controls.Add(passwordLengthNumeric);
            Controls.Add(passwordLenghtLabel);
            Controls.Add(noSequentialCharactersCheckBox);
            Controls.Add(noDuplicatedCharactersCheckBox);
            Controls.Add(noSimilarCharactersCheckBox);
            Controls.Add(includeSymbolsCheckBox);
            Controls.Add(includeNumbersCheckBox);
            Controls.Add(includeLowercaseCheckBox);
            Controls.Add(includeUppercaseCheckBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Vaultigo";
            ((System.ComponentModel.ISupportInitialize)passwordLengthNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private CheckBox includeUppercaseCheckBox;
        private CheckBox includeLowercaseCheckBox;
        private CheckBox includeNumbersCheckBox;
        private CheckBox includeSymbolsCheckBox;
        private CheckBox noSimilarCharactersCheckBox;
        private CheckBox noDuplicatedCharactersCheckBox;
        private CheckBox noSequentialCharactersCheckBox;
        private Label passwordLenghtLabel;
        private NumericUpDown passwordLengthNumeric;
        private TextBox resultTextBox;
        private Label resultLabel;
        private Button generateButton;
        private ToolTip mainToolTip;
    }
}
