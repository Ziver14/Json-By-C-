using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_By_C_
{
    public class Store
    {
        private List<Product> products = new List<Product>();
        private List<CustomerOrder> orders = new List<CustomerOrder>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddOrder(CustomerOrder order)
        {
            orders.Add(order);
        }
        public IEnumerable<Product> FindProductByName(string name) 
        { 
            return products.Where(p => p.Name.Contains(name)).ToList(); 
        }

        public IEnumerable<Product> FindProductByPriceRange(decimal min,decimal max)
        {
            return products.Where(p=>p.Price>=min && p.Price<=max).ToList();
        }

        public IEnumerable<CustomerOrder> GetOrdersByCustumerName(string custumerName)
        {
            return orders.Where(o => o.CustomerName == custumerName).ToList();
        }
    }
}
