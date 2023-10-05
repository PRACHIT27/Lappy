using Lappy.Repositories;
using Lappy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Packaging.Signing;

namespace Lappy.Controllers
{
    [Authorize]
    public class UserOrderController:Controller
    {
        private readonly IUserOrderRepository _userOrderRepo;

        public UserOrderController(IUserOrderRepository userOrderRepo)
        {
            _userOrderRepo = userOrderRepo;
        }
     /*   public async Task<IActionResult> UserOrders()
        {
            var orders = await _userOrderRepo.UserOrders();
            return View(orders);
        }*/
        public async Task<IActionResult> UserOrder()
        {
            var orders = await _userOrderRepo.GetOrders();
            return View(orders);
        }

    }
}
