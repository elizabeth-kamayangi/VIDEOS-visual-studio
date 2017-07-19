using System.Linq;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
  public class videosController : Controller
  {
    private ApplicationDbContext _dbContext;

    public videosController()
    {

        _dbContext = new ApplicationDbContext();
        
    }
    public ActionResult Index()
        {
        var videos = _dbContext.Videos.ToList();
        return View(videos);
        }
        public ActionResult New()
        {
            return View();
        }
    }
}