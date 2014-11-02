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

    public class ScoresController : BaseController
    {
        private int NumberOfPlayersInHighScoreBoard = 10;

        public ScoresController()
            : this(new BullsAndCowsData())
        {
        }

        public ScoresController(IBullsAndCowsData data)
            : base(data)
        {
        }

        [HttpGet]
        public HttpResponseMessage GetHighScores()
        {
            var users = this.data.Users
                .All()
                .Select(user => new HighCoreUserModel() { Username = user.UserName, Rank = 100 * user.Wins + 15 * user.Losses })
                .OrderByDescending(userModel => userModel.Rank)
                .ThenBy(userModel => userModel.Username)
                .Take(NumberOfPlayersInHighScoreBoard)
                .ToList();

            return Request.CreateResponse(HttpStatusCode.OK, users);
        }
    }
}
