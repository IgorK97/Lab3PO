using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class OrderService
    {
        PhonesContext db;
        public OrderService()
        {
            db = new PhonesContext();
        }

        public bool MakeOrder(OrderDto orderDto)
        {
            List<Phone> orderedphones = new List<Phone>();
            decimal sum = 0;
            foreach (var pId in orderDto.OrderedPhonesIds)
            {
                Phone phone = db.Phones.Find(pId);
                // валидация
                if (phone == null)
                    throw new Exception("Телефон не найден");
                sum += phone.Cost;
                orderedphones.Add(phone);
            }
            // применяем скидку
            sum = new Discount(0.1m).GetDiscountedPrice(sum);

            Order order = new Order
            {
                Date = DateTime.Now,
                Address = orderDto.Address,
                Total = sum,
                PhoneNumber = orderDto.PhoneNumber,
                Customer = orderDto.Customer,
                Phones = orderedphones
            };
            db.Orders.Add(order);
            if (db.SaveChanges() > 0)
                return true;
            return false;

        }


        public List<OrderDto> GetAllOrders()
        {
            return db.Orders.ToList().Select(i => new OrderDto(i)).ToList();
        }
    }
}
