using CSRMDataManager.Library.DataAccess;
using CSRMDataManager.Library.Internal.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;

namespace CSRMDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {       

        //public string Get(int id)
        //{
        //    return "value";
        //}
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
            return data.GetUserById(userId);
           
        }        
    }
}
