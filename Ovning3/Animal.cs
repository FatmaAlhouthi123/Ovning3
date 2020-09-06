using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3 {
    abstract class Animal {
        private string  name;
        private decimal weight;
        private int age;

        public virtual string Stats() {
            return this.Name + this.Weight+ this.Age;
        }





        public string Name {
            get;
            set;
        }
        public decimal Weight {
            get;
            set;
        }
        public int Age {
            get;
            set;
        }


        public  Animal (){
            this.Age = age;
            this.Name = name;
             this.Weight = weight;
         }


        
        public abstract string   DoSound();
        public abstract string   DoEat();
    }

}