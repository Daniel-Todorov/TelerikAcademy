namespace BullsAndCows.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using Microsoft.AspNet.Identity;

    using BullsAndCows.Data;
    using BullsAndCows.Models;
    using BullsAndCows.Web.Models;
    using System.Text;

    public class GuessController : BaseController
    {
        public GuessController()
            : this(new BullsAndCowsData())
        {
        }

        public GuessController(IBullsAndCowsData data)
            : base(data)
        {
        }

        [Authorize]
        [HttpPost]
        public HttpResponseMessage MakeGuess(int id, JoinGameNumberModel numberModel)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid input data");
            }
            if (IfNumberHasRepeatingDigits(numberModel.Number))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "The guess number must have unique digits.");
            }
            if (numberModel.Number.Length != 4)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "The guess number must have 4 digits.");
            }

            var game = this.data.Games.Find(id);
            if (game == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("Game with id = {0} does not exist.", id));
            }
            if (game.GameState == GameState.GameFinished || game.GameState == GameState.WaitingForOpponent)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("Game with id = {0} is not being played at the moment.", id));
            }

            var currentUserID = this.User.Identity.GetUserId();
            if (game.BluePlayerId != currentUserID && game.RedPlayerId != currentUserID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("You are not a player in game with id = {0}.", id));
            }
            if (game.BluePlayerId == currentUserID && game.GameState != GameState.BlueInTurn
                || game.RedPlayerId == currentUserID && game.GameState != GameState.RedInTurn)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "It is not your turn");
            }
            int bulls = 0;
            int cows = 0;
            if (game.BluePlayerId == currentUserID)
            {
                GetBullsAndCows(game.RedPlayerNumber, numberModel.Number, out bulls, out cows);
            }
            else
            {
                GetBullsAndCows(game.BluePlayerNumber, numberModel.Number, out bulls, out cows);
            }

            var winingNotification = new Notification()
            {
                Message = "You won the game!",
                DateCreated = DateTime.Now,
                Type = NotificationType.GameWon,
                State = NotificationState.Unread,
                GameId = game.Id,
                Game = game,
            };

            var losingNotification = new Notification()
            {
                Message = "You lost the game",
                DateCreated = DateTime.Now,
                Type = NotificationType.GameLost,
                State = NotificationState.Unread,
                GameId = game.Id,
                Game = game,
            };

            var playerTurnNotification = new Notification()
            {
                Message = string.Format("It is your turn in game {0}", game.Name),
                DateCreated = DateTime.Now,
                Type = NotificationType.YourTurn,
                State = NotificationState.Unread,
                GameId = game.Id,
                Game = game,
            };

            if (bulls == 4 && game.RedPlayerId == currentUserID)
            {
                game.GameState = GameState.GameFinished;
                game.RedPlayer.Wins++;
                winingNotification.PlayerId = game.RedPlayerId;
                winingNotification.Player = game.RedPlayer;
                game.BluePlayer.Losses++;
                losingNotification.PlayerId = game.BluePlayerId;
                losingNotification.Player = game.BluePlayer;

                this.data.Notifications.Add(winingNotification);
                this.data.Notifications.Add(losingNotification);

                this.data.SaveChanges();
            }
            else if (bulls == 4 && game.BluePlayerId == currentUserID)
            {
                game.GameState = GameState.GameFinished;
                game.BluePlayer.Wins++;
                winingNotification.PlayerId = game.BluePlayerId;
                winingNotification.Player = game.BluePlayer;
                game.RedPlayer.Losses++;
                losingNotification.PlayerId = game.RedPlayerId;
                losingNotification.Player = game.RedPlayer;

                this.data.Notifications.Add(winingNotification);
                this.data.Notifications.Add(losingNotification);

                this.data.SaveChanges();
            }
            else
            {
                if (game.GameState == GameState.BlueInTurn)
                {
                    game.GameState = GameState.RedInTurn;
                    playerTurnNotification.PlayerId = game.RedPlayerId;
                    playerTurnNotification.Player = game.RedPlayer;
                }
                else if (game.GameState == GameState.RedInTurn)
                {
                    game.GameState = GameState.BlueInTurn;
                    playerTurnNotification.PlayerId = game.BluePlayerId;
                    playerTurnNotification.Player = game.BluePlayer;
                }

                this.data.Notifications.Add(playerTurnNotification);
                this.data.SaveChanges();
            }

            var guess = new Guess()
            {
                PlayerId = currentUserID,
                Player = this.data.Users.Find(currentUserID),
                GameId = game.Id,
                Game = game,
                Number = numberModel.Number,
                DateMade = DateTime.Now,
                CowsCount = cows,
                BullsCount = bulls
            };
            this.data.Guesses.Add(guess);
            this.data.SaveChanges();

            var response = new GuessDetails()
            {
                Id = guess.Id,
                UserId = guess.PlayerId,
                Username = guess.Player.UserName,
                GameId = guess.GameId,
                Number = guess.Number,
                DateMade = guess.DateMade,
                CowsCount = guess.CowsCount,
                BullsCount = guess.BullsCount
            };

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


        private static void GetBullsAndCows(string numberToGuess, string guessNumber, out int bullsCount, out int cowsCount)
        {
            bullsCount = 0;
            cowsCount = 0;
            StringBuilder playerNumber = new StringBuilder(guessNumber);
            StringBuilder number = new StringBuilder(numberToGuess);
            for (int i = 0; i < playerNumber.Length; i++)
            {
                if (playerNumber[i] == number[i])
                {
                    bullsCount++;
                    playerNumber.Remove(i, 1);
                    number.Remove(i, 1);
                    i--;
                }
            }

            for (int i = 0; i < playerNumber.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (playerNumber[i] == number[j])
                    {
                        cowsCount++;
                        playerNumber.Remove(i, 1);
                        number.Remove(j, 1);
                        j--;
                        i--;
                        break;
                    }
                }
            }
        }

        private bool IfNumberHasRepeatingDigits(string number)
        {
            if (number[0] == number[1] || number[0] == number[2] || number[0] == number[3] || number[1] == number[2] || number[1] == number[3] || number[2] == number[3])
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
