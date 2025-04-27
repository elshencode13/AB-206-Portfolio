using System.Diagnostics;
using System.Xml.Linq;
using Task2;

namespace Task2
{
    class Notebook : Product
    {


        public Notebook(string Name, int Count, int Price, byte RAM, int storage = 128, string Description = "Null") :
        base(Name, Count, Price, Description)

        {
            _RAM = RAM;
            Storage = storage;
        }
        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0 && value < 10000)
                {
                    _price = Price;
                }
                else
                {

                    Console.WriteLine("Qiymeti duzgun daxil edin!");

                }
            }
        }
        public int Storage;

        private byte _RAM;
        public byte RAM
        {
            get { return _RAM; }
            set
            {
                if (value > 0)
                {
                    _RAM = RAM;
                }
                else
                {
                    Console.WriteLine("Rami duzgun daxil edin.");
                }
            }
        }


        public string GetFullInfo()
        {
            return new string($"Name: {Name}\nCount: {Count}\nPrice: {Price}\nRAM: {RAM}\nStorage: {Storage}\nDescription: {Description}");
        }
        public void ShowFullData()
        {
            Console.WriteLine(GetFullInfo());
        }

        


    }
}