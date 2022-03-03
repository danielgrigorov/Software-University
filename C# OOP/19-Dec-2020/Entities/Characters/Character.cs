using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.

        private string name;
        private double health;
        private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.BaseArmor = armor;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }
        public bool IsAlive { get; internal set; } = true;

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                this.name = value;
            }
        }

        public double BaseHealth { get; protected set; }

        public double Health
        {
            get
            {
                return this.health;
            }
            internal set
            {
                if (value > this.BaseHealth)
                {
                    this.health = this.BaseHealth;
                }
                else if (value < 0)
                {
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public double BaseArmor { get; protected set; }

        public double Armor 
        {
            get
            {
                return this.armor;
            } 
            private set
            {
                this.armor = value;

                if (this.armor < 0)
                {
                    this.armor = 0;
                }
            } 
        }

        public double AbilityPoints { get; private set; }

        public Bag Bag { get; private set; }

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            if (this.IsAlive)
            {
                var armorDifference = this.Armor - hitPoints;
                var healthDifference = this.Health - (hitPoints - this.Armor);

                if (armorDifference <= 0)
                {
                    hitPoints -= this.Armor;
                    this.Armor = 0;

                    if ((healthDifference) <= 0)
                    {
                        this.Health = 0;
                        this.IsAlive = false;
                    }
                    else
                    {
                        this.Health -= hitPoints;
                    }
                }
                else
                {
                    this.Armor -= hitPoints;
                }
            }
        }

        public void UseItem(Item item)
        {
            if (this.IsAlive)
            {
                item.AffectCharacter(this);
            }
        }
    }
}