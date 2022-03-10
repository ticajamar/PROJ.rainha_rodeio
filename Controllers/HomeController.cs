using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rainha_rodeio.DTO;

using rainha_rodeio.Services;
using System;

using System.Threading.Tasks;

using System.Text;

namespace rainha_rodeio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HomeService service = new HomeService();
        private readonly IMailService _mailService;
        string title = "Inscrição";

        public HomeController(ILogger<HomeController> logger, IMailService mailService)
        {
            _logger = logger;
            _mailService = mailService;
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
        #region Save e Verificação CPF

        [HttpPost]
        public async Task<JsonResult> Save()
        {
            try
            {
                string x = Request.Form["Dados"];

                ModeloDTO modelDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<ModeloDTO>(x);
#if DEBUG
                modelDTO.CaminhoFoto = @"C:\Users\leofs\source\repos\rainha_rodeio\wwwroot\fotos\";
#else
                modelDTO.CaminhoFoto = @"C:\inetpub\wwwroot\RainhaRodeio\wwwroot\fotos\";
#endif
                #region Verifica campos

                #endregion

                var files = Request.Form.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    var file = files[i];

                    modelDTO.Foto = Guid.NewGuid() + ".jpg";

                    service.SaveFoto(modelDTO.CaminhoFoto, file, modelDTO.Foto);

                    bool result = service.CheckCpf(modelDTO.CPF);
                    if (result == true)
                    {
                        return Json(JsonResultBL.Sucesso(title, "O CPF já está inscrito no concurso."));
                    }
                    else
                    {

                        StringBuilder query = new StringBuilder();
                        query.AppendLine("Olá, "+modelDTO.Nome+"!");
                        query.AppendLine("<br/>");
                        query.AppendLine("<br/>Obrigado por se inscrever na pré-seleção do concurso para Rainha e Princesa do Rodeio de Cajamar 2022.");
                        query.AppendLine("<br/>Segue abaixo os dados informados na inscrição.:");
                        query.AppendLine("<br/>");
                        query.AppendLine("<br/>Nome: "+modelDTO.Nome);
                        query.AppendLine("<br/>Endereço: "+modelDTO.Endereco+", "+modelDTO.Bairro+", "+modelDTO.Cidade+"/"+modelDTO.UF+", "+modelDTO.Cep+".");
                        query.AppendLine("<br/>Fone: "+modelDTO.Fone);
                        query.AppendLine("<br/>Celular: " + modelDTO.Celular);
                        query.AppendLine("<br/>Email: " + modelDTO.Email);
                        query.AppendLine("<br/>RG: " + modelDTO.RG);
                        query.AppendLine("<br/>CPF: " + modelDTO.CPF);
                        query.AppendLine("<br/>Data de nascimento: " + modelDTO.DataNascimento);
                        query.AppendLine("<br/>Idade: " + modelDTO.Idade);
                        query.AppendLine("<br/>Peso: " + modelDTO.Peso);
                        query.AppendLine("<br/>Altura: " + modelDTO.Altura);
                        query.AppendLine("<br/>Manequim: " + modelDTO.Manequim);
                        query.AppendLine("<br/>Numerodo do calçado: " + modelDTO.NumeroCalcado);
                        query.AppendLine("<br/>Numero do chapeu: " + modelDTO.NumeroChapeu);
                        query.AppendLine("<br/>Medida do busto: " + modelDTO.MedidaBusto);
                        query.AppendLine("<br/>Medida da cintura: " + modelDTO.MedidaCintura);
                        query.AppendLine("<br/>Medida do quadril: " + modelDTO.MedidaQuadril);
                        query.AppendLine("<br/>");
                        query.AppendLine("<br/>Qualquer alteração por favor entrar em contato com a comissão via Whatsapp no botão no rodapé da página de inscrição.");

        

                        EmailRequestDTO emailRequest = new EmailRequestDTO();
                        string emailRequerente = modelDTO.Email;
                        
                        emailRequest.ToEmail = emailRequerente;
                        emailRequest.Subject = "[CONFIRMAÇÃO DE INSCRIÇÃO] - PREFEITURA DE CAJAMAR";
                        emailRequest.Body = query.ToString();
                        emailRequest.Attachments = null;
                        await _mailService.SendEmailAsync(emailRequest);
                        service.Insert(modelDTO);
                        return Json(JsonResultBL.Sucesso(title, "Dados atualizados."));
                    }
                };

            }
            catch (Exception ex)
            {
                return Json(JsonResultBL.Erro(title, "Ops! Ocorreu um erro."));
            }
            return Json("teste");
        }
        #endregion
        #region GetLastId
        public JsonResult GetLastId()
        {
            return Json(service.GetLastId());
        }
        #endregion
    }
}
