﻿using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto = new ProductoModel();
            producto.Id = 1;
            producto.Descripcion = "Pizza 6 Quesos";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 Estaciones";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Jamon y Queso";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return View(listadeproductos);
        }
    }
}