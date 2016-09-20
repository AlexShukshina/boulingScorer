using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulingScorer
{
     public class Frame
    {
        private bool strike;
        private bool spare;

        public int first;
        private int second;
        public int third;

        private int score;


        public int Second
        {
            get
            {
                if (strike && second == -1)
                    return 0;
                return second;
            }
        }

        public bool Strike { get { return strike; } }
        public bool Spare { get { return spare; }}
        public int Score { get { return score; } set { score = value; } }
        public Frame()
        {
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            first = -1;
            second = -1;
            third = -1;
            score = -1;
            strike = false;
            spare = false;
        }

        public Frame(int val)
        {
            SetDefaultValues();
            SetValue(val);
        }
        public void SetValue(int val)
        {
            if (this.first == -1)
                this.first = val;
            else if (this.second == -1)
                this.second = val;
            else
                this.third = val;

            if (val == 10 && third < 0)
                this.strike = true;
            else if (first + second == 10)
                spare = true;
        }
        public int SumOfPointsInFrame
        {
            get
            {
                if (strike && (third >= 0))
                    return 10 + second + third;
                if (strike && third < 0)
                    return 10;
                if (spare && third >= 0)
                    return 10 + third;
                return first + second;
            }
        }
            
    }
}
