using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertisseur_MVC
{
    class CurEx_Model : CurEx_Model_Abstract
    {
        private List<string> _availableCurrencies;
        private int _fromIndex;
        private int _toIndex;
        private double[,] _exchangeRate;

        public CurEx_Model()
        {
            _availableCurrencies = new List<string>();
            _availableCurrencies.Add("CHF");
            _availableCurrencies.Add("EUR");
            _availableCurrencies.Add("USD");
            
            _exchangeRate = new double[_availableCurrencies.Count, _availableCurrencies.Count];
            _exchangeRate[0, 0] = 1;
            _exchangeRate[1, 1] = 1;
            _exchangeRate[2, 2] = 1;
            _exchangeRate[0, 2] = 1.12;
            _exchangeRate[2, 0] = 1.0 / 1.12;
            _exchangeRate[0, 1] = 0.93;
            _exchangeRate[1, 0] = 1.0 / 0.93;
            _exchangeRate[1, 2] = 1.21;
            _exchangeRate[2, 1] = 1.0 / 1.21;
        }
        public override List<string> AvailableCurrencies => _availableCurrencies;

        public override string From
        {
            get { return _availableCurrencies[_fromIndex]; }
            set { _fromIndex = _availableCurrencies.IndexOf(value); }
        }
            
        public override string To
        {
            get { return _availableCurrencies[_toIndex]; }
            set { _toIndex = _availableCurrencies.IndexOf(value); }
        }

        public override double Convert(double amount)
        { 
            return amount * _exchangeRate[_fromIndex, _toIndex];
        }
    }
}
