using System.Collections.Generic;
using System.Linq;
using XNLeasureTechnicalTask.Services.Interfaces;

namespace XNLeasureTechnicalTask.Services
{
    internal class MathService : IMathService
    {
        public double AddNumbers(IEnumerable<double> numbers)
        {
            return numbers.Sum(n => n);
        }
    }
}