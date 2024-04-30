using MovieStore.ServiceLibrary.Entities;
using MovieStore.ServiceLibrary.Repositories;


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
