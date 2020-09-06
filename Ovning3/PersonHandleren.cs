using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ovning3 {
    class PersonHandleren {

      

        public void SetAge(Person pers, int age) {
          
            pers.Age = age;
        }

        public void SetID(Person pers, long id) {

            pers.ID = id;
        }
        public void SetHeight(Person pers, double height) {

            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight) {

            pers.Weight = weight;
        }
        public void SetFname(Person pers, string fname) {

            pers.FName = fname;
        }
        public void SetLname(Person pers, string lname) {

            pers.LName = lname;
        }
        public void SetNationality(Person pers, string nationality) {

            pers.Nationality = nationality;
        }
        public void SetResidence(Person pers, string residenceCountry) {

            pers.ResidenceCóuntry = residenceCountry;
        } public void SetJob(Person pers, string job) {

            pers.Job = job;
        }






        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
            //  Person person = new Person( age, fname, lname, height, weight );
            Person pers = new Person();
            pers.Age = age;
            pers.FName = fname;
            pers.LName = lname;
            pers.Height = height;
            pers.Weight = weight;

            return pers;
        }
      
       

       
       

    }
}
