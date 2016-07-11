using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class RuleData
    {
        public int LessThan { get; set; }
        public int GreaterThanEquals { get; set; }
        public int Substract { get; set; }
        public string Symbol { get; set; }
    }

    public interface IRule
    {
        bool DoesRuleApplies(int number);
        int LessThan { get; set; }
        int GreaterThanEquals { get; set; }
        int Substract { get; set; }
        string Symbol { get; set; }
    }

    public class Rule : IRule
    {
        public int LessThan { get; set; }
        public int GreaterThanEquals { get; set; }
        public int Substract { get; set; }
        public string Symbol { get; set; }

        public static IRule Create(RuleData ruleData)
        {
            return new Rule
            {
                GreaterThanEquals = ruleData.GreaterThanEquals,
                LessThan = ruleData.LessThan,
                Substract = ruleData.Substract,
                Symbol = ruleData.Symbol
            };
        }

        public bool DoesRuleApplies(int number)
        {
            return (number >= this.GreaterThanEquals && number < this.LessThan);
        }
    }

    
}
