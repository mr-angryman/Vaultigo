using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vaultigo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string GeneratePassword(
        int length,
        bool includeUppercase,
        bool includeLowercase,
        bool includeNumbers,
        bool includeSymbols,
        bool noSimilarCharacters,
        bool noDuplicatedCharacters,
        bool noSequentialCharacters)
        {
            string uppercase = noSimilarCharacters ? "ABCDEFGHJKLMNPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = noSimilarCharacters ? "abcdefghijkmnopqrstuvwxyz" : "abcdefghijklmnopqrstuvwxyz";
            string numbers = noSimilarCharacters ? "23456789" : "0123456789";
            string symbols = "!@#$%^&*";

            StringBuilder charSet = new StringBuilder();
            if (includeUppercase) charSet.Append(uppercase);
            if (includeLowercase) charSet.Append(lowercase);
            if (includeNumbers) charSet.Append(numbers);
            if (includeSymbols) charSet.Append(symbols);

            string availableChars = charSet.ToString();
            if (availableChars.Length == 0)
            {
                MessageBox.Show("Please select at least one character type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }

            if (noDuplicatedCharacters && length > availableChars.Length)
            {
                MessageBox.Show("Password length too long for selected options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return string.Empty;
            }

            Random rng = new Random();
            StringBuilder password = new StringBuilder();
            HashSet<char> usedChars = new HashSet<char>();

            while (password.Length < length)
            {
                char nextChar = availableChars[rng.Next(availableChars.Length)];

                if (noDuplicatedCharacters && usedChars.Contains(nextChar))
                    continue;

                if (noSequentialCharacters && password.Length > 0)
                {
                    char last = password[password.Length - 1];
                    if (Math.Abs(nextChar - last) == 1)
                        continue;
                }

                password.Append(nextChar);
                usedChars.Add(nextChar);
            }

            return password.ToString();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = GeneratePassword((int)passwordLengthNumeric.Value, includeUppercaseCheckBox.Checked, includeLowercaseCheckBox.Checked, includeNumbersCheckBox.Checked, includeSymbolsCheckBox.Checked, noSimilarCharactersCheckBox.Checked, noDuplicatedCharactersCheckBox.Checked, noSequentialCharactersCheckBox.Checked);
        }
    }
}
