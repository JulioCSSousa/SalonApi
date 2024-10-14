using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalonAPI.Dto
{
    public class ClientDto
    {

        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }
    }
}
