using DynamicFacilitation.Models;
using DynamicFacilitation.Repositories;

namespace DynamicFacilitation.Services
{
    public class MeetingService : IMeetingService
    {
        DynamicFacilitationContext _context;

        public MeetingService(DynamicFacilitationContext context)
        {
            _context = context;
        }

        public void AddParticipant(int id, string email)
        {
            var user = _context.Users.Where(u => u.Emailaddress == email).FirstOrDefault();

            if (user == null)
            {
                _context.Users.Add(new User { Emailaddress = email });
                _context.SaveChanges();
            }

            var userMeeting = new UserMeeting { MeetingId = id, UserId = email};
            var meeting = _context.UserMeetings.Add(userMeeting);
            _context.SaveChanges();
        }

        public Meeting CreateMeeting(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            _context.SaveChanges();
            return meeting;
        }

        public BlogPost CreateMeetingPost(BlogPost post)
        {
            throw new NotImplementedException();
        }

        public void DeleteMeeting(int id)
        {
            var meeting = _context.Meetings.Where(m => m.MeetingId == id).FirstOrDefault();
            _context.Meetings.Remove(meeting);
            _context.SaveChanges();
        }

        public List<BlogPost> GetBlogs(int id)
        {
            throw new NotImplementedException();
        }

        public Meeting UpdateMeeting(int id)
        {
            throw new NotImplementedException();
        }
    }
}
