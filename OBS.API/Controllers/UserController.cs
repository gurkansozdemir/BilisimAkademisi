using OBS.Core.DTOs;
using OBS.Service.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace OBS.API.Controllers
{
    public class UserController : ApiController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var usersDto = _userService.GetAll();
            return Ok(CustomResponseDto<List<UserDto>>.Success(usersDto.ToList()));
        }
    }
}
