using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvc.Models {
    public class Order {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Description { get; set; }

        public decimal Total { get; set; } = 0;

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Order() {

        }
    }
}