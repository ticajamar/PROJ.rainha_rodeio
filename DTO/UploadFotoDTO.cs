using Microsoft.AspNetCore.Http;

namespace rainha_rodeio.DTO
{
    public class UploadFotoDTO
    {
        public string NomeFoto { get; set; }
        public IFormFile Arquivo { get; set; }
    }
}
