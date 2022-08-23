using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class CalculadoraController : Controller 
{
    public class UserForm
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
    }
    private readonly ILogger<CalculadoraController> _logger;

    public CalculadoraController(ILogger<CalculadoraController> logger)
    {
        _logger = logger;
    }

   public IActionResult Operacao ()
   {
        return View();
   }
    public IActionResult ResultadoOperacao ([FromForm] double num1, [FromForm] double num2, [FromForm] string operacao)
    {
        
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Operacao = operacao;

        switch(operacao)
        {
            case "Soma":
                ViewBag.operador = '+';
                ViewBag.resultado = num1 + num2;
                break;

            case "Subtração":
                ViewBag.operador = '-';
                ViewBag.resultado = num1 - num2;
                break;

            case "Multiplicação":
                ViewBag.operador = '*';
                ViewBag.resultado = num1 * num2;
                break;

            case "Divisão":
                ViewBag.operador = '/';
                ViewBag.resultado = num1 / num2;
                break;
        }

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}