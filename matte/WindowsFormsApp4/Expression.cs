using System;
using System.Drawing;

namespace WindowsFormsApp4
{

    public abstract class Expression
    {
        protected Color color;
        protected int xval = -1;
        protected int xmax = 10;
        protected int yval = -1;
        protected int ymax = 10;
        protected int zval = -1;
        protected int zmax = 10;

        protected GameMode mode;

        public static Random random = new Random();

        private Operator op = Operator.PLUS;
        protected string operatorSymbol;

        protected int level;
        protected int OPERAND_LEVEL_STEP = 5;

        public int Xmax { get => xmax; set => xmax = value; }
        public int Ymax { get => ymax; set => ymax = value; }
        public int Zmax { get => zmax; set => zmax = value; }
        public Operator Op { get => op; set => op = value; }
        public GameMode Mode { get => mode; set => mode = value; }
        public int Xval { get => xval; set => xval = value; }
        public int Yval { get => yval; set => yval = value; }
        public int Zval { get => zval; set => zval = value; }
        public string OperatorSymbol { get => operatorSymbol; set => operatorSymbol = value; }
        public Color Color { get => color; set => color = value; }

        public virtual void Set_level(int lev)
        {
            level = lev;
            Console.WriteLine(level);
            xmax = level * OPERAND_LEVEL_STEP;
            ymax = level * OPERAND_LEVEL_STEP;
        }

        /// <summary>
        /// Generate a x value between 0 and max
        /// </summary>
        public int GenRand(int max)
        {
            return random.Next(1, max + 1);
        }


        public abstract void SetMode(GameMode mode, Granularity gran);




    }
}
