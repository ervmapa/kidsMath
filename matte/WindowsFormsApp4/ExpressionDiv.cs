using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;


namespace WindowsFormsApp4
{

    public class ExpressionDiv : Expression
    {

        public ExpressionDiv()
        {
            Op = Operator.DIV;
            operatorSymbol = "/";
            color = Color.LightCyan;
        }

        public override void Set_level(int lev)
        {
            level = lev;
            xmax = level+1;
            ymax = level+2;
        }

        public override void SetMode(GameMode mode, Granularity granularity)
        {
            this.mode = mode;

            // Slumpa fram X först
            int Xtmp = GenRand(xmax) + 1;

            // Slumpa fram Z
            int Ztmp = Xtmp * GenRand(ymax); 

            // Räkna fram Y 
            int Ytmp= Ztmp / Xtmp;

            // Kasta runt
            xval = Ztmp;
            yval = Ytmp;
            zval = Xtmp;

            if (granularity != Granularity.ONE)
            {
                Xval = Xval.Round((int)granularity);
                Yval = Yval.Round((int)granularity);
            }

        }


    }
}
