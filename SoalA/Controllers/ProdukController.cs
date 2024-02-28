using Microsoft.AspNetCore.Mvc;
using SoalA.Models;
using SoalA.Service;

namespace SoalA.Controllers
{
    public class ProdukController : Controller
    {
        IProdukService _produkService = null; 
        public ProdukController(IProdukService produkService)
        {
            _produkService = produkService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<Produk> Search(string name)
        {
            return _produkService.Search(name);
        }
        public void Save(Produk produk)
        {
            _produkService.Save(produk);
        }
        public void Delete(int id)
        {
            _produkService.Delete(id);
        }
        public void Update(Produk produk)
        {
            _produkService.Update(produk);
        }
    }

}
