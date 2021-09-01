using ApiResources.Application.DTOs.Email;
using System.Threading.Tasks;

namespace ApiResources.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}