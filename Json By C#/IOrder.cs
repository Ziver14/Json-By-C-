using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_By_C_
{
    public interface IOrder
    {
        void AddProduct(Product product,int quantity);
        void RemoveProduct(int ProductId);
        decimal GetTotalPrice();
    }
}
