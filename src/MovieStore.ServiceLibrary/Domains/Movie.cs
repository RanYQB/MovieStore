using MovieStore.ServiceLibrary.Entities;
using MovieStore.ServiceLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.ServiceLibrary.Domains
{
    public class Movie
    {
        public void SaveMovie(MovieEntity movieEntity)
        {
            var dataAccess = new MovieRepository();
            dataAccess.SaveMovieToDatabase(movieEntity);
        }
    }
}
