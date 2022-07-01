using AutoMapper;
using ManageClients.Service.DTOs;
using ManageClients.Service.Entities;
using ManageClients.Service.Interfaces;

namespace ManageClients.Service.Impl
{
    public class ClientService : IClientService
    {
        private readonly IMapper _mapper;

        public ClientService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ClientResponse GetCustomerByTypeAndDocumentNumber(ClientRequest client)
        {
            ClientResponse clientResonse = new();
            var clientResult = this.SetClientsMock()
                .Where(c => c.DocumentType == client.DocumentType.GetHashCode() && c.DocumentNumber == client.DocumentNumber)
                .FirstOrDefault();
            if (clientResult != null)
            {
                clientResonse = _mapper.Map<ClientResponse>(clientResult);
                return clientResonse;
            }
            else
                return null;
        }

        private List<Client> SetClientsMock()
        {
            var clients = new List<Client>();

            clients.Add(new Client
            { 
                DocumentType = 1, 
                DocumentNumber = 125355412, 
                FirstName = "John", 
                SecondName = "Stick",
                Surname = "Doe",
                SecondSurname = "Smith",
                Phone = 326568456,
                Address = "cra 23 # 12 - 56",
                ResidenceCity = "EEUU"
            });

            clients.Add(new Client
            {
                DocumentType = 2,
                DocumentNumber = 23445322,
                FirstName = "Maria",
                SecondName = "Lucia",
                Surname = "Fernandez",
                SecondSurname = "Perez",
                Phone = 35456865,
                Address = "cll 12 # 123 - 15",
                ResidenceCity = "Colombia"
            });

            return clients;
        }
    }
}
