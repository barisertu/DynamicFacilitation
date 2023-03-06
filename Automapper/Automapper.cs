using System;
using AutoMapper;
using DynamicFacilitation.Models;

namespace DynamicFacilitation.Automapper
{
	public class Automapper : Profile
	{
		public Automapper()
		{
			CreateMap<UserRequestDto, User>();
            CreateMap<User, UserResponseDto>();
			CreateMap<Meeting, MeetingResponseDto>();
			CreateMap<MeetingRequestDto, Meeting>();
        }
	}
}

