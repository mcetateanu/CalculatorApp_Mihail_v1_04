using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_Mihail_v1_04
{
    class CalculatorHelper
    {
        
        public decimal Add, Substract, Multiply, Divide;
        public decimal term1, term2;
        public Boolean Flag;

       public CalculatorHelper ( decimal termen1, decimal termen2)
        {
            Flag = false;
           term1 = termen1;
            term2 = termen2;
           
            Add = (term1 + term2);
            Substract = (term1 - term2);
            Multiply = (term1 * term2);
            if (term2 == 0)
            {

                Flag = true;
                Divide = -1;
            }
            else
            Divide = (term1 / term2);
        }
    }
}
