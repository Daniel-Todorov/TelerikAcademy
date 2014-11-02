namespace BullsAndCows.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using Microsoft.AspNet.Identity;

    using BullsAndCows.Data;
    using BullsAndCows.Models;
    using BullsAndCows.Web.Models;

    public class GamesController : BaseController
    {
        private const int DefaultItemsOnPage = 10;
        private Random random;

        public GamesController()
            : this(new BullsAndCowsData())
        {
        }

        public GamesController(IBullsAndCowsData data)
            : base(data)
        {
            this.random = new Random();
        }

        /// <summary>
        /// When used by unauthorised user returns number of games waiting for opponent.
        /// When used by autorised user returns number of games waiting for opponent and games which the user play.
        /// </summary>
        /// <param name="page">Optional. Counts from 0.</param>
        /// <returns>Http status OK and List of 10 games max if the number of games on the page is > 0. Http status BadRequest if that number is 0 or less.</returns>
        [HttpGet]
        public HttpResponseMessage GetGamesUnauthorised(int page = 0)
        {
            //If the user is not authorised, currentUserId will be null.
            var currentUserID = this.User.Identity.GetUserId();

            if (currentUserID == null)
            {
                var allAvailableToJoinGames = this.data.Games
                .All()
                .Where(game => game.GameState == GameState.WaitingForOpponent)
                .OrderBy(game => game.Name)
                .ThenBy(game => game.DateCreated)
                .ThenBy(game => game.RedPlayer.UserName);

                var requestedGames = allAvailableToJoinGames
                    .Skip(page * 10)
                    .Take(DefaultItemsOnPage)
                    .Select(game => new { Id = game.Id, Name = game.Name, Blue = game.BluePlayer.UserName == null ? "No blue player yet" : game.BluePlayer.UserName, Red = game.RedPlayer.UserName, GameState = game.GameState, DateCreated = game.DateCreated })
                    .ToList();

                if (requestedGames.Count <= 0)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("No games waiting for opponent at page {0}", page + 1));
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, requestedGames);
                }
            }
            else
            {
                var allAvailableToJoinGames = this.data.Games
                    .All()
                    .Where(game => game.GameState == GameState.WaitingForOpponent || game.BluePlayerId == currentUserID || game.RedPlayerId == currentUserID)
                    .OrderBy(game => game.GameState)
                    .ThenBy(game => game.Name)
                    .ThenBy(game => game.DateCreated)
                    .ThenBy(game => game.RedPlayer.UserName);

                var requestedGames = allAvailableToJoinGames
                    .Skip(page * 10)
                    .Take(DefaultItemsOnPage)
                    .Select(game => new { Id = game.Id, Name = game.Name, Blue = game.BluePlayer.UserName == null ? "No blue player yet" : game.BluePlayer.UserName, Red = game.RedPlayer.UserName, GameState = game.GameState.ToString(), DateCreated = game.DateCreated })
                    .ToList();

                if (requestedGames.Count <= 0)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("No games waiting for opponent at page {0}", page + 1));
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, requestedGames);
                }
            }
        }

        [Authorize]
        [HttpGet]
        public HttpResponseMessage GetGameDetails(int id)
        {
            var currentUserID = this.User.Identity.GetUserId();
            var game = this.data.Games.Find(id);

            if (game == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("Game with id = {0} does not exist.", id));
            }
            if (game.GameState == GameState.GameFinished || game.GameState == GameState.WaitingForOpponent)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("Game with id = {0} is not currently played.", id));
            }

            var gameDetails = new GameDetails()
            {
                Id = game.Id,
                Name = game.Name,
                DateCreated = game.DateCreated,
                Red = game.RedPlayer.UserName,
                Blue = game.BluePlayer.UserName,
                YourNumber = game.RedPlayerId == currentUserID ? game.RedPlayerNumber : game.BluePlayerNumber,
                YourGuesses = game.Guesses.Where(guess => guess.PlayerId == currentUserID).Select(guess => new GuessDetails()
                    {
                        Id = guess.Id,
                        UserId = guess.PlayerId,
                        Username = guess.Player.UserName,
                        GameId = guess.GameId,
                        Number = guess.Number,
                        DateMade = guess.DateMade,
                        CowsCount = guess.CowsCount,
                        BullsCount = guess.BullsCount
                    }).ToList(),
                OpponentGuesses = game.Guesses.Where(guess => guess.PlayerId != currentUserID).Select(guess => new GuessDetails()
                    {
                        Id = guess.Id,
                        UserId = guess.PlayerId,
                        Username = guess.Player.UserName,
                        GameId = guess.GameId,
                        Number = guess.Number,
                        DateMade = guess.DateMade,
                        CowsCount = guess.CowsCount,
                        BullsCount = guess.BullsCount
                    }).ToList(),
                YourColor = game.RedPlayerId == currentUserID ? "red" : "blue",
                GameState = game.GameState.ToString()
            };


            return Request.CreateResponse(HttpStatusCode.OK, gameDetails);
        }

        [Authorize]
        [HttpPost]
        public HttpResponseMessage CreateGame([FromBody] RawGameDetails rawGameDetails)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid data received in post body.");
            }

            if (IfNumberHasRepeatingDigits(rawGameDetails.Number))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "The number must have unique digits.");
            }

            var currentUserID = this.User.Identity.GetUserId();
            var newGame = new Game()
            {
                Name = rawGameDetails.Name,
                RedPlayer = this.data.Users.Find(currentUserID),
                RedPlayerId = currentUserID,
                RedPlayerNumber = rawGameDetails.Number,
                GameState = GameState.WaitingForOpponent,
                DateCreated = DateTime.Now
            };

            this.data.Games.Add(newGame);
            this.data.SaveChanges();

            var responseModel = new GameResponseModel()
            {
                Id = newGame.Id,
                Name = newGame.Name,
                Blue = "No blue player yet",
                Red = newGame.RedPlayer.UserName,
                GameState = newGame.GameState.ToString(),
                DateCreated = newGame.DateCreated
            };

            return Request.CreateResponse(HttpStatusCode.Created, responseModel);
        }

        [Authorize]
        [HttpPut]
        public HttpResponseMessage JoinGame(int id, JoinGameNumberModel numberModel)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "The game must have a number.");
            }

            string number = numberModel.Number;
            if (IfNumberHasRepeatingDigits(number))
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "The number must have unique digits.");
            }

            var game = this.data.Games.Find(id);
            if (game == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("Game with id = {0} does not exist.", id));
            }
            if (game.GameState != GameState.WaitingForOpponent)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("Game with id = {0} has already started.", id));
            }

            var currentUserID = this.User.Identity.GetUserId();
            if (game.RedPlayerId == currentUserID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, string.Format("You have already joined game with id = {0}.", id));
            }

            game.BluePlayerNumber = number;
            game.BluePlayerId = currentUserID;
            game.BluePlayer = this.data.Users.Find(currentUserID);
            //this.data.SaveChanges();

            var newOpponentNotification = new Notification()
            {
                Message = string.Format("{0} joined your game.", this.User.Identity.Name),
                DateCreated = DateTime.Now,
                Type = NotificationType.GameJoined,
                State = NotificationState.Unread,
                GameId = game.Id,
                Game = game,
                PlayerId = game.RedPlayerId,
                Player = game.RedPlayer
            };
            this.data.Notifications.Add(newOpponentNotification);
            this.data.SaveChanges();

            var playerTurnNotification = new Notification()
            {
                Message = string.Format("It is your turn in game {0}", game.Name ),
                DateCreated = DateTime.Now,
                Type = NotificationType.YourTurn,
                State = NotificationState.Unread,
                GameId = game.Id,
                Game = game,
            };

            var randomNumber = this.random.Next(1, 11);
            if (randomNumber <= 5)
            {
                game.GameState = GameState.BlueInTurn;
                playerTurnNotification.PlayerId = game.BluePlayerId;
                playerTurnNotification.Player = game.BluePlayer;
            }
            else
            {
                game.GameState = GameState.RedInTurn;
                playerTurnNotification.PlayerId = game.RedPlayerId;
                playerTurnNotification.Player = game.RedPlayer;
            }
            this.data.Notifications.Add(playerTurnNotification);

            this.data.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK, new GameCreatedResponseModel() { Result = string.Format("You joined game \"{0}\"", game.Name)});
        }

        private bool IfNumberHasRepeatingDigits(string number)
        {
            if (number[0] == number[1] ||  number[0] == number[2] || number[0] == number[3] || number[1] == number[2] || number[1] == number[3] || number[2] == number[3])
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
