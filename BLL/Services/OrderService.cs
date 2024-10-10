using DAL;
using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class OrderService
    {
        MyPizzaDeliveryContext db;
        public OrderService()
        {
            db = new MyPizzaDeliveryContext();
        }

        public bool MakeOrder(OrderDto orderDto)
        {
            List<order_lines> orderlines = new List<order_lines>();
            decimal sum = 0;
            decimal weight = 0;
            foreach (var pId in orderDto.order_linesIds)
            {
                order_lines ol = db.order_lines.Find(pId);
                // валидация
                if (ol == null)
                    throw new Exception("Строка заказа не найдена");
                sum += ol.position_price;
                weight += ol.weight;
                orderlines.Add(ol);
            }


            orders order = new orders
            {
                clientId = orderDto.clientId,
                final_price = orderDto.final_price,
                weight = orderDto.weight,
                ordertime = DateTimeOffset.Now,
                delstatusId = 1,
                order_lines = orderlines,
                address_del=orderDto.address_del
            };

            db.orders.Add(order);
            if (db.SaveChanges() > 0)
                return true;
            return false;

        }


        public List<OrderDto> GetAllOrders(int ClientId)
        {
            return db.orders.ToList().Where(i => i.clientId==ClientId).Select(i => new OrderDto(i)).ToList();
        }
    }
}
