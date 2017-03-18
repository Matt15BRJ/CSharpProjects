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

        public void playDartGame(Game player1, Game player2, Random random)
        {
            while (player1.Score < 300 && player2.Score < 300)
            {
                takeATurn(player1, random);
                takeATurn(player2, random);
            }
        }

        public void takeATurn(Game player, Random random)
        {
            Dart playerTurn = new Dart();
            for (int i = 0; i < 3; i++)
            {
                playerTurn.Throw(random);
                TurnScore.checkScore(playerTurn, player);                
            }            
        }
    }
}