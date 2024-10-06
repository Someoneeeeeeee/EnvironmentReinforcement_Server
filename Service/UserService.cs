using Server.Modal;

namespace Server.Service
{
    public class UserService
    {
        public UserService() { }
        //Check email and password, return the validated user object
        public User Validate(string email, string password) { return new User(); }
        //Check role then return all user with Volunteer role
        public User[] GetAllVolunteer() { return new User[0]; }
        //Check role then return all user with Cooperator role
        public User[] GetAllCooperator() { return new User[0]; }
        public void Create(User userObj) { return; }
    }
}
