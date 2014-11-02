using BullsAndCows.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BullsAndCows.Web.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected IBullsAndCowsData data;

        protected BaseController(IBullsAndCowsData data)
        {
            this.data = data;
        }
    }
}