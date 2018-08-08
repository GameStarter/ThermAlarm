using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ThermAlarmBackEndAPI;
namespace ThermAlarm_BackEnd_API.Controllers
{
    [Produces("application/json")]
    [Route("api/WebApp")]
    public class WebAppController : Controller
    {

        [HttpPost]
        public IHttpActionResult Post(IdentityUser user)
        {
            SQLConnection db = new SQLConnection();
            /* TODO need to add all of these funcs to the class
            db.user.Add(user);
            db.SaveChanges();
            */
            return Ok();
           
        }
    }
}
