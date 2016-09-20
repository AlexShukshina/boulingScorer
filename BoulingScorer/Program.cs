using System;


namespace BoulingScorer
{
    class Program
    {
        static void Main(string[] args)
        {

            GameTest test = new GameTest();
            test.TestEndOfArray();
            test.TestFourThrowsNoMark();
            test.TestHeartBreak();
            test.TestPerfectGame();
            test.TestSampleGame();
            test.TestSimpleFrameAfterSpare();
            test.TestSimpleSpare();
            test.TestSimpleStrike();
            test.TestTenthFrameSpare();
            test.TestTwoThrowsNoMark();


            Console.ReadLine();
        }
       
        
    }        
 }
