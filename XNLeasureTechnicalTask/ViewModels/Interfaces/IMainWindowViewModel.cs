using System;
using System.Collections.Generic;
using System.Text;

namespace XNLeasureTechnicalTask.ViewModels.Interfaces
{
    public interface IMainWindowViewModel
    {
        string StringInput { get; set; }
        string StringToCount { get; set; }
        int StringCount { get; set; }
        bool? IgnoreCase { get; set; }
        string CharCountResult { get; set; }
        string FirstNumber { get; set; }
        string SecondNumber { get; set; }
        string SumResult { get; set; }
        string ToDivide { get; set; }
        string DivideBy { get; set; }
        string DivideResult { get; set; }
    }
}