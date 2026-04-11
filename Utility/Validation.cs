using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CoffeShopNusantara.Utility
{
    public class Validation
    {

        public bool isValidTexts(string input, string input2)
        {
            bool IsValid = !string.IsNullOrWhiteSpace(input) && !string.IsNullOrWhiteSpace(input2);
            if (!IsValid)
            {
                MessageBox.Show("Inputan tidak sesuai");
            }
            return IsValid;
        }

        public bool isMatchTexts(string inputA, string inputB)
        {
            bool isMatch = inputA == inputB;
            if (!isMatch)
            {
                MessageBox.Show("Inputan tidak sesuai");
            }
            return isMatch;
        }
    }
}
