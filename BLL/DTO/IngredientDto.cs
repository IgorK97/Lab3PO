using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class IngredientDto
    {
        public IngredientDto()
        {
            
        }
        public int Id { get; set; }
        
        public string C_name { get; set; }
        
        public decimal price_per_gram { get; set; }
        
        public decimal small { get; set; }
        
        public decimal medium { get; set; }
        
        public decimal big { get; set; }
        
        public bool active { get; set; }
        public byte[] ingrimage { get; set; }

        public IngredientDto(ingredients i)
        {
            Id = i.id;
            C_name = i.C_name;
            price_per_gram= i.price_per_gram;
            small = i.small;
            medium = i.medium;
            big = i.big;
            active = i.active;
            ingrimage = i.ingrimage;
        }
    }
}
