using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgroCivil.Usuario.Api.Controllers.Base;
using AgroCivil.Usuario.Domain.Commands.User.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgroCivil.Usuario.Api.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : BaseController
    {

        public UserController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new GetUsersAsyncCommand();

            var response = await _mediator.Send(request);

            return FormatReturn(response);
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpPatch]
        public void Patch()
        {

        }
    }
}
