using AspNetMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvc.ViewModels {
    public class CustomerOrders {

        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }

        public CustomerOrders() {

        }
    }
}