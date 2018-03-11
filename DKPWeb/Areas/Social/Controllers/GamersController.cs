using System.Net;
using System.Web.Mvc;
using DKPDAL.Models;
using DKPDAL.Repository;
using DKPDAL.Repository.Interface;

namespace DKPWeb.Areas.Social.Controllers
{
    public class GamersController : Controller
    {
        private readonly IRepositoryBase<Gamer> _gamerRepository = new RepositoryBase<Gamer>();

        // GET: Social/Gamers
        public ActionResult Index()
        {
            return View(_gamerRepository.GetAll());
        }

        // GET: Social/Gamers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gamer = _gamerRepository.GetById(id.Value);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // GET: Social/Gamers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Social/Gamers/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NickName,CreationDate")] Gamer gamer)
        {
            if (ModelState.IsValid)
            {
                _gamerRepository.Create(gamer);
                _gamerRepository.Save();
                return RedirectToAction("Index");
            }

            return View(gamer);
        }

        // GET: Social/Gamers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gamer = _gamerRepository.GetById(id.Value);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // POST: Social/Gamers/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NickName,CreationDate")] Gamer gamer)
        {
            if (ModelState.IsValid)
            {
                _gamerRepository.Update(gamer);
                _gamerRepository.Save();
                return RedirectToAction("Index");
            }
            return View(gamer);
        }

        // GET: Social/Gamers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var gamer = _gamerRepository.GetById(id.Value);
            if (gamer == null)
            {
                return HttpNotFound();
            }
            return View(gamer);
        }

        // POST: Social/Gamers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {  
            _gamerRepository.Delete(id);
            _gamerRepository.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _gamerRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
