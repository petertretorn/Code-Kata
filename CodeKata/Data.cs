using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public interface IRuleDataService
    {
        IEnumerable<RuleData> GetRuleData();
        string[] GetLeafSymbols();
    }

    public class RuleDataService : IRuleDataService
    {
        public IEnumerable<RuleData> GetRuleData()
        {
            return new List<RuleData>
            {
                new RuleData() { GreaterThanEquals = 10, LessThan = 40, Symbol = "X", Substract = 10 },
                new RuleData() { GreaterThanEquals = 40, LessThan = 50, Symbol = "XL", Substract = 40 },
                new RuleData() { GreaterThanEquals = 50, LessThan = 90, Symbol = "L", Substract = 50 },
                new RuleData() { GreaterThanEquals = 90, LessThan = 100, Symbol = "XC", Substract = 90 },
                new RuleData() { GreaterThanEquals = 100, LessThan = 400, Symbol = "C", Substract = 100 },
                new RuleData() { GreaterThanEquals = 400, LessThan = 500, Symbol = "CD", Substract = 400 },
                new RuleData() { GreaterThanEquals = 500, LessThan = 900, Symbol = "D", Substract = 500 },
                new RuleData() { GreaterThanEquals = 900, LessThan = 1000, Symbol = "CM", Substract = 900 },
                new RuleData() { GreaterThanEquals = 1000, LessThan = 3001, Symbol = "M", Substract = 1000 }
            };
        }

        public string[] GetLeafSymbols()
        {
            return new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        }
    }
}
