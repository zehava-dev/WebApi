using Enitity;

namespace Repository
{
    public interface IUserRepository
    {
        User Get(int id);
        User Post(LoginUser luser);
        User Post(User user);
        void Put(int id, User userToUpdate);
    }
}