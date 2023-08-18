using com.Library.Web.Models;
using com.Library.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.Library.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }
        // GET: UsersController
        public ActionResult Index()
        {
            var data = _service.List().Data;
            return View(data);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            var data = _service.GetById(id).Data;
            return View(data);
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _service.Add(model);
                    switch (result.Status)
                    {
                        case ResultStatus.success:


                            return RedirectToAction(nameof(Index));

                        case ResultStatus.failure:
                        case ResultStatus.error:
                        default:
                            return View(model);

                    }



                }

                return View(model);

            }
            catch
            {
                return View(model);
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _service.GetById(id).Data;

            return View(user);
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _service.Update(model);
                    switch (result.Status)
                    {
                        case ResultStatus.success:


                            return RedirectToAction(nameof(Index));

                        case ResultStatus.failure:
                        case ResultStatus.error:
                        default:
                            return View(model);

                    }



                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            var user = _service.Delete(id);
            return View(user);
        }

        // POST: UsersController/Delete/5
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
                return View();
            }
        }
    }
}
