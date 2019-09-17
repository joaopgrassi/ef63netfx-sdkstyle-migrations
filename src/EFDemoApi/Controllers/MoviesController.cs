using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EFDemoApi.Controllers
{
    [RoutePrefix("api/movies")]
    public class MoviesController : ApiController
    {
        private readonly IMyService _myService;

        public MoviesController(IMyService myService)
        {
            this._myService = myService ?? throw new ArgumentNullException(nameof(myService));
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_myService.GetValue());
        }
    }
}