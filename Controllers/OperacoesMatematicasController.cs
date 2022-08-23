using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class UserForm
{    public double Num1 { get; set; }
    public double Num2 { get; set; }
}

public class OperacoesMatematicasController : Controller 
{
    private readonly ILogger<OperacoesMatematicasController> _logger;

    public OperacoesMatematicasController(ILogger<OperacoesMatematicasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult Subtrair()
    {
        return View();
    }

    public IActionResult Multiplicar()
    {
        return View();
    }

    public IActionResult Dividir()
    {
        return View();
    }

    // fromform pega as infos apenas de formularios
   

    public IActionResult SomarResultado([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Resultado = num1 + num2;

        return View();
    }

    public IActionResult SubtrairResultado([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Resultado = num1 - num2;

        return View();
    }

    public IActionResult MultiplicarResultado([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Resultado = num1 * num2;

        return View();
    }

    public IActionResult DividirResultado([FromForm] double num1, [FromForm] double num2)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Resultado = num1 / num2;

        return View();
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
