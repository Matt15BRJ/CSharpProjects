using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace challengeSimpleDarts
{
    public class Game
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public int takeATurn(int turnScore, Random random)
        {
            Dart playerTurn = new Dart();
            for (int i = 0; i < 3; i++)
            {
                int dartThrow= playerTurn.Throw(random);
                turnScore += TurnScore.checkScore(dartThrow, random);
            }
            return turnScore;
        }
    }
}