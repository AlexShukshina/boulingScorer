using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulingScorer
{
   public class Scorer
    {
        Frame[] throws = new Frame[10];
        int currentFrameNumber = 0;
        public int GameScore
        {
            get
            {
                CountAllFramesScore();
                return throws[currentFrameNumber].Score;
            }
        }
        public int FrameScore(int frameIndex)
        {
            CountAllFramesScore();
            return throws[frameIndex].Score;
        }
        
        public Scorer(Frame[] throws, int currentFrameNumber)
        {
            this.throws = throws;
            this.currentFrameNumber = currentFrameNumber;
        }
        private void CountAllFramesScore()
        {
            for (int i = 0; i <= currentFrameNumber; i++)
            {
                if (throws[i].Spare)
                {
                    GetScoreForSpare(i);
                }
                else if (throws[i].Strike)
                {
                    GetScoreForStrike(i);
                }
                else
                {
                    if (i == 0)
                        throws[i].Score = throws[i].SumOfPointsInFrame;
                    else
                        throws[i].Score = throws[i - 1].Score + throws[i].SumOfPointsInFrame;
                }
            }
        }
        private void GetScoreForSpare(int frameIndex)
        {
            if (frameIndex == 0)
                throws[frameIndex].Score = 10 + throws[frameIndex + 1].first;
            else
            {
                if (frameIndex == 9)
                    throws[frameIndex].Score = throws[frameIndex - 1].Score + throws[frameIndex].SumOfPointsInFrame;
                else
                    throws[frameIndex].Score = throws[frameIndex - 1].Score + 10 + throws[frameIndex + 1].first;
            }
        }

        private void GetScoreForStrike(int frameIndex)
        {
            if (frameIndex == 0)
            {
                throws[frameIndex].Score = 10 + throws[frameIndex + 1].first + throws[frameIndex + 1].Second;
                CheckNextIsAlsoStrike(frameIndex);
            }
            else
            {
                if (frameIndex == 9)
                    throws[frameIndex].Score = throws[frameIndex - 1].Score + throws[frameIndex].SumOfPointsInFrame;
                else
                {
                    throws[frameIndex].Score = throws[frameIndex - 1].Score + 10 + throws[frameIndex + 1].first + throws[frameIndex + 1].Second;
                    CheckNextIsAlsoStrike(frameIndex);
                }
            }
        }

        private void CheckNextIsAlsoStrike(int frameIndex)
        {
            if (throws[frameIndex + 1].Strike && (throws[frameIndex + 1].third < 0))
                throws[frameIndex].Score += 10;
        }
    }
}
