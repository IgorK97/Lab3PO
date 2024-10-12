using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DelStatusDto
    {
        public DelStatusDto()
        {

        }
        public int Id { get; set; }
        
        public string description { get; set; }
        public DelStatusDto(DelStatus ds)
        {
            Id = ds.id;
            description = ds.description;
        }
    }
}
