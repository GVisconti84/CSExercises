using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{

    public class Invoice
    {
        public string Description { get; set; }
        public string Number { get; set; }
        public int Quantity { get; set; }
           
        public decimal PricePerItem
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                     price = value;
            }
        }

        private decimal price;
        public Invoice(string invoiceNumber, string description, int quantity, decimal pricePerItem)
        {
            Number = invoiceNumber;
            Description = description;
            PricePerItem = pricePerItem;
            Quantity = quantity;
        }

        
        public decimal GetInvoiceAmount(int quantity, decimal pricePerItem)
        {
            decimal finalPrice;
            finalPrice = quantity * pricePerItem;
            return finalPrice ;
        }
       
        
    }
}
