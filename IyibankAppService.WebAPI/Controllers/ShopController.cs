using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IyibankAppService.ApiService;

namespace IyibankAppService.WebAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var list = _shopService.GetShops();
            return new JsonResult(1);
        }
    }
}