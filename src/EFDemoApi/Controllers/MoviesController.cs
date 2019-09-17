using EFDemo.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace EFDemoApi.Controllers
{
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiController
    {
        private readonly MoviesDbContext _moviesDbContext;

        public MoviesController(MoviesDbContext moviesDbContext)
        {
            _moviesDbContext = moviesDbContext ?? throw new ArgumentNullException(nameof(moviesDbContext));
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var movies = await _moviesDbContext.Movies.ToListAsync();

            return Ok(movies);
        }
    }
}