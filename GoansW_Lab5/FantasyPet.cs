using System.ComponentModel.DataAnnotations;

namespace GoansW_Lab5
{
    public class FantasyPet
    {
        public string Name { get; set; } //assigns attributes
        public string Species { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public string MagicPower { get; set; }
        public FantasyPet(string name, string species, int age, decimal price, string magicPower)
        {
            Name = name;
            Species = species;
            Age = age;
            Price = price;
            MagicPower = magicPower;
        }
        public void DescribePet() //describes the pet in format
        {
            Console.WriteLine($"Name        : {Name}");
            Console.WriteLine($"Species     : {Species}");
            Console.WriteLine($"Age         : {Age}");
            Console.WriteLine($"Price       : {Price}");
            Console.WriteLine($"Magic Power : {MagicPower}");
            Console.WriteLine();
        }

        public void DiscountPrice(decimal percent) //calculates the price based on percentage discount
        {
            decimal discount = Price * percent;
            decimal balance = Price - discount;
            Console.WriteLine($"{Name} : {balance}");
            Console.WriteLine();
        }
        
        public void PerformMagic() //shows which pet does what magic power
        {
            Console.WriteLine($"{Name} {MagicPower}!");
            Console.WriteLine();
        }
    }
}
