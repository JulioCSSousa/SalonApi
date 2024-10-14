namespace SalonAPI.AutoMapper
{
    using global::AutoMapper;
    using SalonAPI.Dto;
    using SalonAPI.Models.Entities;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<Appointment, AppointmentDto>();
            CreateMap<Service, ServiceDto>();

        }
    }

}
