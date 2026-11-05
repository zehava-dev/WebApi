using Enitity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Repository;

namespace Service
{
    public class UserService : IUserService
    {
       IUserRepository repository;
        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User Get(int id)
        {

            return repository.Get(id);
        }
        public User Post(User user)
        {
            return repository.Post(user);
        }
        public User Post(LoginUser user)
        {
            return repository.Post(user);
        }
        public void Put(int id, User user)
        {
            repository.Put(id, user);
        }

    }
}
