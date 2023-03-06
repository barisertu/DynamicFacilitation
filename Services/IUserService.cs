using DynamicFacilitation.Models;

namespace DynamicFacilitation.Services
{
    public interface IUserService
    {
        public bool ValidateUser(string email);

        public List<User> GetUsers();

        public List<Meeting> GetParticipations(string email);

        public User RegisterUser(User user);
    }
}
