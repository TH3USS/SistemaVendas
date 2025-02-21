using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Models;
using SistemaVendas.Repositories;

namespace SistemaVendas.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepository.GetAll();
            return View(produtos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoRepository.Add(produto);
                return RedirectToAction("Index");
            }
            return View(produto);
        }
    }

}
