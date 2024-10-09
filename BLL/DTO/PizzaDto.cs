using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    internal class PizzaDto
    {
        public PizzaDto()
        {
            
        }
        
        public int Id { get; set; }
        
        public string C_name { get; set; }
        
        public bool active { get; set; }
        
        public string description { get; set; }
        public byte[] pizzaimage { get; set; }

        public List<int> listedingredientsIds { get; set; }

        public PizzaDto(pizza p)
        {
            Id=p.id;
            C_name = p.C_name;
            active = p.active;
            description = p.description;
            pizzaimage=p.pizzaimage;
            listedingredientsIds=p.ingredients.Select(i => i.id).ToList();
        }
    }
}
