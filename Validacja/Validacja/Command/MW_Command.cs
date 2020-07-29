using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Validacja.Model;
using Validacja.Validation;

namespace Validacja.Command
{
    /*Implementacja Interfejsu ICommand*/
    /*Dziedzicz po ICommnad oraz zaimplementuj zawarte w nim metody*/
    public class MW_Command : ICommand
    {
        public MW_Model_Validation Validations;

        /*Zwraca true jeśli wszystkie warunki zostały spełnione np. Validacja*/
        public bool CanExecute(object parameter)
        {
            /*Sprawdzam czy przekazany paramentr nie jest nullem*/
            if (parameter != null)
            {
                /*Sprawdzam czy parametr jest odpowiedniego typu*/
                if (parameter is object && parameter is MW_Model)
                {
                    /*przeprowadzam żądane operacje na moim parametrze*/
                    var result = parameter as MW_Model;
                    Validations = new MW_Model_Validation();
                    if (Validations.Validate(result).IsValid)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        /*Zapytać co to dokładnie robi */
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter)
        {

        }
    }
}
