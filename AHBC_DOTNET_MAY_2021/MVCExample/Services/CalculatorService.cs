using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExample.Services
{
    public class CalculatorService
    {
        public CalculatorService()
        {
              
        }
        public Calculator GetCalculation(string num1, string num2, char operation)
        {
            int num11 = Int32.Parse(num1);
            int num22 = Int32.Parse(num2);
            int totes;
            char ops = operation;
            switch (ops)
            {
                case ('+'):
                    totes = num11 + num22;
                    break;
                case ('-'):
                    totes = num11 - num22;
                    break;
                case ('*'):
                    totes = num11 * num22;
                    break;
                default:
                    totes = num11 / num22;
                    break;
            }
            return new Calculator
            {
                Num1 = num11,
                Num2 = num22,
                Operation = ops,
                Result = totes
            };
        }
    }
}
