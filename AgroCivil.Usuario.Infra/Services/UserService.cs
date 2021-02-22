using AgroCivil.Usuario.Domain.Models.User;
using AgroCivil.Usuario.Domain.Services.IUserService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Infra.Services
{
    public class UserService : IUserService
    {
        public UserService()
        {

        }

        public async Task<List<UserModel>> GetUsers()
        {
            var users = new List<UserModel>();

            users.Add(new UserModel { Name = "Murilo" });

            return users;

        }
    }
}
