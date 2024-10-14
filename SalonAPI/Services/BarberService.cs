using SalonAPI.Models;

namespace SalonAPI.Services
{
    public class BarberService
    {/*
        public void ShowServices()
        {
            for (int i = 0; i < Services.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Services[i]}");
            }
        }
        public Service GetService(int index)
        {
            if (index < 0 || index >= Services.Count)
            {
                throw new Exception("Digite um valor válido");
            }
            return Services[index];
        }

        public void ShowAppointmentList()
        {
            for (int i = 0; i < Appointments.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Appointments[i]}");
            }
        }

        public void ShowAlClients()
        {
            foreach (Client client in Clients)
            {
                Console.WriteLine(client);
            }
        }
        public decimal ShowIncomes()
        {
            decimal sum = 0;
            foreach (Appointment appointments in Appointments)
            {
                decimal allPrice = appointments.Service.GetPrice();
                sum += allPrice;
            }
            return sum;
        }*/
    }
}
