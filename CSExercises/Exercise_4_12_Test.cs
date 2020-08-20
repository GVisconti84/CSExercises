using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    public class InvoiceTest
    {
        public static void LocalMain(string[] args)
        {
            Invoice fattura = new Invoice("43", "Pen Drive", 5, 15.31M);

            Console.WriteLine("Invoice Number: {0}", fattura.Number);
            Console.WriteLine("Invoice Description: {0}", fattura.Description);
            Console.WriteLine("Quantity: {0}", fattura.Quantity);
            Console.WriteLine("Price Per Item: {0:C}\n", fattura.PricePerItem);
            Console.WriteLine("Total Invoice: {0:C}", fattura.GetInvoiceAmount(fattura.Quantity, fattura.PricePerItem));
        }
    }
}
