using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityTrippr.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CityTrippr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;

        public UserProfileController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        //GET: /api/UserProfile
        [HttpGet]
        [Authorize]
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(u => u.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);

            return new
            {
                user.FirstName,
                user.LastName,
                user.Email,
                user.UserName
            };
        }
    }
}