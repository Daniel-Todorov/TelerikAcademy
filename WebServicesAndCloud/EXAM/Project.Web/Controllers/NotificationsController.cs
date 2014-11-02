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

    public class NotificationsController : BaseController
    {
        private int DefaultItemsOnPage = 10;

        public NotificationsController()
            : this(new BullsAndCowsData())
        {
        }

        public NotificationsController(IBullsAndCowsData data)
            : base(data)
        {
        }

        [Authorize]
        [HttpGet]
        public HttpResponseMessage GetNotificationsByPage(int page = 0)
        {
            var currentUserID = this.User.Identity.GetUserId();

            var notificationsForUser = this.data.Notifications
                .All()
                .Where(notification => notification.PlayerId == currentUserID)
                .OrderByDescending(notification => notification.DateCreated)
                .Skip(page * 10)
                .Take(DefaultItemsOnPage);

            var notificationsToModels = notificationsForUser.Select(notification => new NotificationModel()
                {
                    Id = notification.Id,
                    Message = notification.Message,
                    DateCreated = notification.DateCreated,
                    Type = notification.Type.ToString(),
                    State = notification.State.ToString(),
                    GameId = notification.GameId
                }).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, notificationsToModels);
        }

        [Authorize]
        [HttpGet]
        public HttpResponseMessage GetNextNotification(string id)
        {
            if (id != "next")
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No such service exists");
            }
            var currentUserID = this.User.Identity.GetUserId();

            var oldestUnreadNotification = this.data.Notifications
                .All()
                .Where(notification => notification.State == NotificationState.Unread)
                .OrderBy(notification => notification.DateCreated)
                .FirstOrDefault();

            if (oldestUnreadNotification == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }

            var notificationtoModel = new NotificationModel()
            {
                Id = oldestUnreadNotification.Id,
                Message = oldestUnreadNotification.Message,
                DateCreated = oldestUnreadNotification.DateCreated,
                Type = oldestUnreadNotification.Type.ToString(),
                State = oldestUnreadNotification.State.ToString(),
                GameId = oldestUnreadNotification.GameId
            };

            return Request.CreateResponse(HttpStatusCode.OK, notificationtoModel);
        }
    }
}
