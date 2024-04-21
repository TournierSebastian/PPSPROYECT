﻿using MiniMarket_Server_dev.Model.Entities;

namespace MiniMarket_Server_dev.Data.Interfaces
{
    public interface ISaleOrderRepository
    {
        Task<SaleOrder> CreateOrderAsync(SaleOrder order);
        Task<SaleOrder?> UpdateOrderAsync(Guid id, SaleOrder order);
        Task SetFinalOrderPriceAsync(Guid id, decimal finalPrice);
        Task<SaleOrder?> DeactivateOrderAsync(Guid id);
        Task<SaleOrder?> EraseOrderAsync(Guid id);
        Task<IEnumerable<SaleOrder>> GetAllOrders(bool? isActive, string? sortBy = null, bool isAscending = true,
            int pageNumber = 1, int pageSize = 30);
        Task<IEnumerable<SaleOrder>> GetAllOrdersByUserAsync(Guid userId, bool? isActive, string? sortBy = null, bool isAscending = true,
            int pageNumber = 1, int pageSize = 30);
        //Task<IEnumerable<SaleOrder>> GetAllOrdersFromTodayAsync(DateTime today);
        Task<SaleOrder?> GetOrderByIdAsync(Guid id);
    }
}
