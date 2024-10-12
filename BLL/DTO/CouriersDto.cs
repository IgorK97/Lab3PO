using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CouriersDto
    {
        public CouriersDto()
        {
        }

        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string C_password { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public CouriersDto(couriers c)
        {
            id = c.id;
            first_name = c.first_name;
            last_name = c.last_name;
            surname = c.surname;
            login = c.login;
            phone = c.phone;
            email = c.email;
            C_password = c.C_password;
        }

    }
}
