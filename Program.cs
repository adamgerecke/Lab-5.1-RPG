using System;
using System.Collections.Generic;

namespace Lab_5._1_RPG
{
    class GameCharacter
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
            Console.WriteLine($"{name} (Intelligence {intelligence}, Strength {strength})");
            
        }
    }

    class Warrior : GameCharacter
    {
        public string weapon { get; set; }

        public Warrior(string theName, int theStrength, int theIntelligence, string theWeapon) : base(theName, theStrength, theIntelligence)
        {
            weapon = theWeapon;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{name} uses a {weapon}, as their weapon of choice.");
            Console.WriteLine();
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        public int magicalEnergy { get; set; }
        public MagicUsingCharacter(string theName, int theStrength, int theIntelligence, int theMagicalEnergy) : base(theName, theStrength, theIntelligence)
        {
            magicalEnergy = theMagicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"In addition on their base stats {name}, has a pool of {magicalEnergy} magical energy.");
            
        }


    }


    class Wizard : MagicUsingCharacter
    {
        public int spellNumber { get; set; }

        public Wizard(string theName, int theStrength, int theIntelligence, int theMagicalEnergy, int theSpellNumber) : base(theName, theStrength, theIntelligence, theMagicalEnergy)
        {
            spellNumber = theSpellNumber;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"{name} is also able to cast {spellNumber} spells.");
            Console.WriteLine();
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.BuildCraft.");
            Console.WriteLine();

            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Warin", 18, 9, "Battle Axe"));
            gameCharacters.Add(new Warrior("Oxnar", 20, 6, "Flail"));
            gameCharacters.Add(new Warrior("Kong", 25, 12, "Great Sword"));
            gameCharacters.Add(new Warrior("Sigismund", 16, 12, "Battle Staff"));
            gameCharacters.Add(new Warrior("Warden", 20, 9, "Glaive"));
            gameCharacters.Add(new Warrior("La Crox", 16, 14, "Tribuchet"));

            gameCharacters.Add(new Wizard("Elizia", 9, 25, 50, 10));
            gameCharacters.Add(new Wizard("Rineheart", 6, 27, 54, 8));
            gameCharacters.Add(new Wizard("Dalenor", 12, 20, 40, 14));
            gameCharacters.Add(new Wizard("Edali", 14, 18, 36, 19));
            gameCharacters.Add(new Wizard("Ekonn", 17, 15, 30, 6));
            gameCharacters.Add(new Wizard("Sigoris", 17, 12, 24, 3));


            foreach(GameCharacter CharacterClass in gameCharacters)
            {
                CharacterClass.Play();
            }

        }
    }
}
