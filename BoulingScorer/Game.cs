using System;
using System.Collections;

namespace BoulingScorer
{
    internal class Game
    {
        Frame[] throws = new Frame[10];
        private Scorer scorer;
        int currentFrame;
        public Game()
        {
            currentFrame = 0;
        }

        internal void Add(int val)
        {
            if (throws[currentFrame] == null)
            {
                StartNewFrame(val);
            }
            else
            {
                AddThrowToCurrentFrame(val);
            }

        }

        private void AddThrowToCurrentFrame(int val)
        {
            throws[currentFrame].SetValue(val);
            if (currentFrame != 9)
                currentFrame++;
        }

        private void StartNewFrame(int val)
        {
            throws[currentFrame] = new Frame();
            throws[currentFrame].SetValue(val);
            if (val == 10 && (currentFrame != 9))
                currentFrame++;
        }

        internal int Score
        {
            get
            {
                SetRightCurrentFrame();
                scorer = new Scorer(throws, currentFrame);
                return scorer.GameScore;
            }
        }

        internal int GetFrameScore(int frameIndex)
        {
            SetRightCurrentFrame();
            scorer = new Scorer(throws, currentFrame);
            return scorer.FrameScore(frameIndex);
        }

        private void SetRightCurrentFrame()
        {
            if (throws[currentFrame] == null)
                currentFrame--;
        }

    }
}