using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity;

namespace BLL.Services
{
    internal class ReportService
    {
        public class OrdersByMonth
        {
            public string Customer { get; set; }
            public string Phones { get; set; }
            public DateTime Date { get; set; }
        }
        private class SPResult
        {
            public string Customer { get; set; }
            public string PhoneName { get; set; }
            public DateTime Date { get; set; }
        }
        public class ReportData
        {
            public string PhoneName { get; set; }
            public decimal Cost { get; set; }
        }

        //выполнить ХП
        public static List<OrdersByMonth> ExecuteSP(int month, int year)
        {
            //PhonesContext db = new PhonesContext();
            //NpgsqlParameter param1 = new NpgsqlParameter("month", month);
            //NpgsqlParameter param2 = new NpgsqlParameter("year", year);

            //var result = db.Database.SqlQuery<SPResult>("select * from Orders_getByMonth (:month,:year)", new object[] { param1, param2 }).ToList();
            //var data = result.GroupBy(i => new { i.Customer, i.Date }).ToDictionary(i => i.Key, i => i.Select(j => j.PhoneName))
            //    .Select(i => new OrdersByMonth
            //    {
            //        Customer = i.Key.Customer,
            //        Date = i.Key.Date,
            //        Phones = string.Join(",", i.Value.Select(j => j).ToArray())
            //    }).ToList();

            //return data;
            NpgsqlParameter param1 = new NpgsqlParameter("month", (int)numericUpDown1.Value);
            NpgsqlParameter param2 = new NpgsqlParameter("year", (int)numericUpDown2.Value);

            var result = dbContext.Database.SqlQuery<ParResult>("select * from GetOrdersByMonthYear(@month, @year)", new object[] { param1, param2 }).ToList();
            //var data = result.GroupBy(i => new { i.courier_full_name }).ToDictionary(i => i.Key, i => i.Select(j => j.order_id)).Select(i =>
            //new { i.Key.courier_full_name, clients = String.Join(",", i.Value.Select(j => j).ToArray()) }).ToList();

            //var data = result.GroupBy(i => new { i.courier_full_name }).ToDictionary(i => i.Key, i => i.Select(j => j.order_id)).Select(i =>
            //new { i.Key.courier_full_name, orders = String.Join(",", i.Value.Select(j => j).ToArray()) }).ToList();

            var data = result.GroupBy(i => i.courier_full_name).Select(j =>
            new { j.Key, ordercount = j.Count() }).OrderByDescending(c => c.ordercount).ToList();

            return data;
            //dataGridViewReport2.DataSource = data;

        }

        public static List<ReportData> ReportOrdersByMonth(int manufId)
        {
            PhonesContext db = new PhonesContext();
            var request = db.Phones
             .Join(db.Manufacturers, ph => ph.ManufacturerId, m => m.Id, (ph, m) => ph)
             .Where(i => i.ManufacturerId == manufId)
             .Select(i => new ReportData() { PhoneName = i.Name, Cost = i.Cost })
             .ToList();
            return request;
        }
    }
}

