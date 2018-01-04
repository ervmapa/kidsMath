///
/// Mats Palm
/// 
using System.Drawing;

namespace WindowsFormsApp4
{
    /// <summary>
    /// Class for Addition
    /// </summary>
    public class ExpressionAdd : Expression
    {

        public ExpressionAdd()
        {
            Op = Operator.PLUS;
            operatorSymbol = "+";
            color = Color.LightBlue;
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

            Zval = Xval + Yval;
        }
    }
}
