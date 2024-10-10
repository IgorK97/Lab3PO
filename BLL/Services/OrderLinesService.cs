using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.DTO;


namespace BLL
{
    internal class OrderLinesService
    {
        private MyPizzaDeliveryContext db;
        public OrderLinesService()
        {
            db = new MyPizzaDeliveryContext();
        }

        public List<OrderLineDto> GetAllOrderLines(int OrderId)
        {
            return db.order_lines.ToList().Where(i => i.ordersId==OrderId).Select(i => new OrderLineDto(i)).ToList();
        }


        public OrderLineDto GetOrderLine(int Id)
        {
            return new OrderLineDto(db.order_lines.Find(Id));
        }

        public void CreateOrdrLine(OrderLineDto p)
        {
            db.order_lines.Add(new order_lines() { position_price = p.position_price, ordersId=p.ordersId, custom = p.custom,
            weight=p.weight, pizzaId=p.pizzaId, pizza_sizesId=p.pizza_sizesId, quantity=p.quantity});
            Save();
            //db.order_lines.Attach(p);
        }

        public void UpdateOrderLine(OrderLineDto p)
        {
            order_lines ol = db.order_lines.Find(p.Id);
            ol.weight= p.weight;
            ol.custom= p.custom;
            ol.pizzaId= p.pizzaId;
            ol.position_price= p.position_price;
            ol.pizza_sizesId = p.pizza_sizesId;
            ol.quantity= p.quantity;
            ol.ordersId = p.ordersId;
            Save();
        }

        public void DeleteOrderLine(int id)
        {
            order_lines p = db.order_lines.Find(id);
            if (p != null)
            {
                db.order_lines.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<PizzaDto> GetPizzas()
        {
            return db.pizza.ToList().Select(i => new PizzaDto(i)).ToList();
        }

        public List<PizzaSizesDto> GetPizzaSizes()
        {
            return db.pizza_sizes.ToList().Select(i => new PizzaSizesDto(i)).ToList();
        }

        public List<IngredientDto> GetIngredients()
        {
            return db.ingredients.ToList().Select(i => new IngredientDto(i)).ToList();
        }
    }
}
