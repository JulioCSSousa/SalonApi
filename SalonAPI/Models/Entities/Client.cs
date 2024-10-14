using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalonAPI.Models.Entities
{
    public class Client
    {
        public int Id { get; private set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(11)]
        public string Phone { get; set; }



    }
}
