using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Text;

namespace Ovning3 {
    public class Person {
        private int age;
        private string fName;
        private string nationality;
        private string lName;
        private double height;
        private double weight;

        public string Job {
            get; set;
        }
        public string Nationality {
            get
            {
                return nationality;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 30) nationality = value;
                else
                    throw new ArgumentException("Error!  Nationality must be between 2 and 30 letters");


            }
        }
        public string ResidenceCóuntry {
            get; set;
        }

        public long ID {
            get;
            set;
        }


        public int Age {
            get
            {
                return age;
            }
            set
            {
                if (value > 0) age = value;
                else
                    throw new ArgumentException("Error!  Age must be older than 0");

            }

        }


        public string FName {
            get { return fName; }

            set
            {

                if (value.Length >= 2 && value.Length <= 10) fName = value;
                else
                    throw new ArgumentException("Error!  First Name must be between 2 and 10 letters");

            }
        }



        public string LName {
            get { return lName; }

            set
            {

                if (value.Length >= 2 && value.Length <= 10) lName = value;
                else
                    throw new ArgumentException("Error!  Last Name must be between 2 and 10 letters");

            }
        }
        public double Height { get => height; set => height = value; }


        public double Weight { get => weight; set => weight = value; }


        public Person(int age, string fname, string lname, double height, double weight) {

            this.Age = age;
            this.FName = fname;
            this.LName = lname;
            this.Height = height;
            this.Weight = weight;
        }

        public Person() {

        }



    }
}