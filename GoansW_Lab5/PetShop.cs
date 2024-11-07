namespace GoansW_Lab5
{
    public class PetShop
    {
        public List<FantasyPet> pets;

        public PetShop()
        {
            pets = new List<FantasyPet>(); //creates a new list in memory
        }
        public void AddPet(FantasyPet pet) //adds a pet to the list and gives feedback
        {
            pets.Add(pet);
            Console.WriteLine("You've successfully added a pet to the shop!");
            Console.WriteLine();
        }
        public void ListPets()
        {
            foreach (var pet in pets) //goes through every pet in the shop and describes it
            {
                Console.WriteLine("List of all the pets in the shop:");
                pet.DescribePet();
                Console.WriteLine();
            }
        }
    }
}
