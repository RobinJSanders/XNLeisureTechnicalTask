using System;
using System.Linq;
using XNLeasureTechnicalTask.Services.Interfaces;

namespace XNLeasureTechnicalTask.Services
{
    internal class CharacterCountService : ICharacterCountService
    {
        public int GetNoOfCharacters(string input, string stringToCount, bool ignoreCase = true)
        {
            if (ignoreCase)
            {
                input = input.ToLower();
                stringToCount.ToLower();
            }

            return input
                   .Where((item, index) => input.Substring(index).StartsWith(stringToCount))
                   .Count();
        }
    }
}