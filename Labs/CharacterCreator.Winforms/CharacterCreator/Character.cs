using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
   public class Characters
    {

        private String Name;
        private int Profession;
        private int Race;
        private int Strength;
        private int Intelligence;
        private int Agility;
        private int Constitution;
        private int Charisma;
        private String Biography;

        public void setName(String name) {
            this.Name = name;
        }

        public String getName() {
            return this.Name;
        }
        public void setProfession(int profession)
        {
            this.Profession = profession;
        }
        public int getProfession() {
            return this.Profession;
        }
        public void setRace(int race)
        {
            this.Race = race;
        }
        public int getRace() {
            return this.Race;
        }
        public void setStrength(int strength)
        {
            this.Strength = strength;
        }

        public int getStrength() {
            return this.Strength;
        }

        public void setIntelligence(int intelligence)
        {
            this.Intelligence = intelligence;
        }
        public int getIntelligence()
        {
            return this.Intelligence;
        }
        public void setAgility(int agility)
        {
            this.Agility = agility;
        }
        public int getAgility()
        {
            return this.Agility;
        }

        public void setConstitution(int constitution)
        {
            this.Constitution = constitution;
        }
        public int getConstitution()
        {
            return this.Constitution;
        }
        public void setCharisma(int charisma)
        {
            this.Charisma = charisma;
        }
        public int getCharisma()
        {
            return this.Charisma;
        }
       public void setBiography(String biography)
        {
            this.Biography = biography;
        }
       public String getBiography() {
           return this.Biography;
       }



    }
}
