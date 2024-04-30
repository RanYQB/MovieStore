using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.ServiceLibrary.Domains;
using MovieStore.ServiceLibrary.Entities;

namespace MovieStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public IActionResult AddNewMovie([FromQuery]MovieEntity movieEntity)
        {
            var businessLogic = new Movie();
            businessLogic.SaveMovie(movieEntity);
            return Ok();
        }

    } 
}
