namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            //var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            //Console.WriteLine(car.ToString());
            ////Make: Skoda
            ////Model: Fabia
            ////HorsePower: 65
            ////RegistrationNumber: CC1856BG

            //var parking = new Parking(5);
            //Console.WriteLine(parking.AddCar(car));
            ////Successfully added new car Skoda CC1856BG

            //Console.WriteLine(parking.AddCar(car));
            ////Car with that registration number, already exists!

            //Console.WriteLine(parking.AddCar(car2));
            ////Successfully added new car Audi EB8787MN

            //Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            ////Make: Audi
            ////Model: A3
            ////HorsePower: 110
            ////RegistrationNumber: EB8787MN

            //Console.WriteLine(parking.RemoveCar("EB8787MN"));
            ////Successfullyremoved EB8787MN

            //Console.WriteLine(parking.Count); //1

            var trainers = new List<Trainer>();



            while (true)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Tournament")
                {
                    break;
                }

                string trainerName = command[0];
                string pokemonName = command[1];
                string pokemonElement = command[2];
                double pokemonHealth = double.Parse(command[3]);

                var trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer!= null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    var newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(newTrainer);
                }

            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                else 
                {
                    for (int i = 0; i < trainers.Count; i++)
                    {
                        if (trainers[i].Pokemons.Any(x=>x.Element == command))
                        {
                            trainers[i].NumberOfBadges++;

                            
                        }
                        else
                        {
                            for (int j = 0; j < trainers[i].Pokemons.Count; j++)
                            {
                                trainers[i].Pokemons[j].Health -= 10;
                            }

                            foreach (var item in trainers)
                            {
                                item.Pokemons.RemoveAll(x => x.Health <= 0);
                            }
                        }
                    }
                }
            }

            foreach (var item in trainers)
            {
                item.Pokemons.RemoveAll(x => x.Health <= 0);
            }

            trainers = trainers.OrderByDescending(x => x.NumberOfBadges).ToList();

            foreach (var item in trainers)
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBadges} {item.Pokemons.Count}");
            }
        }
    }
}