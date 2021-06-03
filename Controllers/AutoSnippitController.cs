namespace Snippit.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using Snippit.Models;
    using Snippit.Models.ViewModels;
    using Snippit.Service;

    public class AutoSnippitController : Controller
    {
        private readonly ISnippitService _service;

        public AutoSnippitController(SnippitService service)
        {
            _service = service;
        }

        // GET: AutoSnippit
        public async Task<IActionResult> Index()
        {
            SnippitViewModel vm = new SnippitViewModel();
            vm.Snippits = await _service.GetAll();

            return View(vm);
        }

        // GET: AutoSnippit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snippit = await _service.Get(id);

            if (snippit == null)
            {
                return NotFound();
            }

            return View(snippit);
        }

        // GET: AutoSnippit/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AutoSnippit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Title,Summary,Description,Content,Rating,AuthorId,LanguageId,Id")]
            UserSnippit snippit)
        {
            if (ModelState.IsValid)
            {
                _service.Add(snippit);
                return RedirectToAction(nameof(Index));
            }
            return View(snippit);
        }

        // GET: AutoSnippit/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snippit = await _service.Get(id);
            if (snippit == null)
            {
                return NotFound();
            }
            return View(snippit);
        }

        // POST: AutoSnippit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("Title,Summary,Description,Content,Rating,AuthorId,LanguageId,Id")]
            UserSnippit snippit)
        {
            if (id != snippit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _service.Update(snippit);
                }
                catch (DbUpdateConcurrencyException)
                {
                }
                return RedirectToAction(nameof(Index));
            }
            return View(snippit);
        }

        // GET: AutoSnippit/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var snippit = await _service.Get(id);
            if (snippit == null)
            {
                return NotFound();
            }

            return View(snippit);
        }

        // POST: AutoSnippit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var snippit = await _service.Get(id);
            await _service.Delete(snippit);
            return RedirectToAction(nameof(Index));
        }

        private async Task<IActionResult> SnippitExists(int id)
        {
            if (_service.Get(id)
                        .IsCompletedSuccessfully)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
