using System;
using System.Linq;
using XNLeasureTechnicalTask.Services.Interfaces;

namespace XNLeasureTechnicalTask.Services
{
    internal class CharacterCountService : ICharacterCountService
    {
        public int GetNoOfCharacters(string input, char character, bool ignoreCase = true)
        {
            if (ignoreCase)
            {
                input = input.ToLower();
                character = Char.ToLower(character);
            }

            return input.Count(c => (c == character));
        }
    }
}