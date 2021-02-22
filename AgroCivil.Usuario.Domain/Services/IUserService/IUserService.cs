using AgroCivil.Usuario.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Services.IUserService
{
    public interface IUserService
    {
        Task<List<UserModel>> GetUsers();
    }
}
