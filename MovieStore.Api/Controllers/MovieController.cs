using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Api.Models;
using MovieStore.Api.DataAccess;

namespace MovieStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public IActionResult AddNewMovie(MovieModel movieModel)
        {
            var businessLogic = new BusinessLogic();
            businessLogic.SaveMovie(movieModel);
            return Ok();
        }

        public class BusinessLogic()
        {
            public void SaveMovie(MovieModel movieModel)
            {
                var dataAccess = new MovieDataAccess();
                dataAccess.SaveMovieToDatabase(movieModel);
            }
        }

    }



   
}
