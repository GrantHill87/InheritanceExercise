using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird seagull = new Bird()
            {
                Name = "Ferdinand",
                Age = 1.25,
                IsHealthy = true,
                Extremities = 5,
                Feathered = true,
                Flightless = false,
                PreferredFood = "the greasy beach boardwalk variety. Anything from french fries, to half eaten cheese steaks, and the occasional seafood.",
                LikesWater = true,
            };

            Bird ostrich = new Bird()
            {
                Name = "Luisa",
                Age = 11.40, 
                IsHealthy = true,
                Extremities = 5,
                Feathered = true,
                Flightless = true,
                PreferredFood = "seeds, grasses, fruits, shrubs, flowers.... and a pebble or two.",
                LikesWater = false,
            };

            Bird eagle = new Bird()
            {
                Name = "Frank",
                Age = 15.72,
                IsHealthy = true,
                Extremities = 5,
                Feathered = true,
                Flightless = false,
                PreferredFood = "small mammals, salmon, catfish, and herring.",
                LikesWater = false,
            };
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile frog = new Reptile()
            {
                Name = "Ralph",
                Age = 2.53,
                IsHealthy = true,
                Extremities = 4,
                IsWarmBlooded = false,
                HasToughSkin = false,
                IsAmphibian = true,
                EvolutionaryAdvantage = "toxic skin."
            };

            Reptile crocodile = new Reptile()
            {
                Name = "Marianna",
                Age = 18.00,
                IsHealthy = false,
                Extremities = 4,
                IsWarmBlooded= false,
                HasToughSkin = true,
                IsAmphibian = true,
                EvolutionaryAdvantage = "strong jaws and a powerful tail."
            };

            Reptile giantPlatedLizard = new Reptile()
            {
                Name = "Dorothy",
                Age = 13.13,
                IsHealthy = true,
                Extremities = 4,
                IsWarmBlooded = true,
                HasToughSkin = true,
                IsAmphibian = false,
                EvolutionaryAdvantage = "durable skin, and is also a diplomatic species, as they get along quite well with the mongoose."
            };

            Animal rhino = new Animal()
            {
                Name = "Boris",
                Age = 27.00,
                IsHealthy = true,
                Extremities = 5,
            };

            Console.WriteLine("This is the inheritance exercise.");
            Console.WriteLine();
            Console.WriteLine("Below, we will display information of specific classes whose attributes are partially inherited from another class.");
            Console.WriteLine();
            Console.WriteLine($"Let's go ahead and start with {giantPlatedLizard.Name}. {giantPlatedLizard.Name}, the Giant Plated Lizard, is of the friendly variety, when it comes to keeping good company!");
            Console.WriteLine($"She's around {giantPlatedLizard.Age} years old and while she hasn't been to the veterinarian lately, I'd be willing to bet she carries a clean bill of health; {giantPlatedLizard.IsHealthy}.");
            Console.WriteLine($"Her body temperature is usually on the colder side, but with the sun out so bright today, it seems {giantPlatedLizard.IsWarmBlooded} that she's warm blooded.");
            Console.WriteLine($"It's {giantPlatedLizard.HasToughSkin} that {giantPlatedLizard.Name} has plated skin, and it would be {giantPlatedLizard.IsAmphibian} to assume that she could breathe underwater.");
            Console.WriteLine($"Having {giantPlatedLizard.Extremities} legs, {giantPlatedLizard.Name}'s presumed advantage as a species, is she has {giantPlatedLizard.EvolutionaryAdvantage}");
            Console.WriteLine();
            Console.WriteLine($"Cruising over the parking lot of a nearby eatery along the boardwalk, of the local beach; it's {seagull.Name}! An old geezer at {seagull.Age} years old, {seagull.Name}'s bill of health is questionable.");
            Console.WriteLine($"Being a Seagull, {seagull.Name}'s favorite diet consists of {seagull.PreferredFood} Though apparently it's {seagull.IsHealthy} that he's a healthy bird.");
            Console.WriteLine($"{seagull.Feathered} enough, that seagull's got feathers alright! Despite eating lots of carbs and calories, {seagull.Name} can waddle around like a champ, but it's {seagull.Flightless} if you thought he couldn't fly too.");
            Console.WriteLine($"Armed with a beak, {seagull.Name} has about {seagull.Extremities} external body parts, using his wings and feet to help him fish for seafood out in the ocean, in which it's {seagull.LikesWater} that he likes cooling off in the water.");
            Console.WriteLine();
            Console.WriteLine($"Running 'round the fence of longest yard; it's {ostrich.Name}. Unable to fly, it's {ostrich.Flightless} that {ostrich.Name} can run very fast.");
            Console.WriteLine($"{ostrich.Feathered}; being a feathered bird (an Ostrich) has its ups and downs, must get real hot in the summer! With her long neck and beak, {ostrich.Name} uses her {ostrich.Extremities} extremeties to help her consume a healthy diet of {ostrich.PreferredFood}.");
            Console.WriteLine($"At {ostrich.Age} years old, I would agree it's {ostrich.IsHealthy} that {ostrich.Name}'s health is in good shape, being a younger ostrich and, how {ostrich.LikesWater} it would be to think that she likes swimming.");
            Console.WriteLine();
            Console.WriteLine($"Hiding in the murky swamp down the street, there's {crocodile.Name}. Sadly, {crocodile.Name} hasn't been feeling very well today, so it would be {crocodile.IsHealthy} to believe that she's feeling ok, since she just puked up some rotten fish.");
            Console.WriteLine($"{crocodile.Name} has likely seen better days, at only {crocodile.Age} years of age, she's been around for awhile, and it's {crocodile.HasToughSkin} that her scaly exterior makes her one tough cookie.");
            Console.WriteLine($"Even though she has one big mouth, {crocodile.Name}'s {crocodile.Extremities} legs help carry her across the land, but be careful not to let her bite you! She's got {crocodile.EvolutionaryAdvantage}");
            Console.WriteLine($"If you thought she was warm blooded, you'd be {crocodile.IsWarmBlooded}ly correct, but she's {crocodile.IsAmphibian}-ly amphibious! The life of a crocodile....");
            Console.WriteLine();
            Console.WriteLine($"The dancing frog, leaping from one water lily to the next, {frog.Name} is on the move. He heard somewhere, at somepoint, that if he found himself a princess, he might become a prince.");
            Console.WriteLine($"{frog.Name} is around {frog.Age} years old, and has {frog.Extremities} limbs to help him navigate both land and water, but be careful not to touch him, as he has {frog.EvolutionaryAdvantage}");
            Console.WriteLine($"It'd be {frog.IsWarmBlooded} to think that {frog.Name} was warm blooded, and {frog.HasToughSkin} to believe he has a hardened skin, but it remains {frog.IsHealthy} that he's healthy, and {frog.IsAmphibian} that he's amphibious.");
            Console.WriteLine();
            Console.WriteLine($"Next up to bat; it's {eagle.Name} (not {eagle.Name} the tank). At the ripe age of {eagle.Age} years, he's still got lots to live for, but be cautious not to leave your pets outside if he's nearby, as he prefers to eat {eagle.PreferredFood}");
            Console.WriteLine($"{eagle.Name} will use his powerful beak, massive talons, as part of his {eagle.Extremities} extremities, to fly about, but also to target his next meal.");
            Console.WriteLine($"I don't know if he's a bald eagle or not, but he has way better than 20/20 vision, sounds like a {eagle.IsHealthy} statement, in that he has a good bill of health.");
            Console.WriteLine($"It might also be {eagle.Feathered} that {eagle.Name} is feathered, but {eagle.Flightless} that he's flightless, and somewhat {eagle.LikesWater} that he prefers a watery environment.");
            Console.WriteLine();
            Console.WriteLine($"Last, but certainly not least, is the almighty {rhino.Name}. At {rhino.Age} years old, trampling about with his {rhino.Extremities} external body parts (his horn included), it's {rhino.IsHealthy} that {rhino.Name} is one healthy Rhino.");
        }
    }
}
