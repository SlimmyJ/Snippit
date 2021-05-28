namespace Snippit.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using Snippit.Data.Repositories;
    using Snippit.Models;
    using Snippit.Service;

    public class AuthorController : Controller
    {
        private readonly AuthorService _service;

        private readonly GenericRepo<Author> _repo;

        public async Task Index()
        {
        }
    }
}
