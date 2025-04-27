namespace Task2
{
    class Product
    {

      

        public string Name;
        public string Description;
        public int Count { get; set; }
        public bool IsStock;
        private double _price;

        public Product(string name, int count, double price, string description)
        {
            Name = name;
            Description = description;
            Count = count;
            if (Count > 0) { IsStock = true; }
            _price = price;
        }
        

        public string Sale()
        {
            if (IsStock)
            {
                Console.WriteLine("Mehsul satildi!");
                Count--;
                if (Count == 0)
                {
                    IsStock = false;
                }
            }
            return "Mehsul yoxdur!";
        }


    }
}
