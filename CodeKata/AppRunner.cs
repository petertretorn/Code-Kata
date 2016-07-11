using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class AppRunner
    {
        IConverter _converter;

        //poor man's DI
        public AppRunner() : this(new Converter()) { }

        public AppRunner(IConverter converter)
        {
            this._converter = converter;
        }

        public void Run()
        {
            Console.WriteLine("9: {0}", _converter.ConvertToRoman(9));
            Console.WriteLine("49: {0}", _converter.ConvertToRoman(49));
            Console.WriteLine("100: {0}", _converter.ConvertToRoman(100));
            Console.WriteLine("501: {0}", _converter.ConvertToRoman(501));

            Console.WriteLine("CX: {0}", _converter.ConvertToInteger("CX"));
        }
    }
}
