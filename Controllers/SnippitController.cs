namespace Snippit.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

    using Microsoft.AspNetCore.Mvc;

    using Snippit.Models;
    using Snippit.Models.SnippitViewModels;
    using Snippit.Service;

    public class SnippitController : Controller
    {
        private readonly ISnippitService _service;

        private readonly IMapper _mapper;

        public SnippitController(ISnippitService service, IMapper mapper)
        {
                _service = service;
                _mapper = mapper;
            }

            public async Task<IActionResult> Index()
            {
                ICollection<Snippit> snippits = await _service.Get();
                var viewModel = new SnippitViewModel()
                                {
                                    Snippits = _mapper.Map<ICollection<Snippit>>(snippits)
                                };

                return View(viewModel);
            }

            public async Task<IActionResult> Detail(int id)
            {
                Snippit snippit = await _service.Get(id);
                SnippitDetailViewModel viewModel = _mapper.Map<SnippitDetailViewModel>(snippit);

                return View(viewModel);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(SnippitCreateViewModel vm)
            {
                bool isModelValid = TryValidateModel(vm);

                if (!isModelValid)
                {
                    return View(vm);
                }

                Snippit snippitModel = _mapper.Map<Snippit>(vm);
                await _service.Add(snippitModel);
                return RedirectToAction(nameof(Index));
            }

            public async Task<IActionResult> Edit(int id)
            {
                if (id == 0)
                {
                    return NotFound();
                }

                Snippit snippit = await _service.Get(id);

                if (snippit == null)
                {
                    return NotFound();
                }

                SnippitEditViewModel vm = _mapper.Map<SnippitEditViewModel>(snippit);
                return View(vm);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(SnippitEditViewModel vm)
            {
                bool isModelValid = TryValidateModel(vm);

                if (!isModelValid)
                {
                    return View(vm);
                }

                Snippit model = _mapper.Map<Snippit>(vm);
                await _service.Update(model);

                return RedirectToAction(nameof(Index));
            }

            public async Task<IActionResult> Delete(int id)
            {
                if (id == 0)
                {
                    return NotFound();
                }

                Snippit model = await _service.Get(id);

                if (model == null)
                {
                    return NotFound();
                }

                SnippitDeleteViewModel vm = _mapper.Map<SnippitDeleteViewModel>(model);

                return View(vm);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Delete(SnippitDeleteViewModel vm)
            {
                if (vm == null)
                {
                    return NotFound();
                }

                Snippit model = _mapper.Map<Snippit>(vm);
                await _service.Delete(model);
                return RedirectToAction(nameof(Index));
            }
        }
    }
