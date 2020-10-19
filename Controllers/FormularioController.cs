using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practica1.Models;

namespace Practica1.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public IActionResult Registrar(Formulario objFormulario){
            if(ModelState.IsValid)
            {
                 objFormulario.Respuesta ="Datos registrados";
            }
            return View("index", objFormulario);
            
       }
    }
}

    