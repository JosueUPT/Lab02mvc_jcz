using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02_MVC_Chambilla_B.Models;

namespace Lab02_MVC_Chambilla_B.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult MostrarUno()
        {
            ClsPersona objPersona = new ClsPersona();

            objPersona.DNI = "12345678";
            objPersona.Apellidos = "Chambilla Zuñiga";
            objPersona.Nombre = "Josue";
            objPersona.edad = 21;
            objPersona.Sexo = true;
            objPersona.talla = 1.74;
            objPersona.peso = 68;
            
            return View(objPersona);
        }
        public ActionResult ListarTodos()
        {
            List<ClsPersona> List = new List<ClsPersona>();

            ClsPersona objPersona1 = new ClsPersona();
            objPersona1.DNI = "12345678";
            objPersona1.Apellidos = "Chambilla Zuñiga";
            objPersona1.Nombre = "Josue";
            objPersona1.edad = 21;
            objPersona1.Sexo = true;
            objPersona1.talla = 1.74;
            objPersona1.peso = 68;
            List.Add(objPersona1);

            ClsPersona objPersona2 = new ClsPersona();
            objPersona2.DNI = "87654321";
            objPersona2.Apellidos = "Torres Robledo";
            objPersona2.Nombre = "Jose";
            objPersona2.edad = 24;
            objPersona2.Sexo = true;
            objPersona2.talla = 1.70;
            objPersona2.peso = 65;
            List.Add(objPersona2);

            ClsPersona objPersona3 = new ClsPersona();
            objPersona3.DNI = "11223344";
            objPersona3.Apellidos = "Reynaldo Tamo";
            objPersona3.Nombre = "Ricardo";
            objPersona3.edad = 30;
            objPersona3.Sexo = true;
            objPersona3.talla = 1.80;
            objPersona3.peso = 74;
            List.Add(objPersona3);

            ClsPersona objPersona4 = new ClsPersona();
            objPersona4.DNI = "44332211";
            objPersona4.Apellidos = "Santa Mora";
            objPersona4.Nombre = "Lizbeth";
            objPersona4.edad = 42;
            objPersona4.Sexo = false;
            objPersona4.talla = 1.65;
            objPersona4.peso = 57;
            List.Add(objPersona4);

            ClsPersona objPersona5 = new ClsPersona();
            objPersona5.DNI = "33221144";
            objPersona5.Apellidos = "Conde Manzo";
            objPersona5.Nombre = "Lisa";
            objPersona5.edad = 18;
            objPersona5.Sexo = false;
            objPersona5.talla = 1.67;
            objPersona5.peso = 60;
            List.Add(objPersona5);

            return View(List);
        }
    }
}