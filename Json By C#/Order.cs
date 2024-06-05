using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_By_C_
{
    public class Order:IOrder
    {   
        protected List<OrderItem> items = new List<OrderItem>();
        public void AddProduct(Product product, int quantity)
        {
            var existingItem = items.FirstOrDefault(i => i.Product.Id == product.Id);
            if(existingItem.Product.Id != 0)
            {
                items.Remove(existingItem);
                existingItem.Quantity += quantity;
                items.Add(existingItem);
            }
            else
            {
                items.Add(new OrderItem { Product = product, Quantity = quantity });
            }
        } 
        public void RemoveProduct(int ProductId) 
        { 
            items.RemoveAll(i => i.Product.Id == ProductId);
        }
        public decimal GetTotalPrice() 
        {
            return items.Sum(i => i.Product.Price*i.Quantity);
        }

        public List<OrderItem> GetOrderItems() { return items; }

    }
}
