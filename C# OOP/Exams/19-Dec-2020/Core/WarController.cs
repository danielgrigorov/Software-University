using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> characterParty;
        private List<Item> itemPool;

        public WarController()
        {
            this.characterParty = new List<Character>();
            this.itemPool = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            if (args[0] != "Warrior" && args[0] != "Priest")
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidCharacterType, args[0]));
            }

            if (args[0] == "Warrior")
            {
                Character character = new Warrior(args[1]);
                this.characterParty.Add(character);
            }
            else if (args[0] == "Priest")
            {
                Character character = new Priest(args[1]);
                this.characterParty.Add(character);
            }

            return String.Format(SuccessMessages.JoinParty, args[1]);
        }

        public string AddItemToPool(string[] args)
        {
            if (args[0] != "HealthPotion" && args[0] != "FirePotion")
            {
                throw new ArgumentException(String.Format(ExceptionMessages.InvalidItem, args[0]));
            }

            if (args[0] == "HealthPotion")
            {
                Item item = new HealthPotion();
                this.itemPool.Add(item);
            }
            if (args[0] == "FirePotion")
            {
                Item item = new FirePotion();
                this.itemPool.Add(item);
            }

            return String.Format(SuccessMessages.AddItemToPool, args[0]);
        }

        public string PickUpItem(string[] args)
        {
            var characterExists = this.characterParty.FirstOrDefault(x => x.Name == args[0]);

            if (this.itemPool.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

            var itemToBeAdded = this.itemPool[itemPool.Count - 1];

            if (characterExists == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, args[0]));
            }

            characterExists.Bag.AddItem(itemToBeAdded);
            
            return String.Format(SuccessMessages.PickUpItem, characterExists.Name, itemToBeAdded.GetType().Name);
        }

        public string UseItem(string[] args)
        {
            var characterExists = this.characterParty.FirstOrDefault(x => x.Name == args[0]);

            if (characterExists == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CharacterNotInParty, args[0]));
            }

            if (characterExists.Bag.Capacity == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }


            if (args[1] == "FirePotion")
            {
                if (characterExists.Bag.Items.FirstOrDefault(x=>x.GetType().Name == "FirePotion") == null)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.ItemNotFoundInBag, args[1]));
                }

                var item = characterExists.Bag.GetItem(args[1]);

                characterExists.UseItem(item);

                return String.Format(SuccessMessages.UsedItem, characterExists.Name, item.GetType().Name);
            }
            if (args[1] == "HealthPotion")
            {

                var item = characterExists.Bag.GetItem(args[1]);

                characterExists.UseItem(item);

                return String.Format(SuccessMessages.UsedItem, characterExists.Name, item.GetType().Name);
            }
            return "";

        }

        public string GetStats()
        {
            var characters = this.characterParty.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health).ToList();

            var sb = new StringBuilder();

            for (int i = 0; i < characters.Count; i++)
            {
                string status = "";
                int baseHealth = 0;
                int baseArmor = 0;

                if (characters[i].IsAlive)
                {
                    status = "Alive";
                }
                else
                {
                    status = "Dead";
                }

                if (characters[i].GetType().Name == "Warrior")
                {
                    baseHealth = 100;
                    baseArmor = 50;
                }

                if (characters[i].GetType().Name == "Priest")
                {
                    baseHealth = 50;
                    baseArmor = 25;
                }

                sb.AppendLine($"{characters[i].Name} - HP: {characters[i].Health}/{baseHealth}, AP: {characters[i].Armor}/{baseArmor}, Status: {status}");
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            var attackerExists = this.characterParty.FirstOrDefault(x => x.Name == args[0]);
            var receiverExists = this.characterParty.FirstOrDefault(x => x.Name == args[1]);

            if (attackerExists == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, args[0]));
            }
            if (receiverExists == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, args[1]));
            }

            if (attackerExists.GetType().Name == "Priest")
            {
                throw new ArgumentException(String.Format(ExceptionMessages.AttackFail, attackerExists.Name));
            }

            if (attackerExists.GetType().Name == "Warrior")
            {
                var attackerWillattack = attackerExists as Warrior;

                attackerWillattack.Attack(receiverExists);

                var sb = new StringBuilder();

                sb.AppendLine($"{args[0]} attacks {args[1]} for {attackerWillattack.AbilityPoints} hit points! {receiverExists.Name} has {receiverExists.Health}/{receiverExists.BaseHealth} HP and {receiverExists.Armor}/{receiverExists.BaseArmor} AP left!");

                if (receiverExists.Health <= 0)
                {
                    sb.AppendLine($"{receiverExists.Name} is dead!");

                }

                return sb.ToString().TrimEnd();
            }

            return "";
        }

        public string Heal(string[] args)
        {
            var healerExists = this.characterParty.FirstOrDefault(x => x.Name == args[0]);
            var receiverExists = this.characterParty.FirstOrDefault(x => x.Name == args[1]);

            if (healerExists == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, args[0]));
            }
            if (receiverExists == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, args[1]));
            }

            if (healerExists.GetType().Name == "Warrior")
            {
                throw new ArgumentException(string.Format(ExceptionMessages.HealerCannotHeal, args[0]));
            }

            var priest = healerExists as Priest;

            priest.Heal(receiverExists);
            return $"{healerExists.Name} heals {receiverExists.Name} for {healerExists.AbilityPoints}! {receiverExists.Name} has {receiverExists.Health} health now!";
        }
    }
}
