using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacja.Model;

namespace Validacja.Validation
{
    /*Dodać dziedzicze z  AbstractValidator<klasa którą poddajemy walidacji>  */
    public class MW_Model_Validation : AbstractValidator<MW_Model>
    {
        /*Utworzyć konstruktor a w nim zaimplementować szereg reguł walidacji*/
        public MW_Model_Validation()
        {
            /*Określić CascadeMode, jest to tryb działania validacji np StopOnFirstFailure zatrzymuje validacje w chwili napotkania 1 niezgodności */
            CascadeMode = CascadeMode.StopOnFirstFailure;
            
            /*Implementacja zasad validacji dla kontrolki RuleFor*/
            RuleFor(x => x.Login)
                .NotNull()
                .NotEmpty()
                .Length(4, 8)
                .WithMessage("Login can't been empty, Length between 4-8 char");

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .WithMessage("Password can't be empty");
        }
    }
}
