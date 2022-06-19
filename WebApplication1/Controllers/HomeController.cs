using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Calcular(Suma suma)
    {
        suma.Numero1 = 10;
        suma.Numero2 = 20;

        suma.Resultado = suma.Numero1 + suma.Numero2;
        suma.Resultado = Convert.ToInt32(suma.Numero1) + Convert.ToInt32(suma.Numero2);
        ViewBag.Resultado = suma.Resultado;
     
        return View();
    }
}