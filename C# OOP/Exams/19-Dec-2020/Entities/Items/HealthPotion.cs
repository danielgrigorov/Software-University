using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class HealthPotion : Item
    {
        private const int initialWeight = 5;
        private const int characterHealthIncreasePoints = 20;

        public HealthPotion() : base(initialWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (character.IsAlive)
            {
                character.Health += characterHealthIncreasePoints;
            }
        }
    }
}
