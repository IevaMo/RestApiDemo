using Microsoft.AspNetCore.Mvc;
using RestApiDemo.WebApi.Models;
using RestApiDemo.WebApi.Services;
using System.Collections.Generic;

namespace RestApiDemo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IteamController : ControllerBase
    {
        private readonly ShopService _shopService;

        public IteamController(ShopService shopService)
        {
            _shopService = shopService;
        }
        [HttpGet]
        public int GetAll()
        {
            return _shopService.Get();
        }

        [HttpPost]
        public void AddItem()
        {

        }
    }
}

