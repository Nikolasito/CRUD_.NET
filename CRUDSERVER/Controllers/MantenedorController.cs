using CRUDSERVER.Datos;
using CRUDSERVER.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUDSERVER.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _contactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
           // LA VISTA MOSTRARA UNA LISTA DE CONTACTOS
            var oLista = _contactoDatos.Listar();

            return View(oLista);
        }

        //GUARDAR
        public IActionResult Guardar()
        {
            //METODO SOLO DEVUELVE LA VISTA 
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModels oContacto)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            if (!ModelState.IsValid)
                return View();


            var respuesta = _contactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }


        //EDITAR
        public IActionResult Editar(int IdContacto)
        {
            //METODO SOLO DEVUELVE LA VISTA 
            var ocontacto = _contactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModels oContacto)
        {
            if (!ModelState.IsValid)
                return View();


            var respuesta = _contactoDatos.Editar (oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        //ELIMINAR
        public IActionResult Eliminar(int IdContacto)
        {
            //METODO SOLO DEVUELVE LA VISTA 
            var ocontacto = _contactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModels oContacto)
        {

            var respuesta = _contactoDatos.Eliminar(oContacto.IdContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
