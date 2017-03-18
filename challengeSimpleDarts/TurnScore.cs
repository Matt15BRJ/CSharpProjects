using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace challengeSimpleDarts
{
    public static class TurnScore
    {
        public static void checkScore(Dart playerTurn, Game player)
        {
            int dartScore = playerTurn.DartThrowScore;
            if (playerTurn.DartThrowScore == 0)
                checkForBullsEye(playerTurn, dartScore);
            if (playerTurn.DartThrowScore != 0)
                checkForSingleDoubleTripleScore(playerTurn, dartScore);            
            player.Score += dartScore;            
        }
        public static void checkForBullsEye(Dart playerTurn, int dartScore)
        {
            if (playerTurn.isInnerBullsEye)
                dartScore = 50;
            else
                dartScore = 25;            
        }

        public static void checkForSingleDoubleTripleScore(Dart playerTurn, int dartScore)
        {
            if (playerTurn.isDoubleRing)
                dartScore = playerTurn.DartThrowScore * 2;
            if (playerTurn.isTripleRing)
                dartScore = playerTurn.DartThrowScore * 3;            
        }
    }
}