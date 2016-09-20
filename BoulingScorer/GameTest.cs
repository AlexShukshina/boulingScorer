using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulingScorer
{
    class GameTest
    {
        private Game game;
        public void SetUp()
        {
            game = new Game();
        }

        public void TestTwoThrowsNoMark()
        {
            SetUp();
            game.Add(5);
            game.Add(4);
            Console.WriteLine("TestTwoThrowsNoMark");
            Console.WriteLine(valuesEquals(9, game.Score));
        }

        public void TestFourThrowsNoMark()
        {
            SetUp();
            game.Add(5);
            game.Add(4);
            game.Add(7);
            game.Add(2);

            Console.WriteLine("TestFourThrowsNoMark");
            Console.WriteLine(valuesEquals(18, game.Score));
            Console.WriteLine(valuesEquals(9, game.GetFrameScore(0)));
            Console.WriteLine(valuesEquals(18, game.GetFrameScore(1)));
        }

        public void TestSimpleSpare()
        {
            SetUp();
            game.Add(3);
            game.Add(7);
            game.Add(3);

            Console.WriteLine("TestSimpleSpare");
            Console.WriteLine(valuesEquals(13, game.GetFrameScore(0)));
        }

        public void TestSimpleFrameAfterSpare()
        {
            SetUp();
            game.Add(3);
            game.Add(7);
            game.Add(3);
            game.Add(2);

            Console.WriteLine("TestSimpleFrameAfterSpare");
            Console.WriteLine(valuesEquals(13, game.GetFrameScore(0)));
            Console.WriteLine(valuesEquals(18, game.GetFrameScore(1)));
            Console.WriteLine(valuesEquals(18, game.Score));
        }

        public void TestSimpleStrike()
        {
            SetUp();
            game.Add(10);
            game.Add(3);
            game.Add(6);

            Console.WriteLine("TestSimpleStrike");
            Console.WriteLine(valuesEquals(19, game.GetFrameScore(0)));
            Console.WriteLine(valuesEquals(28, game.Score));
        }

        public void TestPerfectGame()
        {
            SetUp();
            for (int i = 0; i<12; i++)
            {
                game.Add(10);
            }
            Console.WriteLine("TestPerfectGame");
            Console.WriteLine(valuesEquals(300, game.Score));
        }

        public void TestEndOfArray()
        {
            SetUp();
            for (int i=0; i<9; i++)
            {
                game.Add(0);
                game.Add(0);
            }
            game.Add(2);
            game.Add(8);
            game.Add(10);

            Console.WriteLine("TestEndOfArray");
            Console.WriteLine(valuesEquals(20, game.Score));
        }

        public void TestSampleGame()
        {
            SetUp();
            game.Add(1);
            game.Add(4);
            game.Add(4);
            game.Add(5);
            game.Add(6);
            game.Add(4);
            game.Add(5);
            game.Add(5);
            game.Add(10);
            game.Add(0);
            game.Add(1);
            game.Add(7);
            game.Add(3);
            game.Add(6);
            game.Add(4);
            game.Add(10);
            game.Add(2);
            game.Add(8);
            game.Add(6);

            Console.WriteLine("TestSampleGame");
            Console.WriteLine(valuesEquals(133, game.Score));
        }

        public void TestHeartBreak()
        {
            SetUp();
            for (int i = 0; i < 11; i++)
                game.Add(10);

            game.Add(9);
            Console.WriteLine("TestHeartBreak");
            Console.WriteLine(valuesEquals(299, game.Score));
        }


        public void TestTenthFrameSpare()
        {
            SetUp();
            for (int i=0; i<9;i++)
            {
                game.Add(10);
            }
            game.Add(9);
            game.Add(1);
            game.Add(0);

            Console.WriteLine("TestTenthFrameSpare");
            Console.WriteLine(valuesEquals(270, game.Score));
        }

        public bool valuesEquals(int i1, int i2)
        {
            return Int32.Equals(i1, i2);
        }

    }
}
