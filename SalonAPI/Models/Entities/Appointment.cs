

using System.ComponentModel.DataAnnotations;

namespace SalonAPI.Models.Entities
{
    public class Appointment
    {
        public int Id { get; private set; }
        public Client Client { get; set; }
        public Service Service { get; set; }
        public DateTime Date { get; set; }
        public List<DateTime> Dates { get; set; } = new List<DateTime>();


    }
}
