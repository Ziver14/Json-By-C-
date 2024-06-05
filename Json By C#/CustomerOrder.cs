using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_By_C_
{
    public class CustomerOrder:Order
    {
        public string CustomerName {  get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone {  get; set; }
    }
}
