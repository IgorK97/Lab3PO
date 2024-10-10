using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity;
using DAL;
using System.Runtime.Remoting.Contexts;

namespace BLL.Services
{
    internal class ReportService
    {
        public class OrdersByMonth
        {
            public int order_id {  get; set; }
            public string Courier { get; set; }
            public DateTimeOffset Date { get; set; }
        }
        public class ParResult
        {
            public int order_id { get; set; }
            public int client_id { get; set; }
            public int courier_id {  get; set; }
            public string client_full_name { get; set; }
            public string courier_full_name { get; set; }
            public DateTimeOffset order_date { get; set; }
        }
        
        public static List<OrdersByMonth> ExecuteSP(int month, int year, int ClientId)
        {

            MyPizzaDeliveryContext dbContext = new MyPizzaDeliveryContext();
            NpgsqlParameter param1 = new NpgsqlParameter("month", month);
            NpgsqlParameter param2 = new NpgsqlParameter("year", year);

            var result = dbContext.Database.SqlQuery<ParResult>("select * from GetOrdersByMonthYear(@month, @year)", new object[] { param1, param2 }).ToList();
            
            var data = result.Where(i => i.client_id ==ClientId).Select(j =>
            new OrdersByMonth{ order_id=j.order_id, Courier=j.courier_full_name , Date=j.order_date }).OrderByDescending(c => c.Date).ToList();

            return data;

        }

        public class ReportData
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public static List<ReportData> ReportOrdersByMonth(int ingredientId)
        {

            MyPizzaDeliveryContext dbContext = new MyPizzaDeliveryContext();

            var request = dbContext.pizza.Where(p => p.ingredients.Any(i => i.id == ingredientId))
                .Select(p => new ReportData
                {
                    Name = p.C_name,
                    Description = p.description

                }).ToList();
            return request;
        }
    }
}

