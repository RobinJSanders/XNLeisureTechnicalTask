using System;
using System.Collections.Generic;
using System.Text;
using XNLeasureTechnicalTask.Services;
using XNLeasureTechnicalTask.Services.Interfaces;

namespace XNLeasureTechnicalTask.ViewModels
{
    internal class MainWindowViewModel
    {
        private readonly IMathService _mathService;
        private readonly ICharacterCountService _characterCountService;

        public MainWindowViewModel(IMathService mathService, ICharacterCountService characterCountService)
        {
            _mathService = mathService;
            _characterCountService = characterCountService;
        }
    }
}