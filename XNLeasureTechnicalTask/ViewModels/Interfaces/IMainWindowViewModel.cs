using System;
using System.Collections.Generic;
using System.Text;

namespace XNLeasureTechnicalTask.ViewModels.Interfaces
{
    public interface IMainWindowViewModel
    {
        string StringInput { get; set; }
        char CharToCount { get; set; }
        int CharCount { get; set; }
        bool IgnoreCase { get; set; }
        string CharCountResult { get; set; }
        string FirstNumber { get; set; }
        string SecondNumber { get; set; }
        string MathResult { get; set; }
    }
}