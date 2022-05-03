using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DissidiaAPI.Controllers
{
    public class MatchupController : ControllerBase
    {
        // GET: MatchupController
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        // GET: MatchupController/Details/5
        public ActionResult Details(int id)
        {
            throw new NotImplementedException();
        }

        // GET: MatchupController/Create
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        // POST: MatchupController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        // GET: MatchupController/Edit/5
        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        // POST: MatchupController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        // GET: MatchupController/Delete/5
        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        // POST: MatchupController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
