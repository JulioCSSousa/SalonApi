using SalonAPI.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace SalonAPI.Dto
{
    public class AppointmentDto
    {

        public int Id { get; private set; }
        public ClientDto Client { get; set; }
        public ServiceDto Service { get; set; }
        public DateTime Date { get; set; }
        public List<DateTime> Dates { get; set; } = new List<DateTime>();
    }
}
