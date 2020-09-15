using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SpaAPI.Models;

namespace SpaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        SpaManagementContext context = new SpaManagementContext();

        [HttpGet]
        public User GetUserbyUsername(string username)
        {
            User user = new User();
            using (context)
            {
                user = context.User
                    .Where(_user => _user.Username == username)
                    .Select(_user => new User()
                    {
                        UserId = _user.UserId,
                        Username = _user.Username,
                        Pwd = _user.Pwd,
                        UserType = _user.UserType
                    }).FirstOrDefault();
            }

            return user;
        }

        [HttpPost]
        public string PostUser(User user)
        {
            if(!context.User.Any(_user => _user.Username.Equals(user.Username)))
            {
                try
                {
                    user.UserId = context.User.Count() + 1;
                    context.User.Add(user);
                    context.SaveChanges();
                    return "Register user successfully!";
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "User has already existed!";
            }
        }
    }
}
