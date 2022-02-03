using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rainha_rodeio.DTO;
using rainha_rodeio.Models;
using rainha_rodeio.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace rainha_rodeio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HomeServices service = new HomeServices();
        string title = "Inscrição";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Consultas TipoCabelo
        public JsonResult GetTipoCabelo()
        {
            return Json(service.GetTipoCabelo());
        }

        public JsonResult GetTipoComprimentoCabelo()
        {
            return Json(service.GetTipoComprimentoCabelo());
        }

        public JsonResult GetTipoCorCabelo()
        {
            return Json(service.GetTipoCorCabelo());
        }
        #endregion
        #region Consulta Escolaridade
        public JsonResult GetEscolaridade()
        {
            return Json(service.GetEscolaridade());
        }
        #endregion
        #region Consulta Pele e Olhos
        public JsonResult GetTipoCorPele()
        {
            return Json(service.GetTipoCorPele());
        }
        public JsonResult GetTipoCorOlho()
        {
            return Json(service.GetTipoCorOlho());
        }
        #endregion

        #region Salvar
        public JsonResult Save(ModeloDTO model)
        {
            service.Insert(model);
            return Json(JsonResultBL.Sucesso(title, "Dados atualizados."));
        }
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
