﻿using Microsoft.AspNetCore.Mvc;
using MiniMarket_API.Application.Services.Interfaces;
using MiniMarket_API.Model.Enums;

namespace MiniMarket_API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ISaleOrderService _saleOrderService;

        public UserController (IUserService userService, ISaleOrderService saleOrderService)
        {
            _userService = userService;
            _saleOrderService = saleOrderService;
        }

        [HttpGet("profile")]
        //Method accessible by any role, but can only be performed by the own user. When ready to activate auth, remove userId from params and uncomment the claim retrieval.
        public async Task<IActionResult> GetMyProfileAsync(Guid userId)
        {
            //var userId = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "");

            var getProfile = await _userService.GetUserById(userId);
            if (getProfile == null)
            {
                return NotFound("Profile Wasn't Found");
            }
            return Ok(getProfile);
        }

        [HttpGet("profile/orders")]
        //Method accessible by any role, but can only be performed by the own user. When ready to activate auth, remove userId from params and uncomment the claim retrieval.
        public async Task<IActionResult> GetMyOrdersAsync(Guid userId, [FromQuery] OrderStatus status, [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 7)
        {
            //var userId = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "");
      
            var getOrders = await _saleOrderService.GetAllOrdersByUser(userId, sortBy, isAscending, pageNumber, pageSize);

            if (getOrders == null || !getOrders.Any())
            {
                return NotFound("You Have No Registered Orders");
            }
            return Ok(getOrders);
        }
    }
}
