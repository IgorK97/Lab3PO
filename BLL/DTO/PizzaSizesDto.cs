using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class PizzaSizesDto
    {
        public PizzaSizesDto()
        {
            
        }
        public PizzaSizesDto(pizza_sizes ps)
        {
            Id = ps.id;
            name=ps.name;
            price=ps.price;
            weight=ps.weight;
        }
        
        public int Id { get; set; }
        
        public string name { get; set; }
        
        public decimal price { get; set; }
        
        public decimal weight { get; set; }
    }
}
