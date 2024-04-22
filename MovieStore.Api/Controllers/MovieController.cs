using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Api.Models;
using MovieStore.Api.DataAccess;
using MovieStore.Api.BusinessLogic;
using MovieStore.ServiceLibrary.Domains;
using MovieStore.ServiceLibrary.Entities;

namespace MovieStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public IActionResult AddNewMovie(MovieEntity movieEntity)
        {
            var businessLogic = new Movie();
            businessLogic.SaveMovie(movieEntity);
            return Ok();
        }

    }



   
}
