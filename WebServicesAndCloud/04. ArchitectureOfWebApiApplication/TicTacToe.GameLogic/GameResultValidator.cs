namespace TicTacToe.GameLogic
{
    public class GameResultValidator : IGameResultValidator
    {
        // O-X
        // O-X
        // --X
        public GameResult GetResult(string board)
        {
            if (this.IsThereWinner(board, 'X'))
            {
                return GameResult.WonByX;
            }
            else if (IsThereWinner(board, 'O'))
            {
                return GameResult.WonByO;
            }
            else if (!board.Contains("-"))
            {
                return GameResult.Draw;
            }

            return GameResult.NotFinished;
        }

        private bool IsThereWinner(string board, char winnerSign)
        {
            if (
                (board[0] == board[1] && board[0] == board[2] && board[0] == winnerSign)
                || (board[3] == board[4] && board[3] == board[5] && board[3] == winnerSign)
                || (board[6] == board[7] && board[6] == board[8] && board[6] == winnerSign)
                || (board[0] == board[4] && board[0] == board[8] && board[0] == winnerSign)
                || (board[2] == board[4] && board[2] == board[6] && board[2] == winnerSign)
                || (board[0] == board[3] && board[0] == board[6] && board[0] == winnerSign)
                || (board[1] == board[4] && board[1] == board[7] && board[1] == winnerSign)
                || (board[2] == board[5] && board[2] == board[8] && board[2] == winnerSign)
               )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
