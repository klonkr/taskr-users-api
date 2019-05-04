using Microsoft.AspNetCore.Mvc;
using taskr_users_api.Models;

namespace taskr_users_api.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        public IRepository Repo { get; }

        public UserController(IRepository repo)
        {
            Repo = repo;
        }
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("something")]
        public ActionResult Details()
        {
            return View();
        }

        [Route("create")]
        [HttpPost]
        public ActionResult Create([FromBody] User user){
            Repo.Create(user);
            return Ok();
        }
    }
}