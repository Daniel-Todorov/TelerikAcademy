namespace TicTacToe.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using TicTacToe.Data;
    using TicTacToe.Web.DataModels;

    public class LeaderBoardController : BaseApiController
    {
        public LeaderBoardController(ITicTacToeData data)
            : base(data)
        {
        }

        //I Don't think there is need to authorize this method
        [HttpGet]
        public IHttpActionResult GetLeaderboard()
        {
            var topTenUsers = this.data.Users
                .All()
                .Select(user => new LeaderboardUserDataModel()
                {
                    Username = user.UserName,
                    Rank = 100 * user.Wins + 20 * user.Draws + 4 * user.Losses
                })
                .OrderByDescending(userModel => userModel.Rank)
                .Take(10)
                .ToList();

            return Ok(topTenUsers);
        }
    }
}