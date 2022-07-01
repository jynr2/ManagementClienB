using ManageClients.Service.DTOs;

namespace ManageClients.Service.Interfaces
{
    public interface IClientService
    {
        ClientResponse GetCustomerByTypeAndDocumentNumber(ClientRequest client);
    }
}
