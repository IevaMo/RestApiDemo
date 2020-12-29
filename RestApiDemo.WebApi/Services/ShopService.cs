using RestApiDemo.WebApi.Models;
using System.Collections.Generic;

namespace RestApiDemo.WebApi.Services
{
    public class ShopService
    {
        private List<Item> Items = new List<Item>(); // inicijuojam
        private int number = 0;

       // public List<Item> GetAll() // servisas, kuris viska gauna
        //{
          //  number = number++;
           // return Items;
       // }
       public int Get()
        {
            number += 1; // prie numerio pridedam viena
            return number;
        }
        public void AddItem(Item item) //sukuriamas pridejimo metodas ir servisas, kurio pagalba galime prideti
        {
            Items.Add(item);
        }
    }
}
