using AgroCivil.Usuario.Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AgroCivil.Usuario.Api.Controllers.Base
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {

        public readonly IMediator _mediator;

        public BaseController([FromServices] IMediator mediator)
        {
            _mediator = mediator;
        }

        protected ObjectResult FormatReturn(ResponseBaseModel response)
        {
            //if (response.Valid)
            //{

            //}

            return StatusCode(200, response);
        }
    }

    public class NotificationsResponseDto
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public List<NotificationsDetailResponseDto> Details { get; set; }

    }

    public class NotificationsDetailResponseDto
    {
        public string Prop { get; set; }
        public string Detail { get; set; }
    }
}

