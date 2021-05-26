using System;
namespace TicTacToes.components
{
    public class GameLogic
    {
        public class winnerSqs{
	    public string playerWon = ""; 
	    public string cols = ""; 
	    public string sqs = ""; 
	    public string direction = ""; 
	 }
        public GameLogic(string[] gameboard)
        {
                int[] playerOne = {1, 2};
   //let winnerSqs: WinnerSqsTypes;

   for (int num = 0; num < playerOne.Length; num++)
                {

                    for (int col = 0; col < 3; col++)
                    {
                        if (gameboard[col][0] == playerOne[num] &
			 gameboard[col][1] == playerOne[num] &
          gameboard[col][2] == playerOne[num])
                        {

			     winnerSqs["playerWon"] ="p{ num + 1}";
winnerSqs[col] = cols;

			      { playerWon: $"p{ num + 1}", cols:[col], sqs:['sq0', 'sq1', 'sq2'], direction: WinningDirection.horizontal }
                            return winnerSqs
                        }
                    }
                    for (let square = 0; square < 3; square++)
                    {
                        if (
                           gameboard[0][`sq${ square}`] === playerOne[num] &&
                            gameboard[1][`sq${ square}`] === playerOne[num] &&
                             gameboard[2][`sq${ square}`] === playerOne[num]) {
                    winnerSqs = { playerWon: `p${ num + 1}`, cols:[0, 1, 2], sqs:[`sq${ square}`], direction: WinningDirection.vertical }
                    return winnerSqs
                           }
            }
            if (
               gameboard[0].sq0 == playerOne[num] &
               gameboard[1].sq1 == playerOne[num] &
               gameboard[2].sq2 == playerOne[num]
            )
            {
                winnerSqs = { playerWon: `p${ num + 1}`, cols:[0, 1, 2], sqs:[], direction: WinningDirection.leftToRightAcross }
                return winnerSqs
            }
            if (
               gameboard[0].sq2 === playerOne[num] &&
               gameboard[1].sq1 === playerOne[num] &&
               gameboard[2].sq0 === playerOne[num]
            )
            {
                winnerSqs = { playerWon: `p${ num + 1}`, cols:[0, 1, 2], sqs:[], direction: WinningDirection.rightToLeftAcross }
                return winnerSqs
            }

        }
   return
}
}
    }
}
