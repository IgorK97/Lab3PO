using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDto
    {
        public OrderDto()
        {

        }

        public int Id { get; set; }

        public int clientId { get; set; }
        public int? courierId { get; set; }

        public decimal final_price { get; set; }

        public string address_del { get; set; }

        public decimal weight { get; set; }
        public DateTimeOffset? ordertime { get; set; }
        public DateTimeOffset? deliverytime { get; set; }
        public int delstatusId { get; set; }
        public string comment { get; set; }

        public List<int> order_linesIds { get; set; }
        public OrderDto(orders o){
            Id = o.id;
            clientId = o.clientId;
            courierId= o.courierId;
            final_price = o.final_price;
            address_del = o.address_del;
            weight = o.weight;
            ordertime = o.ordertime;
            deliverytime = o.deliverytime;
            delstatusId = o.delstatusId;
            comment = o.comment;
            order_linesIds = o.order_lines.Select(i => i.id).ToList();
        }
    }
}
