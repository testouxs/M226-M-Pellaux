using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertisseur_MVC
{
    class CurEx_Controller
    {
        private CurEx_Model_Abstract _model;
        private Form _view;

        public CurEx_Model_Abstract Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Form View
        {
            get { return _view; }
            set { _view = value; }
        }

        public CurEx_Controller(Form form)
        {
            Model = new CurEx_Model();
            View = form;
        }

        public double Convert(double amount)
        {
            double res = 0;
            try
            {
               res = Model.Convert(amount);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine("Error: {0}", outOfRange.Message);
            }
            return res;
        }

        public double Convert(string amount)
        {
            if (double.TryParse(amount, out double res))
            {
                return Convert(res);
            }
            throw new ArgumentOutOfRangeException();
            
        }

        public bool SetFrom(string currency)
        {
            bool result = false;
            foreach (var value in Model.AvailableCurrencies)
            {
                if (value == currency)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool SetTo(string currency)
        {
            bool result = false;
            foreach (var value in Model.AvailableCurrencies)
            {
                if (value == currency)
                {
                    result = true;
                }
            }
            return result;
        }

        public string[] GetAvailableCurrenciesInModel()
        {
            List<string> list = new List<string>();
            var currencies = Model.AvailableCurrencies;
            foreach (var value in currencies)
            {
                list.Add(value);
            }
            return list.ToArray();
        }
    }
}
