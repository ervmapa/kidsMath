using System;
using System.Drawing;

namespace WindowsFormsApp4
{
    public class ExpressionMinus : Expression
    {

        public ExpressionMinus()
        {
            Op = Operator.PLUS;
            operatorSymbol = "-";
            color = Color.LightGreen;
        }

        public override void SetMode(GameMode mode, Granularity granularity)
        {
            this.mode = mode;
            Xval = GenRand(xmax);
            Yval = GenRand(ymax);

            // Swap to avoid negative numbers
            if (Xval - Yval <0)
            {
                int tmp = Xval;
                Yval = Xval;
                Xval = Yval;
            }

            if (granularity != Granularity.ONE)
            {
                Xval = Xval.Round((int)granularity);
                Yval = Yval.Round((int)granularity);
            }

            Zval = Xval - Yval;
        }
    }

}
