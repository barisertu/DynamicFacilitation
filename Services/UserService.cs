using AutoMapper;
using DynamicFacilitation.Models;
using DynamicFacilitation.Repositories;

namespace DynamicFacilitation.Services
{
    public class UserService : IUserService
    {
        DynamicFacilitationContext _context;
        private IMapper _mapper;

        public UserService(DynamicFacilitationContext context)
        {
            _context = context;
        }
        public List<Meeting> GetParticipations(string email)
        {

            //Get meetings where user is participant
            var participations = _context.UserMeetings.Where(u => u.UserId == email).ToList();

            List<Meeting> meetings = new List<Meeting>();
            foreach (var participation in participations) {
                var meeting = _context.Meetings.Where(m => m.MeetingId == participation.MeetingId).FirstOrDefault();
                if (meeting != null)
                {
                    meetings.Add(meeting);
                }
            }

            //Get meetings where user is owner
            _context.Meetings.Where(m => m.Owner == email).ToList().ForEach( m => meetings.Add(m));

            
            return meetings;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList(); ;
        }

        public User RegisterUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public bool ValidateUser(string email)
        {
            var user = _context.Users.Where(e => e.Emailaddress == email).FirstOrDefault();

            if( user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
