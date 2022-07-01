using AutoMapper;
using ManageClients.Service.DTOs;
using ManageClients.Service.Entities;

namespace ManageClients.Service.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Client, ClientResponse>();
        }
    }
}
