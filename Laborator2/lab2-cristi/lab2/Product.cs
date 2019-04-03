using System;

namespace lab2
{
    public class Product
    {
        private Product()
        {

        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public double Price { get; private set; }

        public int VAT { get; private set; }

        public bool IsValid()
        {
            return EndDate > StartDate;
        }

        public double ComputeVAT()
        {
            return VAT * Price / 100;
        }

        public static Product Create(
            string name,
            string description,
            DateTime startDate, 
            DateTime endDate,
            double price, 
            int vat)
        {

            CheckParameters(name, description);

            return new Product
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                Price = price,
                VAT = vat
            };
        }

        private static void CheckParameters(string name, string description)
        {
            //defensive coding
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException();
            }
        }

    }
}
