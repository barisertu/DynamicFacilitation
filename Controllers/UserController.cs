using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using DynamicFacilitation.Services;
using DynamicFacilitation.Models;
using AutoMapper;

namespace DynamicFacilitation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        private IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/users")]
        [ProducesResponseType(typeof(UserResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<IEnumerable<UserResponseDto>> GetUsers()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var users = _userService.GetUsers();
                return Ok(_mapper.Map<List<UserResponseDto>>(users));

            }
            return Unauthorized("Unauthorized.");
        }

        [HttpGet]
        [Route("/users/participations")]
        [ProducesResponseType(typeof(MeetingResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public ActionResult<IEnumerable<MeetingResponseDto>> GetParticipations()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                var participations = _userService.GetParticipations(email);
                return Ok(_mapper.Map<List<MeetingResponseDto>>(participations));
            }
            return Unauthorized("Unauthorized");
        
        }

        [HttpPost]
        [ProducesResponseType(typeof(ActionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [Route("/users/login")]
        public async Task<IActionResult> Login(string email)
        {
            var result = _userService.ValidateUser(email);
            if (result == true)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, email),
                    new Claim("MyCustomClaim", "my custom claim value")
                };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return Ok();
            }
            else
            {
                return BadRequest("User not found");
            }
        }

        [HttpPost]
        [Route("/users/register")]
        [ProducesResponseType(typeof(UserResponseDto), StatusCodes.Status200OK)]
        public  ActionResult<UserResponseDto> Register(UserRequestDto userDto)
        {
            var user =  _userService.RegisterUser(_mapper.Map<User>(userDto));
            return Ok(_mapper.Map<UserResponseDto>(user));
        }

        [HttpPost]
        [Route("/users/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }
    }
}
