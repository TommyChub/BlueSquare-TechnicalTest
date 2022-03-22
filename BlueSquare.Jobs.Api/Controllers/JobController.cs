using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlueSquare.Jobs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JobController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult GetJobs()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetJobsById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult CreateJob()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult UpdateJob()
        {
            return Ok();
        }
    }
}
