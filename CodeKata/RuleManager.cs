using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public interface IRuleManager
    {
        IRule GetRule(int number);
        IRule GetRule(string roman);
        string[] LeafSymbols { get; set; }
    }

    public class RuleManager : IRuleManager
    {
        public IEnumerable<IRule> Rules { get; private set; }
        public string[] LeafSymbols { get; set; }
        IRuleDataService _dataService;

        IList<string> _symbols;

        //poor man's DI
        public RuleManager() : this(new RuleDataService()) { }

        public RuleManager(IRuleDataService ruleDataService)
        {
            this._dataService = ruleDataService;

            setUpRules();
        }

        private void setUpRules()
        {
            var rules = _dataService.GetRuleData()
                .Select(rd => Rule.Create(rd))
                .ToList();

            this.Rules = rules;

            this.LeafSymbols = _dataService.GetLeafSymbols();

            this._symbols = this.Rules
                .Select(r => r.Symbol)
                .ToList();
        }

        public IRule GetRule(int number)
        {
            return Rules
                .Where(rule => rule.DoesRuleApplies(number))
                .SingleOrDefault();
        }

        public IRule GetRule(string romanNumber)
        {
            if (romanNumber == string.Empty) return null;

            var token = romanNumber;
            var counter = romanNumber.Length;

            while (!_symbols.Contains(token) && counter > 0)
            {
                token = romanNumber.Substring(0, counter);
                counter--;
            }

            return Rules
                .Where(rule => rule.Symbol.StartsWith(token))
                .FirstOrDefault();
        }
    }
}
