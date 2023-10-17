using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetApp
{
    // Class: Program
    // Author: Christine Espeleta
    // Purpose: Pet App Console Application
    // Restrictions: N/A

    internal class Program
    {
        static void Main(string[] args)
        {
            // reference variables for the pets and interfaces
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            // create list of pets
            Pets pets = new Pets();
            // create random number generator
            Random rand = new Random();

        start:
            //iterate through this 50 times
            for (int i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    // you get a dog
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");
                        // create dog instance with a placeholder for license
                        dog = new Dog("license");
                        // add a dog to pets
                        pets.Add(dog);
                        // get dog's name, repeat until not blank
                        do
                        {
                            Console.Write("Dog's Name => ");
                            dog.Name = Console.ReadLine();
                            if (dog.Name.Length > 0)
                            {
                                break;
                            }
                        } while (true);
                        // get dog's age, repeat until an integer or not blank
                        do
                        {
                            Console.Write("Age => ");
                            string sDogAge = Console.ReadLine();
                            if (sDogAge.Length > 0)
                            {
                                if (int.TryParse(sDogAge, out dog.age))
                                {
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        } while (true);
                        // get dog's license, repeat until not blank
                        do
                        {
                            Console.Write("License => ");
                            dog.license = Console.ReadLine();
                            if (dog.license.Length > 0)
                            {
                                break;
                            }
                        } while (true);
                    }
                    else
                    {
                        // else add a cat
                        Console.WriteLine("You bought a cat!");
                        // create cat instance
                        cat = new Cat();
                        // add cat to pets
                        pets.Add(cat);
                        // get cat's name, repeat until not blank
                        do
                        {
                            Console.Write("Cat's Name => ");
                            cat.Name = Console.ReadLine();
                            if (cat.Name.Length > 0)
                            {
                                break;
                            }
                        } while (true);
                        // get cat's age, repeat until an integer or not blank
                        do
                        {
                            Console.Write("Age => ");
                            string sCatAge = Console.ReadLine();
                            if (sCatAge.Length > 0)
                            {
                                if (int.TryParse(sCatAge, out cat.age))
                                {
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        } while (true);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0, pets.Count)];
                    // run it back if there are no pets
                    if (thisPet == null)
                    {
                        goto start;
                    }
                    else
                    {
                        Random methodRand = new Random();
                        // dog interface if pet selected is a dog
                        if (thisPet.GetType() == typeof(Dog))
                        {
                            iDog = (Dog)thisPet;
                        }
                        // cat interface if pet selected is a cat
                        if (thisPet.GetType() == typeof(Cat))
                        {
                            iCat = (Cat)thisPet;
                        }
                        Console.Write(thisPet.Name + ": ");
                        // choose a method depending on random number generated
                        switch (methodRand.Next(1, 6))
                        {
                            case 1:
                                thisPet.Eat();
                                break;
                            case 2:
                                thisPet.Play();
                                break;
                            case 3:
                                if (thisPet.GetType() == typeof(Dog))
                                {
                                    iDog.Bark();
                                }
                                if (thisPet.GetType() == typeof(Cat))
                                {
                                    iCat.Scratch();
                                }
                                break;
                            case 4:
                                if (thisPet.GetType() == typeof(Dog))
                                {
                                    iDog.NeedWalk();
                                }
                                if (thisPet.GetType() == typeof(Cat))
                                {
                                    iCat.Purr();
                                }
                                break;
                            case 5:
                                thisPet.GotoVet();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
    // Class: Pets
    // Author: Christine Espeleta
    // Purpose: Store list of pets, pet count, and allow for user to add pets.
    // Restrictions: N/A
    public class Pets
    {
        List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }

    // Class: Pet
    // Author: Christine Espeleta
    // Purpose: Serve as parent class for Cat and Dog.
    // Restrictions: N/A
    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        public Pet()
        {

        }
        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    // Class: Dog
    // Author: Christine Espeleta
    // Purpose: Inherit from Pet parent class and IDog interface.
    // Restrictions: N/A
    public class Dog : Pet, IDog
    {
        public string license;
        public override void Eat()
        {
            Console.WriteLine("Yummy, I will eat everything!");
        }
        public override void Play()
        {
            Console.WriteLine("Throw the ball, throw the ball!");
        }
        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
        public void NeedWalk()
        {
            Console.WriteLine("Woof woof, I need to go out.");
        }
        public override void GotoVet()
        {
            Console.WriteLine("Whimper, whimper, no vet!");
        }
        public Dog(string license) : base()
        {
            this.license = license;
        }
    }

    // Class: Cat
    // Author: Christine Espeleta
    // Purpose: Inherit from Pet parent class and ICat interface.
    // Restrictions: N/A
    public class Cat : Pet, ICat
    {
        public override void Eat()
        {
            Console.WriteLine("Yuck, I don't like that!");
        }
        public override void Play()
        {
            Console.WriteLine("Where's that mouse...");
        }
        public void Purr()
        {
            Console.WriteLine("Purrrrr...");
        }
        public void Scratch()
        {
            Console.WriteLine("Hiss!");
        }
        public override void GotoVet()
        {
            Console.WriteLine("Hiss, no vet!");
        }
        public Cat()
        {

        }
    }

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();
    }

    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();
        void GotoVet();
    }
}