using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using XNLeasureTechnicalTask.Services.Interfaces;
using XNLeasureTechnicalTask.ViewModels.Interfaces;

namespace XNLeasureTechnicalTask.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private string _stringInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
        private string _stringToCount = "e";
        private int _stringCount;
        private bool? _ignoreCase = true;
        private string _charCountResult;
        private string _firstNumber = "5";
        private string _secondNumber = "7";
        private string _sumResult;
        private string _toDivide = "17272838119191929838299111";
        private string _divideBy = "1";
        private string _divideResult;

        private readonly IMathService _mathService;
        private readonly ICharacterCountService _characterCountService;

        public MainWindowViewModel(IMathService mathService, ICharacterCountService characterCountService)
        {
            _mathService = mathService;
            _characterCountService = characterCountService;

            AddCommand = new DelegateCommand(Add);
            CountCommand = new DelegateCommand(Count);
            DivideCommand = new DelegateCommand(Divide);
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

        public string StringToCount
        {
            get { return _stringToCount; }
            set
            {
                _stringToCount = value;
                OnPropertyChanged();
            }
        }

        public int StringCount
        {
            get { return _stringCount; }
            set
            {
                _stringCount = value;
                OnPropertyChanged();
            }
        }

        public bool? IgnoreCase
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

        public string SumResult
        {
            get { return _sumResult; }
            set
            {
                _sumResult = value;
                OnPropertyChanged();
            }
        }

        public string ToDivide
        {
            get { return _toDivide; }
            set
            {
                _toDivide = value;
                OnPropertyChanged();
            }
        }

        public string DivideBy
        {
            get { return _divideBy; }
            set
            {
                _divideBy = value;
                OnPropertyChanged();
            }
        }

        public string DivideResult
        {
            get { return _divideResult; }
            set
            {
                _divideResult = value;
                OnPropertyChanged();
            }
        }

        public ICommand CountCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand DivideCommand { get; set; }

        #endregion properties

        private void Count()
        {
            if (StringInput == null || StringToCount == null || IgnoreCase == null)
            {
                CharCountResult = "Please type in the textboxes to get a result";
                return;
            }

            StringCount = _characterCountService.GetNoOfCharacters(StringInput, StringToCount, (bool)IgnoreCase);

            CharCountResult = $"{StringCount} occurences of '{StringToCount}'";
        }

        private void Add()
        {
            double first;
            double second;
            if (double.TryParse(FirstNumber, out first) == true && double.TryParse(SecondNumber, out second) == true)
            {
                SumResult = _mathService.AddNumbers(new List<double> { first, second }).ToString();
            }
            else
            {
                SumResult = "NaN";
            }
        }

        private void Divide()
        {
            double toDivide;
            double divideBy;
            if (double.TryParse(ToDivide, out toDivide) == true && double.TryParse(DivideBy, out divideBy) == true)
            {
                DivideResult = _mathService.Divide(toDivide, divideBy)
                    .ToString();
            }
            else
            {
                DivideResult = "NaN";
            }
        }
    }
}