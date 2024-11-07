using GoansW_Lab5;
using System;
using System.ComponentModel;
public class Program
{
    public static void Main()
    {
        PetShop shop = new PetShop(); //creates new petshop

        FantasyPet pet1 = new FantasyPet("Philly", "Phoenix", 3200, 3000m, "dies and comes back to life"); //creates new pets
        FantasyPet pet2 = new FantasyPet("Geronimo", "Gnome", 20, 540m, "gardens");
        FantasyPet pet3 = new FantasyPet("Whiskey", "Orc", 28, 120m, "gets drunk");

        shop.AddPet(pet1); //adds pets to the shop
        shop.AddPet(pet2);
        shop.AddPet(pet3);

        pet1.DescribePet(); //describes pets
        pet2.DescribePet();
        pet3.DescribePet();

        pet1.DiscountPrice(.15m); //determines price based on discount percent
        pet2.DiscountPrice(.25m);
        pet3.DiscountPrice(.75m);

        pet1.PerformMagic(); //demonstrates magic capability
        pet2.PerformMagic();
        pet3.PerformMagic();
        
        shop.ListPets(); //lists all of the pets and describes them

    }
}