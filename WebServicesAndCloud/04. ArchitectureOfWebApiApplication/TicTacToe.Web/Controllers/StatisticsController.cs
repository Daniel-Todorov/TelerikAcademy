namespace TicTacToe.Web.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using TicTacToe.Data;
    using TicTacToe.Models;

    public class StatisticsController : BaseApiController
    {
        public StatisticsController(ITicTacToeData data)
            : base(data)
        {
        }

        [HttpGet]
        public IHttpActionResult GetAllPlayedGames()
        {
            var allPlayedGames = this.data.Games
                .All()
                .Count(game => game.State == GameState.Draw || game.State == GameState.WonByO || game.State == GameState.WonByX);

            return Ok(allPlayedGames);
        }

        [HttpGet]
        public IHttpActionResult GetNumberOfAllUsers()
        {
            var allUsers = this.data.Users
                .All()
                .Count();

            return Ok(allUsers);
        }
    }
}
