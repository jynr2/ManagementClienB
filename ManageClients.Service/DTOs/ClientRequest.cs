using ManageClients.Service.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManageClients.Service.DTOs
{
    public class ClientRequest
    {
        [Required(ErrorMessage = "DocumentType is required")]
        public DocumentTypeEnum? DocumentType { get; set; }

        [Required(ErrorMessage = "DocumentNumber is required")]
        public long? DocumentNumber { get; set; }
    }
}
