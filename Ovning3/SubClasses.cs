using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3 {
    class SubClasses {
    }
    class Dog : Animal {


        private string breed;
        public string Breed {
            get;
            set;
        }

        public Dog() : base() {
            this.Breed = breed;
        }



        public Dog CreateDog(int age, string name, decimal weight, string breed) {
            Dog dog = new Dog();
            dog.Age = age;
            dog.Name = name;
            dog.Weight = weight;
            dog.Breed = breed;
            return dog;
        }

        public override string DoEat() {
            return " eats meat";
        }

        public override string DoSound() {
            return "wof wof  ";
        }

    }


    /////////////////////////////////////////////////

    class Hedgehog : Animal {

        private string selfDefenseMeans;
        public string SelfDefenseMeans {
            get;
        }
        public int NrOfSpikes {
            get;
            set;
        }


        public Hedgehog() : base() {
            this.SelfDefenseMeans = "Thistle";
        }



        public Hedgehog CreateHedehog(int age, string name, decimal weight, int nrOfSpikes) {
            Hedgehog hedgehog = new Hedgehog();
            hedgehog.Age = age;
            hedgehog.Name = name;
            hedgehog.Weight = weight;
            hedgehog.NrOfSpikes = nrOfSpikes;

            return hedgehog;

        }

        public override string DoEat() {

            return " eats insecs";
        }

        public override string DoSound() {
            return "quiet snuffling to hissing, snarling, purring, whistling, clicking and even loud screaming ";
        }

    }
    //////////////////////////////////////////////////////
    class Horse : Animal {

        private double speed;
        public double Speed {
            get;
            set;
        }
        /*Skapa metoden  ​Stats() ​i klassen ​Animal​  som har returtypen 
         * ​string. ​Metoden skakunna ​overridas  ​i dess Subklasser. 
         * Metoden ska returnera alla egenskaper (​properties) ​somdjuret har.*/
        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.Speed;
        }

        public Horse() : base() {
            this.Speed = speed;
        }



        public Horse CreateHorse(int age, string name, decimal weight, double speed) {
            Horse horse = new Horse();
            horse.Age = age;
            horse.Name = name;
            horse.Weight = weight;
            horse.speed = speed;
            return horse;

        }

        public override string DoEat() {
            return " eats grass";
        }

        public override string DoSound() {
            return "neigh neigh neigh ";
        }

    }
    //////////////////////////////////////////////////////
    class Worm : Animal {

        //private string movement;
        public string Movement {
            get;
        }
        public bool IsPoisonous {
            set;
            get;
        }



        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.IsPoisonous+ this.Movement;
        }
        public Worm() : base() {
            this.Movement = "worms creeping";
        }



        public Worm CreateWorm(int age, string name, decimal weight, bool isPoisonous) {
            Worm worm = new Worm();
            worm.Age = age;
            worm.Name = name;
            worm.Weight = weight;
            worm.IsPoisonous = isPoisonous;
            return worm;

        }

        public override string DoEat() {

            return " eats leaves ";
        }

        public override string DoSound() {
            return "silent ";
        }

    }
    ////////////////////////////////////////////

    class Wolf : Animal {



        public Wolf() : base() {

        }
        public bool IsWiled {
            get;
            set;
        }


        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.IsWiled;
        }  
        public void hunting(string prey) {
            Console.WriteLine($" this favorite prey is { prey } ");
        }


        
        public Wolf CreateWolf(int age, string name, decimal weight) {
            Wolf wolf = new Wolf();
            wolf.Name = name;
            wolf.Weight = weight;
            return wolf;
        }

        public override string DoEat() {
            return " eats grass";
        }

        public override string DoSound() {
            return "neigh neigh neigh ";
        }

    }
    ////////////////////////////////
    class Bird : Animal {

        public int WingSpan {
            get;
            set;
        }


        

        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.WingSpan;
        }


        public Bird() : base() {

        }



        public Bird CreateBird(int age, string name, decimal weight, int wingSpan) {
            Bird bird = new Bird();
            bird.Age = age;
            bird.Name = name;
            bird.Weight = weight;
            bird.WingSpan = wingSpan;
            return bird;
        }

        public override string DoEat() {
            return " eats  worms ";
        }

        public override string DoSound() {
            return "twit twit ";
        }

    }
    ////////////////////////////////////////////



    class Pelican : Bird {
        public string Color { get; set; }

        public Pelican CreatePelican(int age, string name, string color) {
            Pelican pelican = new Pelican();
            pelican.Name = name;
            pelican.Age = age;
            pelican.Color = color;
            return pelican;

        }

        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.Color;
        }
    }
    /*************************************/
    class Flamingo : Bird {
        public decimal LegsLength { get; set; }

        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.LegsLength;
        }

        public Flamingo CreateFlamingo(int age, string name, decimal legsLength) {
            Flamingo flamingo = new Flamingo();
            flamingo.Name = name;
            flamingo.Age = age;
            flamingo.LegsLength = legsLength;
            return flamingo;

        }
    }


    /*************************************/

    class Swan : Bird {
        public decimal NeckLength { get; set; }

        public override string Stats() {
            return this.Name + this.Weight + this.Age + this.NeckLength;
        }

        public Swan CreateSwan(int age, string name, decimal neckLength) {
            Swan swan = new Swan();
            swan.Name = name;
            swan.Age = age;
            swan.NeckLength = neckLength;
            return swan;

        }
    }


}
