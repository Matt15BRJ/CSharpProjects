using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace challengeSimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void throwButton_Click(object sender, EventArgs e)
        {
            Game player1 = new Game();
            Game player2 = new Game();
            getPlayerInfo(player1, player2);
            playDartGame(player1,player2);
            displayScore(player1, player2);
            displayWinner(player1,player2);
        }        

        private void getPlayerInfo(Game player1, Game player2)
        {
            player1.PlayerName = player1NameTextBox.Text;
            player1.Score = 0;
            player2.PlayerName = player2NameTextBox.Text;
            player2.Score = 0;
        }

        private void playDartGame(Game player1, Game player2)
        {
            while (player1.Score < 300 && player2.Score < 300)
            {
                player1.Score = player1.takeATurn(player1.Score, random);
                player2.Score = player2.takeATurn(player2.Score, random);
            }
        }

        private void displayScore(Game player1, Game player2)
        {
            resultLabel.Text = String.Format("<p>{0} Score: {1}<br/>{2} Score: {3}</p>",
                player1.PlayerName, player1.Score, player2.PlayerName, player2.Score);
        }

        private void displayWinner(Game player1, Game player2)
        {
            if (player1.Score > player2.Score)
                resultLabel.Text += String.Format("{0} has won the game with a score of {1}", player1.PlayerName, player1.Score);
            else if (player2.Score > player1.Score)
                resultLabel.Text += String.Format("{0} has won the game with a score of {1}", player2.PlayerName, player2.Score);
            else
                resultLabel.Text += "You have tied.";
        }
    }
}