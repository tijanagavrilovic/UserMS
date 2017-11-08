using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using UserMS.DataAccess;
using UserMS.Models;
using UserMS.Util;

namespace UserMS.Controllers
{
    public class UserController : ApiController
    {
        /// <summary>
        /// Get list of users
        /// </summary>
        /// <param name="userType">Name of user type</param>
        /// <param name="userName">Username for filtering</param>
        /// <param name="pageNumber">Number of page for pagination</param>
        /// <param name="pageSize">Number of users per page</param>
        /// <param name="order">Field to be ordered by. Available: Id, Code, Name, Address, UserTypeId</param>
        /// <param name="orderDirection">Order direction ASC/DESC</param>
        /// <param name="active">Show active and inactive users</param>
        /// <returns>Return all users at once; depending on parameter returns only certain type of users or all.</returns>        
        [Route("api/User"), HttpGet]
        public IEnumerable<User> GetUsers([FromUri]string userType = null, [FromUri]string userName = null, [FromUri]ActiveStateEnum active = ActiveStateEnum.Active,
                                          [FromUri]int? pageNumber = null, [FromUri]int? pageSize = null, [FromUri]UserOrderEnum order = UserOrderEnum.Id,
                                          [FromUri]OrderDirectionEnum orderDirection = OrderDirectionEnum.Asc)
        {
            return UserDB.GetUsers(userType, userName, active, pageNumber, pageSize, order, orderDirection);
        }

        [Route("api/CreateUser"), HttpPost]
        public User CreateUser(User user)
        {
            return UserDB.CreateUser(user);
        }
    }
}