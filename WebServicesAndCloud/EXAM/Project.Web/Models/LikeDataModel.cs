using BullsAndCows.Data;
using BullsAndCows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Articles.Web.DataModels
{
    public class LikeDataModel
    {
        public static Expression<Func<Notification, LikeDataModel>> FromLike
        {
            get
            {
                return like => new LikeDataModel
                {
                    ID = like.Id,
                    DateCreated = like.DateCreated,
                    AuthorName = like.User.UserName
                };
            }
        }

        public int ID { get; set; }

        public DateTime DateCreated { get; set; }

        public string AuthorName { get; set; }
    }
}