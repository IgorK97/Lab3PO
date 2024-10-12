using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.DTO;
using System.Diagnostics;
using System.Reflection;
using Npgsql.TypeHandlers.NumericHandlers;


namespace BLL
{
    public class OrderLinesService
    {
        private MyPizzaDeliveryContext db;
        public OrderLinesService()
        {
            db = new MyPizzaDeliveryContext();
        }

        public enum PizzaSize
        {
            Small=1,
            Medium=2,
            Big=3
        };

        public List<OrderLineDto> GetAllOrderLines(int OrderId)
        {
            return db.order_lines.ToList().Where(i => i.ordersId==OrderId).Select(i => new OrderLineDto(i)).ToList();
        }


        public OrderLineDto GetOrderLine(int Id)
        {
            return new OrderLineDto(db.order_lines.Find(Id));
        }

        public void CreateOrderLine(OrderLineDto p)
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

        public List<DelStatusDto> GetDelStatuses()
        {
            return db.DelStatus.ToList().Select(i => new DelStatusDto(i)).ToList();
        }

        public List<IngredientShortDto> GetIngredients(PizzaSize ps)
        {
            return db.ingredients.ToList().Select(i => new IngredientShortDto
            {
                Id=i.id,
                C_name=i.C_name,
                price = ps==PizzaSize.Small ? i.price_per_gram*i.small : ps==PizzaSize.Medium ?
                i.price_per_gram*i.medium : i.price_per_gram*i.big,
                weight = ps == PizzaSize.Small ? i.small : ps == PizzaSize.Medium ?
                i.medium : i.big,
                active = false
            }).ToList();
        }

        public (decimal price, decimal weight) GetBasePriceAndWeight(PizzaSize ps)
        {

            var res = db.pizza_sizes.ToList().Where(i => i.id == (int)Convert.ChangeType(ps, ps.GetTypeCode())).
                Select(i => new
                {
                    price = i.price,
                    weight = i.weight
                }).FirstOrDefault();
            return (res.price, res.weight);
        }

        public (decimal price, decimal weight) GetConcretePriceAndWeight(int p_id, PizzaSize ps)
        {
            pizza concrete_pizza = db.pizza.FirstOrDefault(p => p.id == p_id);
            if (concrete_pizza == null)
                throw new ArgumentException($"Pizza with ID {p_id} not found");
            var totalPrice = (from ingredients in concrete_pizza.ingredients join ingredients
                              on concrete_pizza.)
        }
    }
}
