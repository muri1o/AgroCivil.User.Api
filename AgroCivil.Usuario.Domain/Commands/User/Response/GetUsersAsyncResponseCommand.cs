using AgroCivil.Usuario.Domain.Models.User;
using AgroCivil.Usuario.Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Domain.Commands.User.Request
{
    public class GetUsersAsyncResponseCommand : ResponseBaseModel
    {
        public List<UserModel> Users { get; set; }
    }
}
