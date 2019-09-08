using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Api.Controllers.v1
{
    using Gymlog.Domain.Models;

    [ApiController, Route("api/v1/Environment")]
    public class EnvironmentController: ControllerBase
    {
        public ActionResult<EnvironmentInfo> Get()
        {
            return new EnvironmentInfo { 
                    Hostname = Dns.GetHostName()
                };
        }
    }
}