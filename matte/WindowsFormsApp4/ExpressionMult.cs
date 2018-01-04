using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;


namespace WindowsFormsApp4
{

    public class ExpressionMult : Expression
    {

        public ExpressionMult()
        {
            Op = Operator.MULT;
            operatorSymbol = "x";
            color = Color.Yellow;
        }

        public override void Set_level(int lev)
        {
            level = lev;
            Console.WriteLine(level);
            xmax = level * 2;
            ymax = level * 2;
        }

        public override void SetMode(GameMode mode, Granularity granularity)
        {
            this.mode = mode;
            Xval = GenRand(xmax);
            Yval = GenRand(ymax);

            if (granularity != Granularity.ONE)
            {
                Xval = Xval.Round((int)granularity);
                Yval = Yval.Round((int)granularity);
            }

            Zval = Xval * Yval;
        }


    }
}
