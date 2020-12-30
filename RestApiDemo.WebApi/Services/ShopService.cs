using RestApiDemo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDemo.WebApi.Services
{
    public class ShopService
    {
        private List<Item> Items = new List<Item>(); // inicijuojam
        private int number = 0;

        public List<Item> GetAll() // servisas, kuris viska gauna
        {
            return Items;
        }
        public void AddItem(Item item) //sukuriamas pridejimo metodas ir servisas, kurio pagalba galime prideti
        {
        number += 1;

        item.Id = number;

        Items.Add(item);
        }

        internal void DeleteItem(int id)
        {
            Items = Items.Where(i => i.Id != id).ToList();
        }
    }
}
