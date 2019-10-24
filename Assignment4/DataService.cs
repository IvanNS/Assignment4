using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseService;
using Microsoft.EntityFrameworkCore;

namespace Assignment4
{
    public class DataService
    {
        public List<Category> GetCategories()
        {
            using var db = new NorthwindContext();
            return db.Categories.ToList();
        }
        public List<Order> GetOrders()
        {
            using var db = new NorthwindContext();
            return db.Orders.ToList();
        }
    }
}
