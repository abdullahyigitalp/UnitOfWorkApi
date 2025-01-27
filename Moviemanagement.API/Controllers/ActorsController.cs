using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviemanagement.Domein.Repository;

namespace Moviemanagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        public ActorsController(IUnitOfWork unitofwork)
        {
            _unitofwork= unitofwork;
        }


        [HttpGet]
        public ActionResult GetActors()
        {
            var actors = _unitofwork.Biography.GetById(1);
            return Ok(actors);
        }
        [HttpGet("Movies")]
        public ActionResult GetActorswithmovies()
        {
            var actorswithmovie = _unitofwork.Actor.GetActorsByMovieId();
            return Ok(actorswithmovie);
        }
    }
}
