using BasicWebCore.Data;
using BasicWebCore.Models;
using BasicWebCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            this.productService = _productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            List<Product> lstProducts = productService.Get();
            return View(lstProducts);
        }

        // GET: Product/Details/5
        public ActionResult Details(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Product product = productService.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid || !ModelState.IsValid)
                {
                    productService.Create(product);
                    return RedirectToAction(nameof(Index));
                }
                return View(product);
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productService.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Product product)
        {
            try
            {
                if (id != product.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    productService.Update(id, product);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(product);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productService.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, Product formProduct)
        {
            try
            {
                var product = productService.Get(id);

                if (product == null)
                {
                    return NotFound();
                }

                productService.Delete(product.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
