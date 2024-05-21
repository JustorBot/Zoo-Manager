using System;

namespace ZooManager
{
    // IMateable interface
    public interface IMateable//Justin Ferreira
    {
        string Species { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string HealthStatus { get; set; }
        string Food { get; set; }
        string Water { get; set; }
        string Movable { get; set; }
        string Location { get; set; }
        DietInfo DietInfo { get; set; } 
        string SleepTimes { get; set; }
        string ZooTime { get; set; }
        string Cost { get; set; }

        bool CanMate();
    }

    //Enums
    public enum AnimalType//Justin Ferreira
    {
        Mammal,
        Bird,
        Reptile,
        Amphibian,
        Fish,
        Invertebrate,
        Lion,
        Raccoon,
        Elephant,
        Snake,
        Bear,
        Tiger,
        Giraffe,
        Hippo,
        Zebra,
        Kangaroo,
        Koala,
        Panda,
        Gorilla,
        Chimpanzee,
        Parrot,
        Owl,
        Eagle,
        Falcon,
        Hawk,
        Pigeon,
        Crow,
        Sparrow,
        Peacock,
        Penguin,
        Ostrich,
        Emu,
        Turtle,
        Crocodile,
        Alligator,
        Lizard,
        Gecko,
        Iguana,
        Salamander,
        Frog,
        Toad,
        Newt,
        Goldfish,
        Clownfish,
        Betta,
        Guppy,
        Angelfish,
        Tetra,
        Catfish,
        Salmon,
        Shark,
        Whale,
        Dolphin,
        Octopus,
        Squid,
        Jellyfish,
        Crab,
        Lobster,
        Shrimp,
        Snail,
        Slug,
        Spider,
        Scorpion
    }

    public enum FoodType//Justin Ferreira
    {
        Meat,
        Vegetation,
        Mixed,
        Insects,
        Seeds,
        Fruits,
        Nectar,
        Plankton,
        Krill,
        Algae,
        SmallFish,
        Rodents,
        Berries,
        Grass,
        Leaves,
        Worms,
        Crustaceans,
        Carrion,
        SmallMammals,
        Unknown
    }

    public enum HabitatType
    {
        Desert,
        Forest,
        Aquatic,
        Grassland,
        Tundra,
        Mountain,
        Jungle,
        Savannah,
        Wetland,
        Arctic,
        Marsh,
        Swamp,
        Ocean,
        River,
        Lake,
        Pond,
        Cave,
        Urban,
        Suburban,
        Rural,
        Unknown
    }


    // Structs
    public struct DietInfo//Justin Ferreira
    {
        public string Description;
        public FoodType FoodType;
        public HabitatType HabitatType;
    }

    // Animal class
    public class Animal : IMateable//Justin Ferreira
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string HealthStatus { get; set; }
        public string Food { get; set; }
        public string Water { get; set; }
        public string Movable { get; set; }
        public string Location { get; set; }
        public DietInfo DietInfo { get; set; }
        public string SleepTimes { get; set; }
        public string ZooTime { get; set; }
        public string Cost { get; set; }

        public Animal(string species, string name, int age, string healthStatus, string food, string water, string movable, string location, DietInfo dietInfo, string sleepTimes, string zooTime, string cost)
        {
            Species = species;
            Name = name;
            Age = age;
            HealthStatus = healthStatus;
            Food = food;
            Water = water;
            Movable = movable;
            Location = location;
            DietInfo = dietInfo; 
            SleepTimes = sleepTimes;
            ZooTime = zooTime;
            Cost = cost;
        }

        public virtual bool CanMate()//Justin Ferreira
        {
            return false; // Generic animal can't mate
        }
    }

    // Lion class
    public class Lion : Animal//Justin Ferreira
    {
        public Lion(string name, int age, string healthStatus, string food, string water, string movable, string location, DietInfo dietInfo, string sleepTimes, string zooTime, string cost)
            : base("Lion", name, age, healthStatus, food, water, movable, location, dietInfo, sleepTimes, zooTime, cost)
        {
        }

        // Lion-specific CanMate method
        public override bool CanMate()
        {
            // Lions can mate after 3 years
            return Age > 3;
        }
    }

    // Donkey class
    public class Donkey : Animal//Justin Ferreira
    {
        public Donkey(string name, int age, string healthStatus, string food, string water, string movable, string location, DietInfo dietInfo, string sleepTimes, string zooTime, string cost)
            : base("Donkey", name, age, healthStatus, food, water, movable, location, dietInfo, sleepTimes, zooTime, cost)
        {
        }

        // Donkey-specific CanMate method
        public override bool CanMate()
        {
            // Donkeys can mate after 2 years
            return Age > 2;
        }
    }

    // Raccoon class
    public class Raccoon : Animal//Justin Ferreira
    {
        public Raccoon(string name, int age, string healthStatus, string food, string water, string movable, string location, DietInfo dietInfo, string sleepTimes, string zooTime, string cost)
            : base("Raccoon", name, age, healthStatus, food, water, movable, location, dietInfo, sleepTimes, zooTime, cost)
        {
        }

        // Raccoon-specific CanMate method
        public override bool CanMate()
        {
            // Raccoons can mate after 1 year
            return Age > 1;
        }
    }

    // Elephant class
    public class Elephant : Animal//Justin Ferreira
    {
        public Elephant(string name, int age, string healthStatus, string food, string water, string movable, string location, DietInfo dietInfo, string sleepTimes, string zooTime, string cost)
            : base("Elephant", name, age, healthStatus, food, water, movable, location, dietInfo, sleepTimes, zooTime, cost)
        {
        }

        // Elephant-specific CanMate method
        public override bool CanMate()
        {
            // Elephants can mate after 5 years
            return Age > 5;
        }
    }

    // Snake class
    public class Snake : Animal//Justin Ferreira
    {
        // Constructor with minimal parameters, with default values for the rest
        public Snake(string name, int age)
            : base("Snake", name, age, "Healthy", "Insects", "Water", "Serpentine", "Terrarium", new DietInfo { Description = "Carnivorous", FoodType = FoodType.Mixed }, "Nocturnal", "Anytime", "Low")
        {
        }

        // Snake-specific constructor with full parameters
        public Snake(string species, string name, int age, string healthStatus, string food, string water, string movable, string location, DietInfo dietInfo, string sleepTimes, string zooTime, string cost)
            : base(species, name, age, healthStatus, food, water, movable, location, dietInfo, sleepTimes, zooTime, cost)
        {
        }

        // Snake-specific CanMate method
        public override bool CanMate()
        {
            // Snakes can mate after 2 years
            return Age > 2;
        }
    }
}
//Justin Ferreira