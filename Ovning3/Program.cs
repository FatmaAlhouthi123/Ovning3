using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ovning3 {
    class Program {
        static void Main(string[] args) {
            /*
            Person person = new Person(198952305558, 22,"adam", "robson", 166, 65);
            try { person.FName = "bbb"; }
            catch(ArgumentException e)
            { Console.WriteLine(e.Message); }

            try { person.LName = "aaa"; }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }

            try { person.Age = 5; }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }

            person.Height = 160;
            person.Weight = 66.5;
            */
            try
            {
                PersonHandleren ph = new PersonHandleren();
                Person adam = new Person();
                ph.SetFname(adam, "Adam");
                ph.SetLname(adam, "Peterson");
                ph.SetAge(adam, 40);
                ph.SetWeight(adam, 80);
                ph.SetHeight(adam, 180);
                ph.SetNationality(adam, "Sweden");
                ph.SetResidence(adam, "Kanada");
                ph.SetJob(adam, "teacher");

                ph.CreatePerson(20, "Jasmin", "Dal", 165, 55);
            }

            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Horse horse = new Horse();
            Console.WriteLine(horse.Age);
            Horse x = horse.CreateHorse(10, "horse", 70, 166);
            Console.WriteLine(x.Age);

            Hedgehog hedgehog = new Hedgehog();
            Console.WriteLine(hedgehog.SelfDefenseMeans);

            Worm worm = new Worm();
            Console.WriteLine(worm.Movement);
            worm.DoSound();

            List<Animal> animalList = new List<Animal>();
            Dog dog = new Dog();
            dog.CreateDog(12, "Boobie", 14, "German Sherd");
            animalList.Add(dog.CreateDog(12, "Boobie", 14, "German Sherd"));

            Bird bird = new Bird();
            animalList.Add(bird.CreateBird(12, "leo", 3, 4));

           
            animalList.Add(worm.CreateWorm(1, "mask", 1, false));

            Wolf wolf = new Wolf();
            animalList.Add(wolf.CreateWolf(1, "Woofy", 2));


            Pelican  pelican = new Pelican();
            animalList.Add(pelican.CreatePelican(1, "peli", "red"));

            Swan swan = new Swan();
            animalList.Add(swan.CreateSwan(1, "fluffy", 5));




            //Hedgehog hedgehog = new Hedgehog();
            animalList.Add(hedgehog.CreateHedehog(1, "Quick", 1, 100));

            foreach (Animal animal in animalList)
            {
               
                Console.WriteLine(animal.DoSound());
                Console.WriteLine(animal.Stats());

                // 14.Skriv ut ​Stats() ​metoden enbart för alla hundar genom en foreach på  ​Animals.
               if(animal is Dog)
                Console.WriteLine(animal.Stats());

                //Kommer du åt den metoden från ​Animals ​listan?17.F: Varför inte?
                //Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på ​Animals.
                // answer is by casting animal to dog
                // (Dog)animal.OptionalMethod();       doesnt work although i made casting animal to dog

            }

            Wolfman wolfman = new Wolfman();
            
            animalList.Add(wolfman.CreateWolf(11, "half wolf", 70));



            /*     7.Gör en check i For-loopen ifall animal även 
             *     är av typen Person, om den är det typ-casta tillPerson
             *     och anropa dess Talk() metod*/


            for (int i = 0; i < animalList.Count; i++) {
                
               // if (animalList[i] is IPerson)
                    //(IPerson)animalList[i].Talk();
                /*
                 cast animal to type IPerson 
                BUT som thing wrong with casting  (IPerson)animalList[i].Talk();   

                
                 */
            }
            List<Dog> dogList = new List<Dog>();

             
                
                    
                   
           

            }

            

















        }
    }

