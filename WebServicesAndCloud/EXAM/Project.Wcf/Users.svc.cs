using BullsAndCows.Data;
using BullsAndCows.Wcf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BullsAndCows.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Users" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Users.svc or Users.svc.cs at the Solution Explorer and start debugging.
    public class Users : IUsers
    {
        private IBullsAndCowsData data = new BullsAndCowsData(new BullsAndCowsContext());
        private int DefaultItemsOnPage = 10;
        
        public ICollection<TinyUserModel> GetUserByPage(int page)
        {
            var users = this.data.Users.All()
                .OrderBy(user => user.UserName)
                .Skip(page * 10)
                .Take(DefaultItemsOnPage);

            var usersToModel = users.Select(user => new TinyUserModel()
            {
                Id = user.Id,
                Username = user.UserName
            }).ToList();

            return usersToModel;
        }

        public LargeUserModel GetUserById(string id)
        {
            var user = this.data.Users.Find(id);

            var userToModel = new LargeUserModel()
            {
                Id = user.Id,
                Losses = user.Losses,
                Wins = user.Wins,
                Username = user.UserName,
                Rank = 100 * user.Wins + 15 * user.Losses
            };

            return userToModel;
        }
    }
}
