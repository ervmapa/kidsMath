using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ExpressionFactory
    {

        public Expression GetExpression(Operator op)
        {
            switch (op)
            {   
                case Operator.PLUS:
                    return new ExpressionAdd();
                case Operator.MINUS:
                    return new ExpressionMinus();
                case Operator.MULT:
                    return new ExpressionMult();
                case Operator.DIV:
                    return new ExpressionDiv();
                default:
                    return new ExpressionAdd();

            }




        }




    }
}
