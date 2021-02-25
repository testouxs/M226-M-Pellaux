using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertisseur_MVC
{
    abstract class CurEx_Model_Abstract
    {
        public abstract List<string> AvailableCurrencies
        {
            get ;
        }

        public abstract string From
        {
            get;
            set;
        }

        public abstract string To
        {
            get;
            set;
        }

        public abstract double Convert(double amount);
    }
}
