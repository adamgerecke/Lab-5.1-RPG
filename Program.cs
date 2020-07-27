using System;
using System.Collections.Generic;

namespace Lab_5._1_RPG
{
    class GameCharacter // base calss to hold info every playable class will need. Intelligence, Strength, and Name
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }

        public GameCharacter(string theName, int theStrength, int theIntelligence)
        {
            name = theName;
            strength = theStrength;
            intelligence = theIntelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"{name} (Intelligence {intelligence}, Strength {strength})"); // Displays base stats for all classes created.         
        }
    }

    class Warrior : GameCharacter // Warrior Class, has Base Stats, in addiition to a weapon of choice.
    {
        public string weapon { get; set; }

        public Warrior(string theName, int theStrength, int theIntelligence, string theWeapon) : base(theName, theStrength, theIntelligence)
        {
            weapon = theWeapon;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{name} uses a {weapon}, as their weapon of choice."); // After adding the base stats message, adds a weapon of choice for the hero.
            Console.WriteLine();
        }
    }

    class MagicUsingCharacter : GameCharacter // Defines a Magic Using Character, with base stats, in addition to Magical Energy Stat.
    {
        public int magicalEnergy { get; set; }
        public MagicUsingCharacter(string theName, int theStrength, int theIntelligence, int theMagicalEnergy) : base(theName, theStrength, theIntelligence)
        {
            magicalEnergy = theMagicalEnergy;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"In addition on their base stats {name}, has a pool of {magicalEnergy} magical energy."); // base message + amount of magical energy
            
        }
    }


    class Wizard : MagicUsingCharacter // Defines Wizard Class, which takes all of the Stats the Magic Using Class has, in addition to a number of Magical Spells.
    {
        public int spellNumber { get; set; }
        public Wizard(string theName, int theStrength, int theIntelligence, int theMagicalEnergy, int theSpellNumber) : base(theName, theStrength, theIntelligence, theMagicalEnergy)
        {
            spellNumber = theSpellNumber;
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{name} is also able to cast {spellNumber} spells."); // base magic user message with stats and energy, in addition to spells known.
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.BuildCraft.");
            Console.WriteLine();

            List<GameCharacter> character = new List<GameCharacter>(); // new list character based off of the GameCharacter Class

            character.Add(new Warrior("Warin", 18, 9, "Battle Axe"));    //Name|Strength|Intelligence|Weapon of Choice
            character.Add(new Warrior("Oxnar", 20, 6, "Flail"));
            character.Add(new Warrior("Kong", 25, 12, "Great Sword"));
            character.Add(new Warrior("Wiggin", 16, 12, "Battle Staff"));
            character.Add(new Warrior("Warden", 20, 9, "Glaive"));
            character.Add(new Warrior("La Crox", 16, 14, "Tribuchet"));

            character.Add(new Wizard("Elizia", 9, 25, 50, 10));        //Name|Strength|Intelligence|Magical Energy|Known Spell Count
            character.Add(new Wizard("Rineheart", 6, 27, 54, 8));
            character.Add(new Wizard("Dalenor", 12, 20, 40, 14));
            character.Add(new Wizard("Edali", 14, 18, 36, 19));
            character.Add(new Wizard("Ekonn", 17, 15, 30, 6));
            character.Add(new Wizard("Sigoris", 17, 12, 24, 3));


            foreach(GameCharacter CharacterClass in character)  // for each entry of the class GameCharacter run the Play Method on the CharacterClass Variable of character.
            {
                CharacterClass.Play();
            }
        }
    }
}
