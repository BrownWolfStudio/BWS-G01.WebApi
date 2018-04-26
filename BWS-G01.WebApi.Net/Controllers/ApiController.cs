using BWS_G01.WebApi.Net.Models;
using System.Linq;
using System.Web.Mvc;

namespace BWS_G01.WebApi.Net.Controllers
{
    public class ApiController : Controller
    {
        readonly Model _context = new Model();
        
        [HttpGet]
        public JsonResult Leaderboard()
        {
            var currentLeaders = _context.Leaders.OrderBy(l => l.Rank).ToList();
            return Json(currentLeaders, JsonRequestBehavior.AllowGet);
        }
    }
}
