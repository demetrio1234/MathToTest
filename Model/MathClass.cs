using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathToTest.Model
{
    internal class MathClass
    {
        public MathClass() { }

        public MathClass(float FirstOperand, float SecondOperand)
        {
            this.FirstOperand = FirstOperand;
            this.SecondOperand = SecondOperand;
        }

        public float FirstOperand { get; set; }
        public float SecondOperand { get; set; }

        public static float DivideParm1ByParm2(int parm1, int parm2)
        {
            float res = 1.0f * (parm1 / parm2);
            return res;
        }

        public float DivideFirstOperandBySecondOperand()
        {
            float res = 1.0f * (FirstOperand / SecondOperand);

            return res;
        }

        public static float MultiplyParm1ByParm2(int parm1, int parm2)
        {
            float res = 1.0f * (parm1 * parm2);
            return res;
        }


        public float MultiplyFirstOperandBySecondOperand()
        {
            float res = 1.0f * (FirstOperand * SecondOperand);

            return res;
        }

        public static float SubtractParm1ByParm2(int parm1, int parm2)
        {
            float res = 1.0f * (parm1 - parm2);
            return res;
        }

        public float SubtractFirstOperandBySecondOperand()
        {
            float res = 1.0f * (FirstOperand - SecondOperand);

            return res;
        }

        public static float AddParm1ByParm2(int parm1, int parm2)
        {
            float res = 1.0f * (parm1 + parm2);
            return res;
        }

        public float AddFirstOperandBySecondOperand()
        {
            float res = 1.0f * (FirstOperand + SecondOperand);

            return res;
        }

    }
}
