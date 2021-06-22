using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [ForeignKey(nameof(CustomerID))]
        public virtual Customer Customer { get; set; }

        [Required]
        public int PurchaseQuantity { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }
    }
}