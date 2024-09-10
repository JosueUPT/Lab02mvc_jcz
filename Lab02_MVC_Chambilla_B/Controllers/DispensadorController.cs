using System;
using System.Web.Mvc;
using Lab02_MVC_Chambilla_B.Models;

namespace Lab02_MVC_Chambilla_B.Controllers
{
    public class DispensadorController : Controller
    {
        // GET: Dispensador
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcularBilletes(ClsDispensador objDispensador)
        {
            if (objDispensador.monto > 0)
            {
                // Restante del residuo de cada denominación
                objDispensador.b100 = (int)(objDispensador.monto / 100);
                objDispensador.b50 = (int)((objDispensador.monto % 100) / 50);
                objDispensador.b20 = (int)((objDispensador.monto % 100 % 50) / 20);
                objDispensador.b10 = (int)((objDispensador.monto % 100 % 50 % 20) / 10);

                objDispensador.m5 = (int)((objDispensador.monto % 100 % 50 % 20 % 10) / 5);
                objDispensador.m2 = (int)((objDispensador.monto % 100 % 50 % 20 % 10 % 5) / 2);
                objDispensador.m1 = (int)((objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2) / 1);

                objDispensador.c05 = (objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 % 1) / 0.5;
                objDispensador.c02 = (objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.5) / 0.2;
                objDispensador.c01 = (objDispensador.monto % 100 % 50 % 20 % 10 % 5 % 2 % 1 % 0.5 % 0.2) / 0.1;

                // Total de billetes
                objDispensador.cantidad = objDispensador.b100 + objDispensador.b50 + objDispensador.b20 + objDispensador.b10 + objDispensador.m5 + objDispensador.m2 + objDispensador.m1;

                objDispensador.cantidadb = objDispensador.b100 + objDispensador.b50 + objDispensador.b20 + objDispensador.b10;

                objDispensador.cantidadm = objDispensador.m5 + objDispensador.m2 + objDispensador.m1;

                objDispensador.cantidadc = objDispensador.c05 + objDispensador.c02 + objDispensador.c01;

                return View("CalcularBilletes", objDispensador);
            }
            else
            {
                ModelState.AddModelError("", "Ingrese un monto correcto");
                return View("Index", objDispensador);
            }
        }
    }
}
