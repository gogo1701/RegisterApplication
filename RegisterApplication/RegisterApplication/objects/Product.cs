using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterApplication.objects
{
    internal class Product
    { 
        public int ID { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
       
        public string Barcode { get; set; }
        public string? Notes { get; set; }
    }
}
