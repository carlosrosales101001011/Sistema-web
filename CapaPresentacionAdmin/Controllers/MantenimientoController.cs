using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MantenimientoController : Controller
    {
        // GET: Mantenimiento
        public ActionResult Categoria()
        {
            return View();
        }
        public ActionResult Marca()
        {
            return View();
        }
        public ActionResult Producto()
        {
            return View();
        }

        #region CATEGORIA

        [HttpGet]
        public JsonResult ListarCategorias()
        {
            List<Categoria> oList = new List<Categoria>();
            oList = new CN_Categoria().Listar();
            return Json(new { data = oList }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GuardarCategoria(Categoria obj)
        {
            object resul;

            string mensaje = string.Empty;

            if (obj.IdCategoria == 0)
            {
                //Registrando un nuevo usuario
                resul = new CN_Categoria().Registrar(obj, out mensaje);
            }
            else
            {
                resul = new CN_Categoria().Editar(obj, out mensaje);
            }


            return Json(new { resultado = resul, mensaje }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult EliminarCategoria(int id)
        {

            bool resul = false;
            string mensaje = string.Empty;
            resul = new CN_Categoria().Eliminar(id, out mensaje);

            return Json(new { resultado = resul, mensaje }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Marca
        [HttpGet]
        public JsonResult ListarMarcas()
        {
            List<Marca> oList = new List<Marca>();
            oList = new CN_Marca().Listar();
            return Json(new { data = oList }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GuardarMarca(Marca obj)
        {
            object resul;

            string mensaje = string.Empty;

            if (obj.IdMarca == 0)
            {
                //Registrando un nuevo usuario
                resul = new CN_Marca().Registrar(obj, out mensaje);
            }
            else
            {
                resul = new CN_Marca().Editar(obj, out mensaje);
            }


            return Json(new { resultado = resul, mensaje }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult EliminarMarca(int id)
        {

            bool resul = false;
            string mensaje = string.Empty;
            resul = new CN_Marca().Eliminar(id, out mensaje);

            return Json(new { resultado = resul, mensaje }, JsonRequestBehavior.AllowGet);
        }
#endregion

    }
}