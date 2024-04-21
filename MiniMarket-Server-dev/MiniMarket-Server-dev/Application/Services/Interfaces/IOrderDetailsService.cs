﻿using MiniMarket_Server_dev.Application.DTOs.Requests;
using MiniMarket_Server_dev.Model.Entities;

namespace MiniMarket_Server_dev.Application.Services.Interfaces
{
    public interface IOrderDetailsService
    {
        Task<OrderDetails?> CreateOrderDetail(CreateDetailDto createDetail, Guid orderId);
        Task<OrderDetails?> DeactivateDetail(Guid id);
    }
}
