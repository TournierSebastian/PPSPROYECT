﻿using MiniMarket_Server_dev.Model.Entities;

namespace MiniMarket_Server_dev.Model.DTOs
{
    public class SellerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
        public bool IsActive { get; set; } 
        public DateTime? DeactivationTime { get; set; }
        public Guid CompanyCodeId { get; set; }    //Required foreign key
        public CompanyCode CompanyCode { get; set; } = null!;   //Required reference navigation to principal
    }
}
