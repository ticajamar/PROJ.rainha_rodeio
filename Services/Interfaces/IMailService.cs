using rainha_rodeio.DTO;
using System.Threading.Tasks;

namespace rainha_rodeio.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(EmailRequestDTO emailRequest);
    }
}
