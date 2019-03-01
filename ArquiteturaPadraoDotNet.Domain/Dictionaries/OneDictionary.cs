using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Dictionaries
{
    public static class OneDictionary
    {
        public static Dictionary<string, string> StatusDictionary()
        {
            var dictionary = new Dictionary<string, string>();

            dictionary.Add("A", "Ativo");
            dictionary.Add("I", "Inativo");

            return dictionary;
        }
    }
}
