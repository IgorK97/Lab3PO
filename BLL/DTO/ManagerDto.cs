using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ManagerDto
    {
        public ManagerDto()
        {

        }
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string C_password { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public ManagerDto(managers m)
        {
            Id = m.id;
            first_name = m.first_name;
            last_name = m.last_name;
            surname = m.surname;
            login = m.login;
            phone = m.phone;
            email = m.email;
            C_password=m.C_password;
        }
    }
}
