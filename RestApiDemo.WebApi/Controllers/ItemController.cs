using Microsoft.AspNetCore.Mvc;
using RestApiDemo.WebApi.Models;
using RestApiDemo.WebApi.Services;
using System.Collections.Generic;

namespace RestApiDemo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ShopService _shopService;

        public ItemController(ShopService shopService)
        {
            _shopService = shopService;
        }
        [HttpGet]
        public List<Item> GetAll()
        {
            return _shopService.GetAll();
        }

        [HttpPost]
        public void AddItem(Item item) // reikia nurodyti koki mes Item norime prideti
        {
            _shopService.AddItem(item);
        }


        [HttpPut]
        public void UpdateItem(Item item) // reikia nurodyti koki mes Item norime prideti
        {
            _shopService.AddItem(item);
        }

        [HttpDelete("{id}")]
        public void DeteleItem(int id)
        {
            _shopService.DeleteItem(id);
        }
    }
}

