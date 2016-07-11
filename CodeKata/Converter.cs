using System;
using System.Text;

namespace CodeKata
{
    public interface IConverter
    {
        string ConvertToRoman(int number);
        int ConvertToInteger(string roman);
    }

    public class Converter : IConverter
    {
        private IRuleManager _ruleManager { get; set; }

        //poor man's DI
        public Converter() : this(new RuleManager()) { }

        public Converter(IRuleManager ruleManager)
        {
            this._ruleManager = ruleManager;
        }

        public string ConvertToRoman(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();

            var rule = _ruleManager.GetRule(number);

            while (number >= 10)
            {
                stringBuilder.Append(rule.Symbol);
                number -= rule.Substract;
                rule = _ruleManager.GetRule(number);
            }
            
            stringBuilder.Append(ConvertSingleDigitToRoman(number));

            return stringBuilder.ToString();
        }

        public int ConvertToInteger(string roman)
        {
            var number = 0;

            var rule = _ruleManager.GetRule(roman);

            while (rule != null)
            {
                number += rule.Substract;

                roman = roman.Substring(rule.Symbol.Length);
                rule = _ruleManager.GetRule(roman);
            }

            number += Array.IndexOf(_ruleManager.LeafSymbols, roman) + 1;

            return number;
        } 

        private string ConvertSingleDigitToRoman(int number)
        {
            if (number == 0)
            {
                return string.Empty;
            }

            var result = _ruleManager.LeafSymbols[number - 1];

            return result;
        }
    }
}
