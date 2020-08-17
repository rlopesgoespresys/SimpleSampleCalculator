using System.Collections.Generic;
using System;
using System.Linq;

namespace kilo
{
    public class Engine
    {
        Dictionary<string, double> values = new Dictionary<string, double>();
        public Double Value { get; private set; }
        public Engine()
        {
            CreateDictionary();
        }
        private void CreateDictionary()
        {
            values.Add("k", 1000);
            values.Add("M", 1000000);
            values.Add("m", 0.001);
        }

        public bool Calculate(String str)
        {
            var pot = str[str.Length - 1];
            if (IsNumber(pot))
                Value = Single.Parse(str);
            else
            {
                try
                {
                    var v = str.Substring(0, str.Length - 1);
                    Console.WriteLine(v);
                    var exp = GetMultFactor(pot);
                    if (exp == 0.0)
                    {
                        Console.WriteLine("Unidade nao encontrada!!!");
                        return false;
                    }
                    Value = double.Parse(v) * exp;
                }
                catch
                {
                    Console.WriteLine("Digite um valor valido.");
                    return false;
                }
            }
            return true;

        }

        public double GetMultFactor(char pot)
        {
            var s = (from i in values
                     where i.Key == pot.ToString()
                     select i).FirstOrDefault();
            return s.Value;
        }

        public bool IsNumber(char p)
        {
            return (p >= 48 && p <= 57);
        }

    }

}