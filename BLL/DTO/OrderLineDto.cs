using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class OrderLineDto
    {
        public OrderLineDto()
        {
            
        }
        
        public int Id { get; set; }
        public int ordersId { get; set; }
        public int pizzaId { get; set; }
        public int quantity { get; set; }
        public bool custom { get; set; }
        public decimal position_price { get; set; }
        public int pizza_sizesId { get; set; }
        public decimal weight { get; set; }

        public virtual List<int> addedingredientsId { get; set; }
        public OrderLineDto(order_lines ol)
        {
            Id = ol.id;
            ordersId = ol.ordersId;
            custom = ol.custom;
            position_price = ol.position_price;
            pizzaId= ol.pizzaId;
            quantity = ol.quantity;
            pizza_sizesId= ol.pizza_sizesId;
            weight = ol.weight;
            addedingredientsId=ol.ingredients.Select(i => i.id).ToList();
        }
    }
}
