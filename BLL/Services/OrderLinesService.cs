using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class OrderLinesService
    {
        private PhonesContext db;
        public PhoneService()
        {
            db = new PhonesContext();
        }

        public List<PhoneDto> GetAllPhones()
        {
            return db.Phones.ToList().Select(i => new PhoneDto(i)).ToList();
        }


        public PhoneDto GetPhone(int Id)
        {
            return new PhoneDto(db.Phones.Find(Id));
        }

        public void CreatePhone(PhoneDto p)
        {
            db.Phones.Add(new Phone() { Cost = p.Cost, ManufacturerId = 1, Name = p.Name, Description = p.Description });
            Save();
            //db.Phones.Attach(p);
        }

        public void UpdatePhone(PhoneDto p)
        {
            Phone ph = db.Phones.Find(p.Id);
            ph.Name = p.Name;
            ph.Cost = p.Cost;
            ph.Description = p.Description;
            ph.ManufacturerId = p.ManufacturerId;
            Save();
        }

        public void DeletePhone(int id)
        {
            Phone p = db.Phones.Find(id);
            if (p != null)
            {
                db.Phones.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<ManufacturerDto> GetManufacturers()
        {
            return db.Manufacturers.ToList().Select(i => new ManufacturerDto(i)).ToList();
        }
    }
}
