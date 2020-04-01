using ProgramaVieBag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgramaVieBag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente()
            {
               cliId = 23,
               cliNome = "Giscreuza",
               cliEnd = "Rua Tá Difícil, 00",
               cliNasc = "23/05/1996 00:00:00"
            };
            ViewBag.cliId = cliente.cliId;
            ViewBag.cliNome = cliente.cliNome;
            ViewBag.cliEnd = cliente.cliEnd;
            ViewBag.cliNasc = cliente.cliNasc;
            return View();
        }

        public ActionResult Produto()
        {
            Produto produto = new Produto()
            {
                prodId = 1,
                prodNome = "Bom",
                prodValor = 149.99m,
                prodQtd = 100   
            };
            ViewBag.prodId = produto.prodId;
            ViewBag.prodNome = produto.prodNome;
            ViewBag.prodValor = produto.prodValor;
            ViewBag.prodQtd = produto.prodQtd;
            return View();
        }

        public ActionResult Venda()
        {
            Venda venda = new Venda()
            {
                vendaId = 100,
                vendaData = "28/02/2019 00:00:00",
                vendaTotal = 500m
            };
            ViewBag.vendaId = venda.vendaId;
            ViewBag.vendaData = venda.vendaData;
            ViewBag.vendaTotal = venda.vendaTotal;
            return View();
        }


    }
}