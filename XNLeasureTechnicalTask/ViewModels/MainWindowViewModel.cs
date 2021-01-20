using Prism.Commands;
using System.Collections.Generic;
using System.Windows.Input;
using XNLeasureTechnicalTask.Services.Interfaces;
using XNLeasureTechnicalTask.ViewModels.Interfaces;

namespace XNLeasureTechnicalTask.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private string _stringInput;
        private char _charToCount;
        private int _charCount;
        private bool _ignoreCase;
        private string _charCountResult;
        private string _firstNumber;
        private string _secondNumber;
        private string _mathResult;

        private readonly IMathService _mathService;
        private readonly ICharacterCountService _characterCountService;

        public MainWindowViewModel(IMathService mathService, ICharacterCountService characterCountService)
        {
            _mathService = mathService;
            _characterCountService = characterCountService;

            AddCommand = new DelegateCommand(Add);
            CountCommand = new DelegateCommand(Count);
        }

        #region properties

        public string StringInput
        {
            get { return _stringInput; }
            set
            {
                _stringInput = value;
                OnPropertyChanged();
            }
        }

        public char CharToCount
        {
            get { return _charToCount; }
            set
            {
                _charToCount = value;
                OnPropertyChanged();
            }
        }

        public int CharCount
        {
            get { return _charCount; }
            set
            {
                _charCount = value;
                OnPropertyChanged();
            }
        }

        public bool IgnoreCase
        {
            get { return _ignoreCase; }
            set
            {
                _ignoreCase = value;
                OnPropertyChanged();
            }
        }

        public string CharCountResult
        {
            get { return _charCountResult; }
            set
            {
                _charCountResult = value;
                OnPropertyChanged();
            }
        }

        public string FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                _firstNumber = value;
                OnPropertyChanged();
            }
        }

        public string SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                _secondNumber = value;
                OnPropertyChanged();
            }
        }

        public string MathResult
        {
            get { return _mathResult; }
            set
            {
                _mathResult = value;
                OnPropertyChanged();
            }
        }

        public ICommand CountCommand { get; set; }
        public ICommand AddCommand { get; set; }

        #endregion properties

        private void Count()
        {
            CharCount = _characterCountService.GetNoOfCharacters(StringInput, CharToCount, IgnoreCase);

            CharCountResult = $"{CharCount} occurences of {CharToCount}";
        }

        private void Add()
        {
            double first;
            double second;
            if (double.TryParse(FirstNumber, out first) == true && double.TryParse(SecondNumber, out second) == true)
            {
                MathResult = _mathService.AddNumbers(new List<double> { first, second }).ToString();
            }
            else
            {
                MathResult = "Syntax Error";
            }
        }
    }
}