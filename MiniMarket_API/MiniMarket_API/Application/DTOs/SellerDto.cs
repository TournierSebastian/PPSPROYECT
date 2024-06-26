﻿namespace MiniMarket_API.Application.DTOs
{
    public class SellerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string UserType { get; set; }
        public Guid CompanyCodeId { get; set; }    //Required foreign key
    }
}
