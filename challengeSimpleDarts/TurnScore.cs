using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challengeSimpleDarts
{
    public static class TurnScore
    {

        public static int checkScore(int dartThrow, Random random)
        {
            if (dartThrow == 0)
                checkForBullsEye(dartThrow, random);
            else
                checkForSingleDoubleTripleScore(dartThrow, random);
            return dartThrow;
        }
        public static int checkForBullsEye(int dartThrow, Random random)
        {
            int innerBullsEye = random.Next(1, 20);
            if (innerBullsEye == 1)
                dartThrow = 50;
            else
                dartThrow = 25;
            return dartThrow;
        }

        public static int checkForSingleDoubleTripleScore(int dartThrow, Random random)
        {
            int singleDoubleTripleScore = random.Next(1, 20);
            if (singleDoubleTripleScore == 2)
                dartThrow = dartThrow * 2;
            if (singleDoubleTripleScore == 3)
                dartThrow = dartThrow * 3;
            //else
              //  return dartThrow;
            return dartThrow;
        }
    }
}