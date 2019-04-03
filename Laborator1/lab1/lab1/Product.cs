using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Product
    {
        public Guid Id { get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }

    }
}
