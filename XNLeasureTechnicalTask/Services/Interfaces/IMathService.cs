using System.Collections.Generic;

namespace XNLeasureTechnicalTask.Services.Interfaces
{
    public interface IMathService
    {
        double AddNumbers(IEnumerable<double> numbers);

        double Divide(double toDivide, double divideBy);
    }
}