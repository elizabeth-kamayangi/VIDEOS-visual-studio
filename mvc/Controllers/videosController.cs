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
        public ActionResult Add(video video)
        {
            _dbContext.Videos.Add(video);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var video = _dbContext.Videos.SingleOrDefault(v => v.Id == id);

            if (video == null)
                return HttpNotFound();

            return View(video);
        }
    }
}