﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TranslatorArmy
    {
        public List<Translator> Translators { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public TranslatorArmy() { }
        public override string ToString()
        {
            if (Translators != null)
            {
                foreach (var item in Translators)
                {
                    Console.WriteLine(item);
                }
            }
            return $"{Name} - {Location}";
        }
    }
}
