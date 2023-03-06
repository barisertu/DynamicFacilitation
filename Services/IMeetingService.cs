
using DynamicFacilitation.Models;

namespace DynamicFacilitation.Services
{
    public interface IMeetingService
    {
        public Meeting CreateMeeting(Meeting meeting);

        public void DeleteMeeting(int id);

        public void AddParticipant(int id, string email);

        public Meeting UpdateMeeting(int id);

        public List<BlogPost> GetBlogs(int id);

        public BlogPost CreateMeetingPost(BlogPost post);
    }
}
