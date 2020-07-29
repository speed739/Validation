using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Validacja.Command;
using Validacja.Model;
using Validacja.Validation;

namespace Validacja.ViewModel
{
    public class MW_ViewModel
    {
        public MW_Model MW_Model { get; set; }
        public ICommand MW_Command  { get; set; }
        public MW_Model_Validation Validation { get; set; }
        public MW_ViewModel()
        {
            MW_Model = new MW_Model();
            Validation = new MW_Model_Validation();
            MW_Command = new MW_Command();
        }
    }
}