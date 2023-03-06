using AutoMapper;
using DynamicFacilitation.Models;
using DynamicFacilitation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DynamicFacilitation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetingController : ControllerBase
    {
        IMapper _mapper;
        IMeetingService _meetingService;

        public MeetingController(IMeetingService meetingService, IMapper mapper)
        {
            _meetingService = meetingService;
            _mapper = mapper;
        }

        [HttpPost("meetings")]
        [ProducesResponseType(typeof(MeetingResponseDto), StatusCodes.Status200OK)]
        public ActionResult<MeetingResponseDto> CreateMeeting(MeetingRequestDto meetingDto)
        {
            var convertedMeeting = _mapper.Map<Meeting>(meetingDto);
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            convertedMeeting.Owner = email;
            var meeting = _meetingService.CreateMeeting(convertedMeeting);
            return Ok(_mapper.Map<MeetingResponseDto>(meeting));
        }

        [HttpDelete("meetings/{id}")]
        [ProducesResponseType(typeof(MeetingResponseDto), StatusCodes.Status200OK)]
        public ActionResult<MeetingResponseDto> DeleteMeeting(int id)
        {
            _meetingService.DeleteMeeting(id);
            return Ok();
        }

        [HttpPatch("meetings/{id}/participants")]
        [ProducesResponseType(typeof(ActionResult), StatusCodes.Status200OK)]
        public IActionResult DeleteMeeting(int id, [FromBody] string email)
        {
            _meetingService.AddParticipant(id, email);
            return Ok();
        }
    }
}